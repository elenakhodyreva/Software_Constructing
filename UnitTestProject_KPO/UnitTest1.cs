using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kpo4381.nmv.Lib;


namespace UnitTestProject_KPO
{
    [TestClass]
    public class UnitTest1
    {
        public MaterialNewLoader_laba4 loader;

        public UnitTest1()
        {
            loader = new MaterialNewLoader_laba4("New_Materials.txt");

        }

        //тест 1
        [TestMethod]
        public void TestFileName()
        {
           var target = loader.getFileName;
            Assert.AreEqual("New_Materials.txt", target);
        }


        //тест 2
        [TestMethod]
        public void TestExecuteMethodMaterialName()
        {
            loader = new MaterialNewLoader_laba4("C:\\Users\\Public\\Documents\\учеба\\Учеба\\3 курс\\2 семестр\\КПО\\laby_kpo\\Kpo4381_nmv\\Kpo4381_nmv.Main\\bin\\Debug\\New_Materials.txt");
            loader.Execute();
            var targetMaterialName = loader.getMaterials[0].name;

            Assert.AreEqual("Алюминий", targetMaterialName);
        }

        //тест 3
        [TestMethod]
        public void TestMaterialType()
        {
            loader = new MaterialNewLoader_laba4("C:\\Users\\Public\\Documents\\учеба\\Учеба\\3 курс\\2 семестр\\КПО\\laby_kpo\\Kpo4381_nmv\\Kpo4381_nmv.Main\\bin\\Debug\\New_Materials.txt");
            loader.Execute();
            var targetMaterialType = loader.getMaterials[2].materialType;

            Assert.AreEqual('Д', targetMaterialType);
        }

        //тест 4
        [TestMethod]
        public void TestMaterialHumidity()
        {
            loader = new MaterialNewLoader_laba4("C:\\Users\\Public\\Documents\\учеба\\Учеба\\3 курс\\2 семестр\\КПО\\laby_kpo\\Kpo4381_nmv\\Kpo4381_nmv.Main\\bin\\Debug\\New_Materials.txt");
            loader.Execute();
            var targetMaterialHumidity = loader.getMaterials[1].humidity;

            Assert.AreEqual(100, targetMaterialHumidity);
        }

        //тест 5
        [TestMethod]
        public void TestMaterialCoefficient()
        {
            loader = new MaterialNewLoader_laba4("C:\\Users\\Public\\Documents\\учеба\\Учеба\\3 курс\\2 семестр\\КПО\\laby_kpo\\Kpo4381_nmv\\Kpo4381_nmv.Main\\bin\\Debug\\New_Materials.txt");
            loader.Execute();
            var targetMaterialCoefficient = loader.getMaterials[0].coefficient;

            Assert.AreEqual(209.3, targetMaterialCoefficient);
        }
    }
}
