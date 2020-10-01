using Google.Cloud.Firestore;
using System.Collections.Generic;

namespace Stage1_DataMigration
{
    [FirestoreData]
    public class Master
    {
        [FirestoreProperty]
        public int id { get; set; }
         [FirestoreProperty]
        public bool isNew { get; set; }
        [FirestoreProperty]
        public string ean { get; set; }
        [FirestoreProperty]
        public string _2an { get; set; }
        [FirestoreProperty]
        public string gtin { get; set; }
        [FirestoreProperty]
        public string brokenName { get; set; }
        [FirestoreProperty]
        public string updated { get; set; }
        [FirestoreProperty]
        public string productName { get; set; }
        [FirestoreProperty]
        public string productNameFi { get; set; }
        [FirestoreProperty]
        public string productNameSv { get; set; }
        [FirestoreProperty]
        public string productNameEn { get; set; }
        [FirestoreProperty]
        public string descriptionFi { get; set; }
        [FirestoreProperty]
        public string descriptionSv { get; set; }
        [FirestoreProperty]
        public string descriptionEn { get; set; }
        [FirestoreProperty]
        public string packageSize { get; set; }
        [FirestoreProperty]
        public string packageSizeUnit { get; set; }
        [FirestoreProperty]
        public string category1 { get; set; }
        [FirestoreProperty]
        public string category2 { get; set; }
        [FirestoreProperty]
        public string category3 { get; set; }
        [FirestoreProperty]
        public string segmentId { get; set; }
        [FirestoreProperty]
        public string marketingBrand { get; set; }
        [FirestoreProperty]
        public string productIngredientsFi { get; set; }
        [FirestoreProperty]
        public string productIngredientsSv { get; set; }
        [FirestoreProperty]
        public string productIngredientsEn { get; set; }
        [FirestoreProperty]
        public string productIngredientsAdditional { get; set; }
        [FirestoreProperty]
        public string storageInstructions { get; set; }
        [FirestoreProperty]
        public string countryOfManufacture { get; set; }
        [FirestoreProperty]
        public string originCountryCode { get; set; }
        [FirestoreProperty]
        public string productImageUrl { get; set; }
        [FirestoreProperty]
        public string marketerName { get; set; }
        [FirestoreProperty]
        public string marketerAddress { get; set; }
        [FirestoreProperty]
        public string marketerPostalCode { get; set; }
        [FirestoreProperty]
        public string marketerCity { get; set; }
        [FirestoreProperty]
        public string marketerCountry { get; set; }
        [FirestoreProperty]
        public string marketerEmail { get; set; }
        [FirestoreProperty]
        public string marketerWebsite { get; set; }
        [FirestoreProperty]
        public string marketerFacebook { get; set; }
        [FirestoreProperty]
        public string marketerTwitter { get; set; }
        [FirestoreProperty]
        public string producerName { get; set; }
        [FirestoreProperty]
        public string producerWebsite { get; set; }
        [FirestoreProperty]
        public string producerEmail { get; set; }
        [FirestoreProperty]
        public string specialPackageLabels { get; set; }
        [FirestoreProperty]
        public string alcoholFree { get; set; }
        [FirestoreProperty]
        public string noAddedSodiumOrSalt { get; set; }
        [FirestoreProperty]
        public string withNoAddedSugars { get; set; }
        [FirestoreProperty]
        public string withNoBeefGelatin { get; set; }
        [FirestoreProperty]
        public string withNoPorkGelatin { get; set; }
        [FirestoreProperty]
        public string withNoColorAdditives { get; set; }
        [FirestoreProperty]
        public string glutenFree { get; set; }
        [FirestoreProperty]
        public string yeastFree { get; set; }
        [FirestoreProperty]
        public string lactoseFree { get; set; }
        [FirestoreProperty]
        public string additiveFree { get; set; }
        [FirestoreProperty]
        public string increasedAvitamin { get; set; }
        [FirestoreProperty]
        public string increasedB12vitamin { get; set; }
        [FirestoreProperty]
        public string increasedB6vitamin { get; set; }
        [FirestoreProperty]
        public string increasedBiotin { get; set; }
        [FirestoreProperty]
        public string increasedCvitamin { get; set; }
        [FirestoreProperty]
        public string increasedDvitamin { get; set; }
        [FirestoreProperty]
        public string increasedEvitamin { get; set; }
        [FirestoreProperty]
        public string increasedFolicAcid { get; set; }
        [FirestoreProperty]
        public string increasedIodine { get; set; }
        [FirestoreProperty]
        public string increasedCopper { get; set; }
        [FirestoreProperty]
        public string increasedManganese { get; set; }
        [FirestoreProperty]
        public string increasedPantothenicAcid { get; set; }
        [FirestoreProperty]
        public string increasedIron { get; set; }
        [FirestoreProperty]
        public string increasedRiboflavin { get; set; }
        [FirestoreProperty]
        public string increasedSelenium { get; set; }
        [FirestoreProperty]
        public string increasedZinc { get; set; }
        [FirestoreProperty]
        public string increasedThiamine { get; set; }
        [FirestoreProperty]
        public string sourceOfMagnesium { get; set; }
        [FirestoreProperty]
        public string dairyFree { get; set; }
        [FirestoreProperty]
        public string highOmega3FattyAcids { get; set; }
        [FirestoreProperty]
        public string highProtein { get; set; }
        [FirestoreProperty]
        public string highFibre { get; set; }
        [FirestoreProperty]
        public string preservativeFree { get; set; }
        [FirestoreProperty]
        public string sourceOfZinc { get; set; }
        [FirestoreProperty]
        public string containsLicorice { get; set; }
        [FirestoreProperty]
        public string containsPorkGelatin { get; set; }
        [FirestoreProperty]
        public string containsMilk { get; set; }
        [FirestoreProperty]
        public string withNoMilkProtein { get; set; }
        [FirestoreProperty]
        public string containsMilkProtein { get; set; }
        [FirestoreProperty]
        public string sourceOfOmega3FattyAcids { get; set; }
        [FirestoreProperty]
        public string highEvitamin { get; set; }
        [FirestoreProperty]
        public string reducedSugars { get; set; }
        [FirestoreProperty]
        public string sugarsFree { get; set; }
        [FirestoreProperty]
        public string lowLactose { get; set; }
        [FirestoreProperty]
        public string lowSodium { get; set; }
        [FirestoreProperty]
        public string lowFat { get; set; }
        [FirestoreProperty]
        public string reducedSalt { get; set; }
        [FirestoreProperty]
        public string highSalt { get; set; }
        [FirestoreProperty]
        public string calcium { get; set; }
        [FirestoreProperty]
        public string carbohydrates { get; set; }
        [FirestoreProperty]
        public string carbohydratesPolyol { get; set; }
        [FirestoreProperty]
        public string carbohydratesStarch { get; set; }
        [FirestoreProperty]
        public string carbohydratesSugar { get; set; }
        [FirestoreProperty]
        public string energyKC { get; set; }
        [FirestoreProperty]
        public string energyKJ { get; set; }
        [FirestoreProperty]
        public string fat { get; set; }
        [FirestoreProperty]
        public string fatMonoUnsaturated { get; set; }
        [FirestoreProperty]
        public string fatPolyUnsaturated { get; set; }
        [FirestoreProperty]
        public string fatSaturated { get; set; }
        [FirestoreProperty]
        public string folicAcid { get; set; }
        [FirestoreProperty]
        public string iron { get; set; }
        [FirestoreProperty]
        public string lactose { get; set; }
        [FirestoreProperty]
        public string magnesium { get; set; }
        [FirestoreProperty]
        public string niacin { get; set; }
        [FirestoreProperty]
        public string nutritionalFiber { get; set; }
        [FirestoreProperty]
        public string phosphorus { get; set; }
        [FirestoreProperty]
        public string potassium { get; set; }
        [FirestoreProperty]
        public string protein { get; set; }
        [FirestoreProperty]
        public string riboflafine { get; set; }
        [FirestoreProperty]
        public string salt { get; set; }
        [FirestoreProperty]
        public string sodium { get; set; }
        [FirestoreProperty]
        public string thiamine { get; set; }
        [FirestoreProperty]
        public string vitaminA { get; set; }
        [FirestoreProperty]
        public string vitaminB12 { get; set; }
        [FirestoreProperty]
        public string vitaminB6 { get; set; }
        [FirestoreProperty]
        public string vitaminC { get; set; }
        [FirestoreProperty]
        public string vitaminD { get; set; }
        [FirestoreProperty]
        public string vitaminE { get; set; }
        [FirestoreProperty]
        public string zink { get; set; }
        [FirestoreProperty]
        public string nutritionalDetails { get; set; }
        [FirestoreProperty]
        public string pricingUnit { get; set; }
        [FirestoreProperty]
        public string price { get; set; }
        [FirestoreProperty]
        public string vat { get; set; }
        [FirestoreProperty]
        public string updateIteration { get; set; }
        [FirestoreProperty]
        public string foodieStatus { get; set; }
        [FirestoreProperty]
        public string foodiePrice { get; set; }
        [FirestoreProperty]
        public string pointOfSale { get; set; }
        [FirestoreProperty]
        public string shelfLifeinDays { get; set; }
        [FirestoreProperty]
        public string sellByType { get; set; }
        [FirestoreProperty]
        public string autogenerateAt { get; set; }
        [FirestoreProperty]
        public string deleteAfterDays { get; set; }
        [FirestoreProperty]
        public string linkedProducts { get; set; }
        [FirestoreProperty]
        public string sensorTagName { get; set; }
        [FirestoreProperty]
        public string privateLabel { get; set; }
        [FirestoreProperty]
        public string targetEnvironments { get; set; }
        [FirestoreProperty]
        public string dataOrigin { get; set; }
        [FirestoreProperty]
        public string onlineMarkets { get; set; }
    }

}
