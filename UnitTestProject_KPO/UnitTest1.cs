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

        [TestMethod]
        public void TestFileName()
        {
           var target = loader.getFileName;
            Assert.AreEqual("New_Materials.txt", target);
        }

        [TestMethod]
        public void TestExecuteMethodMaterialName()
        {
            loader = new MaterialNewLoader_laba4("C:\\Users\\Public\\Documents\\учеба\\Учеба\\3 курс\\2 семестр\\КПО\\laby_kpo\\Kpo4381_nmv\\Kpo4381_nmv.Main\\bin\\Debug\\New_Materials.txt");
            loader.Execute();
            var targetMaterialName = loader.getMaterials[0].name;

            Assert.AreEqual("Алюминий", targetMaterialName);
        }

        [TestMethod]
        public void TestMaterialType()
        {
            loader = new MaterialNewLoader_laba4("C:\\Users\\Public\\Documents\\учеба\\Учеба\\3 курс\\2 семестр\\КПО\\laby_kpo\\Kpo4381_nmv\\Kpo4381_nmv.Main\\bin\\Debug\\New_Materials.txt");
            loader.Execute();
            var targetMaterialType = loader.getMaterials[2].materialType;

            Assert.AreEqual('Д', targetMaterialType);
        }
    }
}
