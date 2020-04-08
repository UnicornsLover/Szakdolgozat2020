using Microsoft.VisualStudio.TestTools.UnitTesting;
using Szakdolgozat2020.Modell.Children;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szakdolgozat2020.Modell.Children.Tests
{
    [TestClass()]
    public class ChildTests
    {
        [TestMethod()]
        public void isValidTestGood()
        {
            try
            {
                Child cc = new Child(1, "Szabó Péter", "férfi", "785962LO", "789963365", "2005-12-04", "Szeged", "2008-06-01", "Szeged");
                if (cc.isValid())
                {
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Minden jó mégis hibát dob");
            }
        }

        [TestMethod()]
        public void iValidTestEmptyBad()
        {
            try
            {
                Child ss = new Child(1, "", "férfi", "785962LO", "789963365", "2005-12-04", "Szeged", "2008-06-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Üres név esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidNameException mce)
            {
                if (mce.Message != "Nem megfelelő 'Neve' mező, kezdje nagy betűvel a nevet és legalább 4 karakter hosszú legyen. Számot ne tartalamzzon. Kérlek próbáld újra!")
                    Assert.Fail("Üres név esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Üres név esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        [TestMethod()]
        public void iValidTestNotUppercaseBad()
        {
            try
            {
                Child ss = new Child(1, "szabó Péter", "férfi", "785962LO", "789963365", "2005-12-04", "Szeged", "2008-06-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Kis betüs név esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidNameException mce)
            {
                if (mce.Message != "Nem megfelelő 'Neve' mező, kezdje nagy betűvel a nevet és legalább 4 karakter hosszú legyen. Számot ne tartalamzzon. Kérlek próbáld újra!")
                    Assert.Fail("Kis betüs név esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Kis betüs név esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        [TestMethod()]
        public void iValidTestNumberContainsBad()
        {
            try
            {
                Child ss = new Child(1, "12Szabó Péter", "férfi", "785962LO", "789963365", "2005-12-04", "Szeged", "2008-06-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Számmal kezdődik esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidNameException mce)
            {
                if (mce.Message != "Nem megfelelő 'Neve' mező, kezdje nagy betűvel a nevet és legalább 4 karakter hosszú legyen. Számot ne tartalamzzon. Kérlek próbáld újra!")
                    Assert.Fail("Számmal kezdődik esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Számmal kezdődik esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }

        [TestMethod()]
        public void iValidTestSexEmptyBad()
        {
            try
            {
                Child ss = new Child(1, "Szabó Péter", "", "785962LO", "789963365", "2005-12-04", "Szeged", "2008-06-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Üres nem esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidSexException mce)
            {
                if (mce.Message != "Nem megfelelő 'Neme' mező, kattintson a lefele mutató nyilra 'Neme' mezőnél és a legördülő menő segítségével válasza ki a nemet.")
                    Assert.Fail("Üres nem esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Üres nem esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        [TestMethod()]
        public void iValidTestIdCardOnlyNumberBad()
        {
            try
            {
                Child ss = new Child(1, "Szabó Péter", "férfi", "78596212", "789963365", "2005-12-04", "Szeged", "2008-06-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Csak számot tartalmaz id card esetén nem dob kivételt!");
                }
            }
            catch (MedellNotValidChiIdcardException mce)
            {
                if (mce.Message != "Nem megfelelő 'Személyigazolvány szám:' mező. Kérlek figyelj a formátumra. Pl: 123456AB")
                    Assert.Fail("Csak számot tartalmaz id card esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Csak számot tartalmaz id card esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        [TestMethod()]
        public void iValidTestTajNumberContainsLetterBad()
        {
            try
            {
                Child ss = new Child(1, "Szabó Péter", "férfi", "785962LA", "79963AA65", "2005-12-04", "Szeged", "2008-06-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Betűt tartalmaz a taj szám esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidTajnumberException mce)
            {
                if (mce.Message != "Nem megfelelő 'Taj szam:' mező. Kérlek figyelj oda a formátumra, csak számot tartalmazhat. pl:123456789")
                    Assert.Fail("Betűt tartalmaz a taj szám esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Betűt tartalmaz a taj szám esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }

        [TestMethod()]
        public void iValidTestCityNotUppercaseBad()
        {
            try
            {
                Child ss = new Child(1, "Szabó Péter", "férfi", "785962LA", "799631265", "2005-12-04", "szeged", "2008-06-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Születési Város név kis betűvel kezdődik esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidBirthplaceException mce)
            {
                if (mce.Message != "Nem megfelelő 'Születési hely' mező, kezdje nagy betűvel a város nevet. Kérem próbálja újra.")
                    Assert.Fail("Születési Város név kis betűvel esetén dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Születési Város név kis betűvel esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        [TestMethod()]
        public void iValidTestCityNotUppercaseLocationBad()
        {
            try
            {
                Child ss = new Child(1, "Szabó Péter", "férfi", "785962LA", "799631265", "2005-12-04", "Szeged", "2008-06-01", "szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Tartózkodás Város név kis betűvel kezdődik esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidLocationException mce)
            {
                if (mce.Message != "Nem megfelelő 'Intézmény helye, ahol tartózkodik:' mező. Kezdje nagy betűvel a város nevét, irányitó számot ne írjon. Kérem próbálja újra.")
                    Assert.Fail("Tartózkodás Város név kis betűvel esetén dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Tartózkodás Város név kis betűvel esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        [TestMethod()]
        public void iValidTestBDayBad()
        {
            try
            {
                Child ss = new Child(1, "Szabó Péter", "férfi", "785962LA", "799631265", "1990-01-01", "Szeged", "2008-06-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Születési idő nem lett beállítva esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidBirthdayException mce)
            {
                if (mce.Message != "Nem megfelelő 'Születési idő:' mező, kérem állítsa be a felvett személy születési dátumát!")
                    Assert.Fail("Születési idő nem lett beállítva esetén dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Születési idő nem lett beállítva esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        [TestMethod()]
        public void iValidTestComminDateBad()
        {
            try
            {
                Child ss = new Child(1, "Szabó Péter", "férfi", "785962LA", "799631265", "2008-06-01", "Szeged", "1990-01-01", "Szeged");
                if (ss.isValid())
                {
                    Assert.Fail("Iktatási idő nem lett beállítva esetén nem dob kivételt!");
                }
            }
            catch (ModellChildNotValidComingException mce)
            {
                if (mce.Message != "Nem megfelelő 'Belépés időpontja:' mező, kérem állítsa be a felvett személy belépési dátumát!")
                    Assert.Fail("Iktatási idő nem lett beállítva esetén dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Iktatási idő nem lett beállítva esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }


    }
}