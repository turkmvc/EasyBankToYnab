﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace QuestMaster.EasyBankToYnab.DomainTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Import of checking account statements")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ImportOfCheckingAccountStatementsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CheckingAccountImport.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Import of checking account statements", "In order to update my list of transactions\r\nAs a user\r\nI want to import CSV files" +
                    " from XmlEasyBank", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Import of checking account statements")))
            {
                QuestMaster.EasyBankToYnab.DomainTests.ImportOfCheckingAccountStatementsFeature.FeatureSetupMsTest(null);
            }
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetupMsTest(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            new ImportOfCheckingAccountStatementsFeature().FeatureSetup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDownMsTest()
        {
            new ImportOfCheckingAccountStatementsFeature().FeatureTearDown();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Import checking account statements")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Import checking account statements")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Import of checking account statements")]
        public virtual void ImportCheckingAccountStatements()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Import checking account statements", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
  testRunner.Given("I have an account with number \'20010203008\'");
#line hidden
#line 8
  testRunner.When("I import these statements", "20010203008;Abbuchung Onlinebanking                      BG/000002236|14000 06710" +
                    "704145 Margit Obermaier;12.07.2011;11.07.2011;-33,00;EUR\r\n20010203008;easykredit" +
                    "karte MasterCard      000000       MC/000002237;12.07.2011;11.07.2011;-757,70;EU" +
                    "R\r\n20010203008;Apotheke                                     BG/000002235|14200 2" +
                    "0010351775 Dirk Rombauts;09.07.2011;08.07.2011;-23,89;EUR\r\n20010203008;Kindle Bo" +
                    "oks                                 BG/000002234|14200 20010306702 Tatjana Habus" +
                    "ta;09.07.2011;08.07.2011;+21,64;EUR\r\n20010203008;000006773435                   " +
                    "              OG/000002231|32000 00900699090 ORANGE AUSTRIA;06.07.2011;05.07.201" +
                    "1;-24,10;EUR\r\n20010203008;Abbuchung Lastschrift                        OG/000002" +
                    "230|WIENER LINIEN GMBH & CO KG          20151 00696216225;06.07.2011;05.07.2011;" +
                    "-45,80;EUR\r\n20010203008;Hornbach                                     BG/00000223" +
                    "3|14200 20010351775 Dirk Rombauts;06.07.2011;05.07.2011;-9,25;EUR\r\n20010203008;K" +
                    "ienbacher                                   BG/000002232|14200 20010351775 Dirk " +
                    "Rombauts;06.07.2011;05.07.2011;-489,00;EUR\r\n20010203008;Abbuchung Einzugsermächt" +
                    "igung                OG/000002229|BASLER VERSICHERUNGS-AG             32000 0000" +
                    "0062141;05.07.2011;04.07.2011;-50,00;EUR\r\n20010203008;Kindle Books              " +
                    "                   BG/000002228|14200 20010306702 Tatjana Habusta;05.07.2011;04." +
                    "07.2011;+23,26;EUR\r\n20010203008;Abbuchung Einzugsermächtigung                OG/" +
                    "000002227|AMAZON EU SARL                      19100 00040593000;02.07.2011;01.07" +
                    ".2011;-16,31;EUR\r\n20010203008;TRN         20110701RX003134|I7452070             " +
                    "                        VB/000002225|Walter Rombauts                     14000 0" +
                    "0118804139;02.07.2011;01.07.2011;-250,00;EUR\r\n20010203008;TRN         20110701RX" +
                    "003135|I7452063                                     VB/000002226|Walter Rombauts" +
                    "                     14000 00118804139;02.07.2011;01.07.2011;-250,00;EUR", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Booking Date",
                        "XmlAccount",
                        "Description",
                        "Payee",
                        "Value Date",
                        "Amount In",
                        "Amount Out",
                        "Currency",
                        "Is New"});
            table1.AddRow(new string[] {
                        "2011-07-12",
                        "20010203008",
                        "Abbuchung Onlinebanking BG/000002236",
                        "14000 06710704145 Margit Obermaier",
                        "2011-07-11",
                        "0.00",
                        "33.00",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-12",
                        "20010203008",
                        "easykreditkarte MasterCard 000000 MC/000002237",
                        "",
                        "2011-07-11",
                        "0.00",
                        "757.70",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-09",
                        "20010203008",
                        "Apotheke BG/000002235",
                        "14200 20010351775 Dirk Rombauts",
                        "2011-07-08",
                        "0.00",
                        "23.89",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-09",
                        "20010203008",
                        "Kindle Books BG/000002234",
                        "14200 20010306702 Tatjana Habusta",
                        "2011-07-08",
                        "21.64",
                        "0",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-06",
                        "20010203008",
                        "000006773435 OG/000002231",
                        "32000 00900699090 ORANGE AUSTRIA",
                        "2011-07-05",
                        "0.00",
                        "24.10",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-06",
                        "20010203008",
                        "Abbuchung Lastschrift OG/000002230",
                        "WIENER LINIEN GMBH & CO KG 20151 00696216225",
                        "2011-07-05",
                        "0.00",
                        "45.80",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-06",
                        "20010203008",
                        "Hornbach BG/000002233",
                        "14200 20010351775 Dirk Rombauts",
                        "2011-07-05",
                        "0.00",
                        "9.25",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-06",
                        "20010203008",
                        "Kienbacher BG/000002232",
                        "14200 20010351775 Dirk Rombauts",
                        "2011-07-05",
                        "0.00",
                        "489.00",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-05",
                        "20010203008",
                        "Abbuchung Einzugsermächtigung OG/000002229",
                        "BASLER VERSICHERUNGS-AG 32000 00000062141",
                        "2011-07-04",
                        "0.00",
                        "50.00",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-05",
                        "20010203008",
                        "Kindle Books BG/000002228",
                        "14200 20010306702 Tatjana Habusta",
                        "2011-07-04",
                        "23.26",
                        "0",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-02",
                        "20010203008",
                        "Abbuchung Einzugsermächtigung OG/000002227",
                        "AMAZON EU SARL 19100 00040593000",
                        "2011-07-01",
                        "0.00",
                        "16.31",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-02",
                        "20010203008",
                        "TRN 20110701RX003134",
                        "I7452070 VB/000002225 Walter Rombauts 14000 00118804139",
                        "2011-07-01",
                        "0",
                        "250.00",
                        "EUR",
                        "True"});
            table1.AddRow(new string[] {
                        "2011-07-02",
                        "20010203008",
                        "TRN 20110701RX003135",
                        "I7452063 VB/000002226 Walter Rombauts 14000 00118804139",
                        "2011-07-01",
                        "0.00",
                        "250.00",
                        "EUR",
                        "True"});
#line 24
  testRunner.Then("the account with number \'20010203008\' should contain these entries", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
