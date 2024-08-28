using ExcelImportApp.Data;
using ExcelImportApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ExcelImportApp.Controllers
{
    public class HouseOwnerDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public HouseOwnerDetailsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var data = await _context.HouseOwnerDetails.ToListAsync();
            //return View(data);
            return View();
        }




        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                ModelState.AddModelError("File", "Please upload a file.");
                return View("Index");
            }

            // Validate file type (e.g., .xlsx)
            if (!file.FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                ModelState.AddModelError("File", "Please upload a valid Excel file (.xlsx).");
                return View("Index");
            }

            //  using var transaction = _context.Database.BeginTransaction();

            var data = new List<HouseOwnerDetail>();
            try
            {
                using var package = new ExcelPackage(file.OpenReadStream());
                var sheetZero = package.Workbook.Worksheets[0];
                var rowCountZero = sheetZero.Dimension.Rows;
                Console.WriteLine("Row count of Zero page is: " + rowCountZero);
                Console.WriteLine("Name of 3 row: " + sheetZero.Cells[3, 4].Text);
                Console.WriteLine("Name of 3 row: " + sheetZero.Cells[3, 7].Text);
                int? gender = sheetZero.Cells[3, 6].Text == "पुरुष" ? 1 : sheetZero.Cells[3, 6].Text == "महिला" ? 2 : sheetZero.Cells[3, 6].Text == "तेस्रो लिंगी" ? 3 : null;
                Console.WriteLine("Gender of 56 row: " + gender);
                int? houseId = sheetZero.Cells[3, 57].Text == "कच्ची र झुप्रो" ? 1 :
                                sheetZero.Cells[3, 57].Text == "ढुंगा ,माटो र टिनको छाना /ढुंगा को छाना" ? 2 :
                                sheetZero.Cells[3, 57].Text == "प्लास्टर गरिएको र टिन को छाना" ? 3 :
                                sheetZero.Cells[3, 57].Text == "इटा र ढलान को छाना" ? 4 :
                                sheetZero.Cells[3, 57].Text == "ढलान फ्रेम स्टकचर" ? 5 :
                                sheetZero.Cells[3, 57].Text == "अन्य" ? 6 : null;
                Console.WriteLine("HouseId of 56 row: " + houseId);

                //Console.WriteLine("LocalLevel of 56 row: ", _context.Wards.Where(x => x.Id == Convert.ToInt32(sheetZero.Cells[56, 9].Text))
                //                .Select(x => x.LocalLevelId).FirstOrDefault() ?? 0);


                var sheetOne = package.Workbook.Worksheets[1];
                var rowCountOne = sheetOne.Dimension.Rows;

                var sheetTwo = package.Workbook.Worksheets[2];
                var rowCountTwo = sheetTwo.Dimension.Rows;

                var sheetThree = package.Workbook.Worksheets[3];
                var rowCountThree = sheetThree.Dimension.Rows;

                var sheetFour = package.Workbook.Worksheets[4];
                var rowCountFour = sheetFour.Dimension.Rows;

                for (int row = 3; row <= rowCountZero; row++)
                {
                    //var cModel = Utility.Common.GetAddressInfoForLoginUser();

                    var record = new HouseOwnerDetail
                    {
                        Name = sheetZero.Cells[row, 4].Text,
                        Type = sheetZero.Cells[row, 5].Text,
                        GenderId = GetGenderId(sheetZero.Cells[row, 6].Text),
                        ContactNo = sheetZero.Cells[row, 7].Text,
                        OldWardNo = ParseInt(sheetZero.Cells[row, 8].Text),
                        WardNo = ParseInt(sheetZero.Cells[row, 9].Text),
                        Address = sheetZero.Cells[row, 10].Text,
                        HouseNo = sheetZero.Cells[row, 11].Text,

                        TotalFamilyCount = ParseInt(sheetZero.Cells[row, 12].Text),
                        MaleFamilyCount = ParseInt(sheetZero.Cells[row, 13].Text),
                        FemaleFamilyCount = ParseInt(sheetZero.Cells[row, 14].Text),
                        OtherFamilyCount = ParseInt(sheetZero.Cells[row, 15].Text),

                        TogetherCount = ParseInt(sheetZero.Cells[row, 16].Text),
                        TogetherMaleCount = ParseInt(sheetZero.Cells[row, 17].Text),
                        TogetherFemaleCount = ParseInt(sheetZero.Cells[row, 18].Text),
                        TogetherOtherCount = ParseInt(sheetZero.Cells[row, 19].Text),

                        ResidingCount = ParseInt(sheetZero.Cells[row, 20].Text),
                        ResidingMaleCount = ParseInt(sheetZero.Cells[row, 21].Text),
                        ResidingFemaleCount = ParseInt(sheetZero.Cells[row, 22].Text),
                        ResidingOtherCount = ParseInt(sheetZero.Cells[row, 23].Text),

                        ResidingAbroadCount = ParseInt(sheetZero.Cells[row, 24].Text),
                        ResidingAbroadMaleCount = ParseInt(sheetZero.Cells[row, 25].Text),
                        ResidingAbroadFemaleCount = ParseInt(sheetZero.Cells[row, 26].Text),
                        ResidingAbroadOtherCount = ParseInt(sheetZero.Cells[row, 27].Text),

                        MarriedMan = ParseInt(sheetZero.Cells[row, 28].Text),
                        UnMarriedMan = ParseInt(sheetZero.Cells[row, 29].Text),
                        MarriedWoman = ParseInt(sheetZero.Cells[row, 30].Text),
                        UnMarriedWoman = ParseInt(sheetZero.Cells[row, 31].Text),

                        AnyJesthaNagarik = ParseBoolean(sheetZero.Cells[row, 32].Text),
                        SeniorCitizensTotal = ParseInt(sheetZero.Cells[row, 33].Text),
                        SeniorCitizensMan = ParseInt(sheetZero.Cells[row, 34].Text),
                        SeniorCitizensWoman = ParseInt(sheetZero.Cells[row, 35].Text),
                        SeniorCitizensOthers = ParseInt(sheetZero.Cells[row, 36].Text),

                        AnySingleWomen = ParseBoolean(sheetZero.Cells[row, 37].Text),
                        SingleWomenCount = ParseInt(sheetZero.Cells[row, 38].Text),

                        AnyHasFamilyMemberMoved = ParseBoolean(sheetZero.Cells[row, 39].Text),

                        HouseTypeId = GetHouseTypeId(sheetZero.Cells[row, 57].Text),

                        IsUnEmployedMember = ParseBoolean(sheetZero.Cells[row, 59].Text),

                        SkillTypeId = GetSkillTypeId(sheetZero.Cells[row, 60].Text),

                        LandAnna = sheetZero.Cells[row, 61].Text,
                        LandRopani = sheetZero.Cells[row, 62].Text,
                        ChildrenSchoolType = sheetZero.Cells[row, 63].Text,

                        IsVehicle = ParseBoolean(sheetZero.Cells[row, 64].Text),
                        VehicleId = GetVehicleId(sheetZero.Cells[row, 65].Text),

                        IsNaturalDisasterArea = ParseBoolean(sheetZero.Cells[row, 71].Text),

                        NaturalDisasterId = GetNaturalDisasterId(sheetZero.Cells[row, 72].Text),

                        Earthquake2072Id = GetEarthquake2072Id(sheetZero.Cells[row, 73].Text),

                        IsEarthquakeAnudan = ParseBoolean(sheetZero.Cells[row, 74].Text),
                        EarthquakeKista = sheetZero.Cells[row, 75].Text,

                        Photo = "photo.jpg",
                        GharKoPhoto = "house.jpg",

                        CreatedDate = DateTime.Now.Date,
                        CreatedBy = "phalelung@gmail.com"
                    };

                  


                    //var record = new HouseOwnerDetail
                    //{
                    //    Name = sheetZero.Cells[row, 4].Text,
                    //    Type = sheetZero.Cells[row, 5].Text,
                    //    GenderId = sheetZero.Cells[row, 6].Text == "पुरुष" ? 1 : sheetZero.Cells[row, 6].Text == "महिला" ? 2 : sheetZero.Cells[row, 6].Text == "तेस्रो लिंगी" ? 3 : null,
                    //    ContactNo = sheetZero.Cells[row, 7].Text,
                    //    OldWardNo = Convert.ToInt32(sheetZero.Cells[row, 8].Text),
                    //    WardNo = Convert.ToInt32(sheetZero.Cells[row, 9].Text),
                    //    Address = sheetZero.Cells[row, 10].Text,
                    //    HouseNo = sheetZero.Cells[row, 11].Text,

                    //    TotalFamilyCount = Convert.ToInt32(sheetZero.Cells[row, 12].Text),
                    //    MaleFamilyCount = Convert.ToInt32(sheetZero.Cells[row, 13].Text),
                    //    FemaleFamilyCount = Convert.ToInt32(sheetZero.Cells[row, 14].Text),
                    //    OtherFamilyCount = Convert.ToInt32(sheetZero.Cells[row, 15].Text),

                    //    TogetherCount = Convert.ToInt32(sheetZero.Cells[row, 16].Text),
                    //    TogetherMaleCount = Convert.ToInt32(sheetZero.Cells[row, 17].Text),
                    //    TogetherFemaleCount = Convert.ToInt32(sheetZero.Cells[row, 18].Text),
                    //    TogetherOtherCount = Convert.ToInt32(sheetZero.Cells[row, 19].Text),

                    //    ResidingCount = Convert.ToInt32(sheetZero.Cells[row, 20].Text),
                    //    ResidingMaleCount = Convert.ToInt32(sheetZero.Cells[row, 21].Text),
                    //    ResidingFemaleCount = Convert.ToInt32(sheetZero.Cells[row, 22].Text),
                    //    ResidingOtherCount = Convert.ToInt32(sheetZero.Cells[row, 23].Text),

                    //    ResidingAbroadCount = Convert.ToInt32(sheetZero.Cells[row, 24].Text),
                    //    ResidingAbroadMaleCount = Convert.ToInt32(sheetZero.Cells[row, 25].Text),
                    //    ResidingAbroadFemaleCount = Convert.ToInt32(sheetZero.Cells[row, 26].Text),
                    //    ResidingAbroadOtherCount = Convert.ToInt32(sheetZero.Cells[row, 27].Text),

                    //    MarriedMan = Convert.ToInt32(sheetZero.Cells[row, 28].Text),
                    //    UnMarriedMan = Convert.ToInt32(sheetZero.Cells[row, 29].Text),
                    //    MarriedWoman = Convert.ToInt32(sheetZero.Cells[row, 30].Text),
                    //    UnMarriedWoman = Convert.ToInt32(sheetZero.Cells[row, 31].Text),

                    //    AnyJesthaNagarik = sheetZero.Cells[row, 32].Text == "छ" ? true : sheetZero.Cells[row, 32].Text == "छैन" ? false : false,
                    //    SeniorCitizensTotal = Convert.ToInt32(sheetZero.Cells[row, 33].Text),
                    //    SeniorCitizensMan = Convert.ToInt32(sheetZero.Cells[row, 34].Text),
                    //    SeniorCitizensWoman = Convert.ToInt32(sheetZero.Cells[row, 35].Text),
                    //    SeniorCitizensOthers = Convert.ToInt32(sheetZero.Cells[row, 36].Text),

                    //    AnySingleWomen = sheetZero.Cells[row, 37].Text == "छ" ? true : sheetZero.Cells[row, 37].Text == "छैन" ? false : false,
                    //    SingleWomenCount = Convert.ToInt32(sheetZero.Cells[row, 38].Text),

                    //    AnyHasFamilyMemberMoved = sheetZero.Cells[row, 39].Text == "छ" ? true : sheetZero.Cells[row, 39].Text == "छैन" ? false : false,

                    //    HouseTypeId = sheetZero.Cells[row, 57].Text == "कच्ची र झुप्रो" ? 1 :
                    //            sheetZero.Cells[row, 57].Text == "ढुंगा ,माटो र टिनको छाना /ढुंगा को छाना" ? 2 :
                    //            sheetZero.Cells[row, 57].Text == "प्लास्टर गरिएको र टिन को छाना" ? 3 :
                    //            sheetZero.Cells[row, 57].Text == "इटा र ढलान को छाना" ? 4 :
                    //            sheetZero.Cells[row, 57].Text == "ढलान फ्रेम स्टकचर" ? 5 :
                    //            sheetZero.Cells[row, 57].Text == "अन्य" ? 6 : null,

                    //    //IsLandRanted = sheetZero.Cells[row, 58].Text == "छ" ? true : sheetZero.Cells[row, 58].Text == "छैन" ? false : false,

                    //    IsUnEmployedMember = sheetZero.Cells[row, 59].Text == "छ" ? true : sheetZero.Cells[row, 59].Text == "छैन" ? false : false,

                    //    SkillTypeId = sheetZero.Cells[row, 60].Text == "डाक्टर" ? 1 :
                    //            sheetZero.Cells[row, 60].Text == "इन्जिनियर" ? 2 :
                    //            sheetZero.Cells[row, 60].Text == "वकिल" ? 3 :
                    //            sheetZero.Cells[row, 60].Text == "ईलेक्त्रिसियिन" ? 4 :
                    //            sheetZero.Cells[row, 60].Text == "अन्य" ? 9 : null,

                    //    LandAnna = sheetZero.Cells[row, 61].Text,
                    //    LandRopani = sheetZero.Cells[row, 62].Text,
                    //    ChildrenSchoolType = sheetZero.Cells[row, 63].Text,

                    //    IsVehicle = sheetZero.Cells[row, 64].Text == "छ" ? true : sheetZero.Cells[row, 64].Text == "छैन" ? false : false,
                    //    VehicleId = sheetZero.Cells[row, 65].Text == "साईकल" ? 1 :
                    //            sheetZero.Cells[row, 65].Text == "मोटरसाईकल" ? 2 :
                    //            sheetZero.Cells[row, 65].Text == "ट्याक्सी, जिप" ? 3 :
                    //            sheetZero.Cells[row, 65].Text == "बस, ट्रक" ? 4 :
                    //            sheetZero.Cells[row, 65].Text == "ट्राक्टर" ? 5 : null,

                    //    IsNaturalDisasterArea = sheetZero.Cells[row, 71].Text == "छ" ? true : sheetZero.Cells[row, 71].Text == "छैन" ? false : null,

                    //    NaturalDisasterId = sheetZero.Cells[row, 72].Text == "पहिरो" ? 1 :
                    //            sheetZero.Cells[row, 72].Text == "बाडी" ? 2 :
                    //            sheetZero.Cells[row, 72].Text == "महामारी" ? 3 :
                    //            sheetZero.Cells[row, 72].Text == "अन्य" ? 4 : null,

                    //    Earthquake2072Id = sheetZero.Cells[row, 73].Text == "भाडा बा डेरामा" ? 1 :
                    //            sheetZero.Cells[row, 73].Text == "आफन्तकोमा" ? 2 :
                    //            sheetZero.Cells[row, 73].Text == "टहरा वा छाप्रोमा" ? 3 :
                    //            sheetZero.Cells[row, 73].Text == "असर नपर्ने" ? 4 :
                    //            sheetZero.Cells[row, 73].Text == "अन्य" ? 5 : null,

                    //    IsEarthquakeAnudan = sheetZero.Cells[row, 74].Text == "छ" ? true : sheetZero.Cells[row, 74].Text == "छैन" ? false : null,
                    //    EarthquakeKista = sheetZero.Cells[row, 75].Text,

                    //    //LocalLevelId = _context.Wards.Where(x => x.Id == Convert.ToInt32(sheetZero.Cells[row, 9].Text))
                    //    //        .Select(x => x.LocalLevelId).FirstOrDefault() ?? 0,

                    //    Photo = "photo.jpg",
                    //    GharKoPhoto = "house.jpg",

                    //    CreatedDate = DateTime.Now.Date,
                    //    CreatedBy = "ExcelData"



                    //};

                    var save = await _context.HouseOwnerDetails.AddAsync(record);
                    await _context.SaveChangesAsync();

                    var maxCode = _context.HouseOwnerCodes.Where(x => x.LocalLavelId == record.LocalLevelId && x.WardId == record.WardNo).DefaultIfEmpty().Max(x => x == null ? 0 : x.Code);
                    var codes = new HouseOwnerCode()
                    {
                        LocalLavelId = (long)record.LocalLevelId,
                        WardId = record.WardNo,
                        Code = maxCode + 1,
                        HouseOwnerId = record.Id,
                    };

                    await _context.HouseOwnerCodes.AddAsync(codes);
                    await _context.SaveChangesAsync();

                    if (record.AnyHasFamilyMemberMoved == true)
                    {
                        var family = new MovedFamilyMemberDetail()
                        {
                            HouseOwnerDetailsId = record.Id,
                            Name = sheetZero.Cells[row, 40].Text,
                            Address = sheetZero.Cells[row, 41].Text,
                            Total = ParseInt(sheetZero.Cells[row, 42].Text),
                            TotalMale = ParseInt(sheetZero.Cells[row, 43].Text),
                            TotalFemale = ParseInt(sheetZero.Cells[row, 44].Text),
                            Remarks = sheetZero.Cells[row, 45].Text,
                        };

                        await _context.MovedFamilyMemberDetails.AddAsync(family);
                        await _context.SaveChangesAsync();
                    }

                    //in foreign country
                    if (sheetZero.Cells[row, 46].Text == "छ")
                    {
                        if (sheetZero.Cells[row, 47].Text != null) //bharat data insert
                        {
                            var subItem = new HouseOwnerCountryGroup()
                            {
                                CountryId = 1,   //barat id in database
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 47].Text),
                            };

                            await _context.HouseOwnerCountryGroups.AddAsync(subItem);
                        }
                        if (sheetZero.Cells[row, 48].Text != null) //khadi data insert
                        {
                            var subItem = new HouseOwnerCountryGroup()
                            {
                                CountryId = 2,   //khadi id in database
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 48].Text),
                            };
                            await _context.HouseOwnerCountryGroups.AddAsync(subItem);
                        }
                        if (sheetZero.Cells[row, 49].Text != null) //anya data insert
                        {
                            var subItem = new HouseOwnerCountryGroup()
                            {
                                CountryId = 3,   //anya id in database
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 49].Text),
                            };
                            await _context.HouseOwnerCountryGroups.AddAsync(subItem);
                        }
                        await _context.SaveChangesAsync();
                    }

                    //in foreign from time
                    if (sheetZero.Cells[row, 50].Text == "छ")
                    {
                        if (sheetZero.Cells[row, 51].Text != null) //१०.१ १ बर्ष भन्दा कम
                        {
                            var subItem = new HouseOwnerAbdhiGroup()
                            {
                                AbhadhiId = 1, // id of the १०.१ १ बर्ष भन्दा कम
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 51].Text),
                            };
                            await _context.HouseOwnerAbdhiGroups.AddAsync(subItem);
                        }
                        if (sheetZero.Cells[row, 52].Text != null) //१०.२ २ बर्ष भन्दा कम
                        {
                            var subItem = new HouseOwnerAbdhiGroup()
                            {
                                AbhadhiId = 2, // id of the १०.१ १ बर्ष भन्दा कम
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 52].Text),
                            };
                            await _context.HouseOwnerAbdhiGroups.AddAsync(subItem);
                        }
                        if (sheetZero.Cells[row, 53].Text != null) //१०.३ ३ बर्ष भन्दा कम
                        {
                            var subItem = new HouseOwnerAbdhiGroup()
                            {
                                AbhadhiId = 3, // id of the १०.१ १ बर्ष भन्दा कम
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 53].Text),
                            };
                            await _context.HouseOwnerAbdhiGroups.AddAsync(subItem);
                        }
                        if (sheetZero.Cells[row, 54].Text != null) //१०.४ ४ बर्ष भन्दा कम
                        {
                            var subItem = new HouseOwnerAbdhiGroup()
                            {
                                AbhadhiId = 4, // id of the १०.१ १ बर्ष भन्दा कम
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 54].Text),
                            };
                            await _context.HouseOwnerAbdhiGroups.AddAsync(subItem);
                        }
                        if (sheetZero.Cells[row, 55].Text != null) //१०.५ ५ बर्ष भन्दा कम
                        {
                            var subItem = new HouseOwnerAbdhiGroup()
                            {
                                AbhadhiId = 5, // id of the १०.१ १ बर्ष भन्दा कम
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 55].Text),
                            };
                            await _context.HouseOwnerAbdhiGroups.AddAsync(subItem);
                        }
                        if (sheetZero.Cells[row, 56].Text != null) //१०.६ ६ बर्ष भन्दा बढि
                        {
                            var subItem = new HouseOwnerAbdhiGroup()
                            {
                                AbhadhiId = 6, // id of the १०.१ १ बर्ष भन्दा कम
                                HouseOwnerId = record.Id,
                                Count = ParseInt(sheetZero.Cells[row, 56].Text),
                            };
                            await _context.HouseOwnerAbdhiGroups.AddAsync(subItem);
                        }
                        await _context.SaveChangesAsync();
                    }
                }

                //     transaction.Commit();
                return View();
            }
            catch (Exception ex)
            {
                // transaction.Rollback();
                return View();
            }
        }

        private int ParseInt(string value) => int.TryParse(value, out var result) ? result : 0;
        private bool ParseBoolean(string value) => value == "छ";
        private int? GetGenderId(string text) => text switch
        {
            "पुरुष" => 1,
            "महिला" => 2,
            "तेस्रो लिंगी" => 3,
            _ => null
        };
        private int? GetHouseTypeId(string text) => text switch
        {
            "कच्ची र झुप्रो" => 1,
            "ढुंगा ,माटो र टिनको छाना /ढुंगा को छाना" => 2,
            "प्लास्टर गरिएको र टिन को छाना" => 3,
            "इटा र ढलान को छाना" => 4,
            "ढलान फ्रेम स्टकचर" => 5,
            "अन्य" => 6,
            _ => null
        };
        private int? GetSkillTypeId(string text) => text switch
        {
            "डाक्टर" => 1,
            "इन्जिनियर" => 2,
            "वकिल" => 3,
            "ईलेक्त्रिसियिन" => 4,
            "अन्य" => 9,
            _ => null
        };
        private int? GetVehicleId(string text) => text switch
        {
            "साईकल" => 1,
            "मोटरसाईकल" => 2,
            "ट्याक्सी, जिप" => 3,
            "बस, ट्रक" => 4,
            "ट्राक्टर" => 5,
            _ => null
        };
        private int? GetNaturalDisasterId(string text) => text switch
        {
            "पहिरो" => 1,
            "बाडी" => 2,
            "महामारी" => 3,
            "अन्य" => 4,
            _ => null
        };
        private int? GetEarthquake2072Id(string text) => text switch
        {
            "भाडा बा डेरामा" => 1,
            "आफन्तकोमा" => 2,
            "टहरा वा छाप्रोमा" => 3,
            "असर नपर्ने" => 4,
            "अन्य" => 5,
            _ => null
        };
    }
}
