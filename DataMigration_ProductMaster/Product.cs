using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;

namespace DataMigration_ProductMaster
{
    [FirestoreData]
    public class Product
    {
        [FirestoreProperty] public int PageIndex { get; set; }
        [FirestoreProperty] public int PageSize { get; set; }
        [FirestoreProperty] public int TotalItemCount { get; set; }
        public List<Item> Items = new List<Item>();
    }

    [FirestoreData]
    public class CatalogueItemState
    {
        [FirestoreProperty] public string CatalogueItemStateCode { get; set; }
    }

    [FirestoreData]
    public class ValueItem
    {
        [FirestoreProperty] public string Value { get; set; }
    }

    //[FirestoreData]
    //public class TradeItemUnitDescriptorCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    //[FirestoreData]
    //public class TradeItemTradeChannelCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class InformationProviderOfTradeItem
    {
        [FirestoreProperty] public string Gln { get; set; }
        [FirestoreProperty] public string PartyAddress { get; set; }
        [FirestoreProperty] public string PartyName { get; set; }
    }

    [FirestoreData]
    public class ManufacturerOfTradeItem
    {
        [FirestoreProperty] public string Gln { get; set; }
        [FirestoreProperty] public string PartyName { get; set; }
    }

    [FirestoreData]
    public class GDSNTradeItemClassificationAttribute
    {
        [FirestoreProperty] public string GpcAttributeTypeCode { get; set; }
        [FirestoreProperty] public string GpcAttributeValueCode { get; set; }
        [FirestoreProperty] public string GpcAttributeTypeDefinition { get; set; }
    }

    //[FirestoreData]
    //public class AdditionalTradeItemClassificationSystemCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class AdditionalTradeItemClassificationValue
    {
        [FirestoreProperty] public string AdditionalTradeItemClassificationCodeValue { get; set; }
    }

    [FirestoreData]
    public class AdditionalTradeItemClassification
    {
        [FirestoreProperty] public ValueItem AdditionalTradeItemClassificationSystemCode { get; set; }
        [FirestoreProperty] public List<AdditionalTradeItemClassificationValue> AdditionalTradeItemClassificationValue { get; set; }
    }

    [FirestoreData]
    public class GdsnTradeItemClassification
    {
        [FirestoreProperty] public string GpcSegmentCode { get; set; }
        [FirestoreProperty] public string GpcClassCode { get; set; }
        [FirestoreProperty] public string GpcFamilyCode { get; set; }
        [FirestoreProperty] public string GpcCategoryCode { get; set; }
        [FirestoreProperty] public List<GDSNTradeItemClassificationAttribute> GDSNTradeItemClassificationAttribute { get; set; }
        [FirestoreProperty] public List<AdditionalTradeItemClassification> AdditionalTradeItemClassification { get; set; }
    }

    //[FirestoreData]
    //public class TargetMarketCountryCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class TargetMarket
    {
        [FirestoreProperty] public ValueItem TargetMarketCountryCode { get; set; }
    }

    //[FirestoreData]
    //public class ContactTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    //[FirestoreData]
    //public class CommunicationChannelCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class CommunicationChannel
    {
        [FirestoreProperty] public ValueItem CommunicationChannelCode { get; set; }
        [FirestoreProperty] public string CommunicationValue { get; set; }
    }

    [FirestoreData]
    public class TargetMarketCommunicationChannel
    {
        [FirestoreProperty] public List<CommunicationChannel> CommunicationChannel { get; set; }
    }

    [FirestoreData]
    public class TradeItemContactInformation
    {
        [FirestoreProperty] public ValueItem ContactTypeCode { get; set; }
        [FirestoreProperty] public string ContactAddress { get; set; }
        [FirestoreProperty] public string ContactName { get; set; }
        [FirestoreProperty] public List<TargetMarketCommunicationChannel> TargetMarketCommunicationChannel { get; set; }
    }

    [FirestoreData]
    public class TradeItemSynchronisationDates
    {
        [FirestoreProperty] public DateTimeOffset LastChangeDateTime { get; set; }
        [FirestoreProperty] public DateTimeOffset EffectiveDateTime { get; set; }
        [FirestoreProperty] public DateTimeOffset publicationDateTime { get; set; }
    }

    //[FirestoreData]
    //public class AllergenTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    //[FirestoreData]
    //public class LevelOfContainmentCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class Allergen
    {
        [FirestoreProperty] public ValueItem AllergenTypeCode { get; set; }
        [FirestoreProperty] public ValueItem LevelOfContainmentCode { get; set; }
    }

    [FirestoreData]
    public class AllergenRelatedInformation
    {
        [FirestoreProperty] public string AllergenSpecificationAgency { get; set; }
        [FirestoreProperty] public string AllergenSpecificationName { get; set; }
        [FirestoreProperty] public List<Allergen> Allergen { get; set; }
    }

    [FirestoreData]
    public class AllergenInformationModule
    {
        [FirestoreProperty] public List<AllergenRelatedInformation> AllergenRelatedInformation { get; set; }
    }

    [FirestoreData]
    public class CertificationInformation
    {
        [FirestoreProperty] public string CertificationAgency { get; set; }
        [FirestoreProperty] public string CertificationStandard { get; set; }
    }

    [FirestoreData]
    public class CertificationInformationModule
    {
        [FirestoreProperty] public List<CertificationInformation> CertificationInformation { get; set; }
    }

    [FirestoreData]
    public class ConsumerStorageInstruction
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class ConsumerInstructions
    {
        [FirestoreProperty] public List<ConsumerStorageInstruction> ConsumerStorageInstructions { get; set; }
    }

    [FirestoreData]
    public class ConsumerInstructionsModule
    {
        [FirestoreProperty] public ConsumerInstructions ConsumerInstructions { get; set; }
    }

    [FirestoreData]
    public class DangerousSubstanceProperty
    {
        [FirestoreProperty] public string IsDangerousSubstance { get; set; }
    }

    [FirestoreData]
    public class DangerousSubstanceInformation
    {
        [FirestoreProperty] public List<DangerousSubstanceProperty> DangerousSubstanceProperties { get; set; }
    }

    [FirestoreData]
    public class DangerousSubstanceInformationModule
    {
        [FirestoreProperty] public List<DangerousSubstanceInformation> DangerousSubstanceInformation { get; set; }
    }

    [FirestoreData]
    public class DeliveryPurchasingInformation
    {
        [FirestoreProperty] public DateTimeOffset StartAvailabilityDateTime { get; set; }
    }

    [FirestoreData]
    public class DeliveryPurchasingInformationModule
    {
        [FirestoreProperty] public DeliveryPurchasingInformation DeliveryPurchasingInformation { get; set; }
    }

    //[FirestoreData]
    //public class DutyFeeTaxAgencyCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    //[FirestoreData]
    //public class DutyFeeTaxCategoryCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class DutyFeeTax
    {
        [FirestoreProperty] public ValueItem DutyFeeTaxCategoryCode { get; set; }
    }

    [FirestoreData]
    public class DutyFeeTaxInformation
    {
        [FirestoreProperty] public ValueItem DutyFeeTaxAgencyCode { get; set; }
        [FirestoreProperty] public string DutyFeeTaxTypeCode { get; set; }
        [FirestoreProperty] public string IsTradeItemACombinationItem { get; set; }
        [FirestoreProperty] public List<DutyFeeTax> DutyFeeTax { get; set; }
    }

    [FirestoreData]
    public class DutyFeeTaxInformationModule
    {
        [FirestoreProperty] public List<DutyFeeTaxInformation> DutyFeeTaxInformation { get; set; }
    }

    [FirestoreData]
    public class IngredientStatement
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class FoodAndBeverageIngredientModule
    {
        [FirestoreProperty] public List<IngredientStatement> IngredientStatement { get; set; }
    }

    [FirestoreData]
    public class TradeItemMarketingMessage
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class MarketingInformation
    {
        [FirestoreProperty] public List<TradeItemMarketingMessage> TradeItemMarketingMessage { get; set; }
    }

    [FirestoreData]
    public class MarketingInformationModule
    {
        [FirestoreProperty] public MarketingInformation MarketingInformation { get; set; }
    }

    [FirestoreData]
    public class NutritionalClaim
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    //[FirestoreData]
    //public class NutritionalClaimTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    //[FirestoreData]
    //public class NutritionalClaimNutrientElementCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class NutritionalClaimDetail
    {
        [FirestoreProperty] public ValueItem NutritionalClaimTypeCode { get; set; }
        [FirestoreProperty] public ValueItem NutritionalClaimNutrientElementCode { get; set; }
    }

    //[FirestoreData]
    //public class PreparationStateCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class NutrientBasisQuantity
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public int Value { get; set; }
    }

    //[FirestoreData]
    //public class NutrientTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    //[FirestoreData]
    //public class MeasurementPrecisionCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class QuantityContained
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class NutrientDetail
    {
        [FirestoreProperty] public ValueItem NutrientTypeCode { get; set; }
        [FirestoreProperty] public ValueItem MeasurementPrecisionCode { get; set; }
        [FirestoreProperty] public List<QuantityContained> QuantityContained { get; set; }
    }

    [FirestoreData]
    public class NutrientHeader
    {
        [FirestoreProperty] public ValueItem PreparationStateCode { get; set; }
        [FirestoreProperty] public NutrientBasisQuantity NutrientBasisQuantity { get; set; }
        [FirestoreProperty] public List<NutrientDetail> NutrientDetail { get; set; }
    }

    [FirestoreData]
    public class NutritionalInformationModule
    {
        [FirestoreProperty] public List<NutritionalClaim> NutritionalClaim { get; set; }
        [FirestoreProperty] public List<NutritionalClaimDetail> NutritionalClaimDetail { get; set; }
        [FirestoreProperty] public List<NutrientHeader> NutrientHeader { get; set; }
    }

    //[FirestoreData]
    //public class PackagingTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    //[FirestoreData]
    //public class PackagingMaterialTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class PackagingMaterialCompositionQuantity
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class PackagingMaterial
    {
        [FirestoreProperty] public ValueItem PackagingMaterialTypeCode { get; set; }
        [FirestoreProperty] public string IsPackagingMaterialRecoverable { get; set; }
        [FirestoreProperty] public List<PackagingMaterialCompositionQuantity> PackagingMaterialCompositionQuantity { get; set; }
    }

    [FirestoreData]
    public class Packaging
    {
        [FirestoreProperty] public ValueItem PackagingTypeCode { get; set; }
        [FirestoreProperty] public List<PackagingMaterial> PackagingMaterial { get; set; }
    }

    [FirestoreData]
    public class PackagingInformationModule
    {
        [FirestoreProperty] public List<Packaging> Packaging { get; set; }
    }

    //[FirestoreData]
    //public class PackagingMarkedLabelAccreditationCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    //[FirestoreData]
    //public class TradeItemDateOnPackagingTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class PackagingDate
    {
        [FirestoreProperty] public ValueItem TradeItemDateOnPackagingTypeCode { get; set; }
    }

    [FirestoreData]
    public class PackagingMarking
    {
        [FirestoreProperty] public List<ValueItem> PackagingMarkedLabelAccreditationCode { get; set; }
        [FirestoreProperty] public List<PackagingDate> PackagingDate { get; set; }
    }

    [FirestoreData]
    public class PackagingMarkingModule
    {
        [FirestoreProperty] public PackagingMarking PackagingMarking { get; set; }
    }

    //[FirestoreData]
    //public class CountryCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class CountryOfOrigin
    {
        [FirestoreProperty] public ValueItem CountryCode { get; set; }
    }

    [FirestoreData]
    public class PlaceOfProductActivity
    {
        [FirestoreProperty] public List<CountryOfOrigin> CountryOfOrigin { get; set; }
    }

    [FirestoreData]
    public class PlaceOfItemActivityModule
    {
        [FirestoreProperty] public string ImportClassificationIntrastat { get; set; }
        [FirestoreProperty] public PlaceOfProductActivity PlaceOfProductActivity { get; set; }
    }

    //[FirestoreData]
    //public class FileColourSchemeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class FileResolutionDescription
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class FileSize
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public int Value { get; set; }
    }

    [FirestoreData]
    public class ReferencedFileDetail
    {
        [FirestoreProperty] public ValueItem FileColourSchemeCode { get; set; }
        [FirestoreProperty] public int FilePixelHeight { get; set; }
        [FirestoreProperty] public int FilePixelWidth { get; set; }
        [FirestoreProperty] public List<FileResolutionDescription> FileResolutionDescription { get; set; }
        [FirestoreProperty] public List<FileSize> FileSize { get; set; }
    }

    //[FirestoreData]
    //public class ReferencedFileTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class ReferencedFileHeader
    {
        [FirestoreProperty] public DateTimeOffset QualificationDateTime { get; set; }
        [FirestoreProperty] public string MediaQualificationStatus { get; set; }
        [FirestoreProperty] public string MediaSourceGln { get; set; }
        [FirestoreProperty] public ReferencedFileDetail ReferencedFileDetail { get; set; }
        [FirestoreProperty] public ValueItem ReferencedFileTypeCode { get; set; }
        [FirestoreProperty] public string FileFormatName { get; set; }
        [FirestoreProperty] public string FileName { get; set; }
        [FirestoreProperty] public string UniformResourceIdentifier { get; set; }
        [FirestoreProperty] public string IsPrimaryFile { get; set; }
        [FirestoreProperty] public int Id { get; set; }
        [FirestoreProperty] public string MimeType { get; set; }
        [FirestoreProperty] public int MediaItemId { get; set; }
    }

    [FirestoreData]
    public class ReferencedFileDetailInformationModule
    {
        [FirestoreProperty] public List<ReferencedFileHeader> ReferencedFileHeader { get; set; }
    }

    [FirestoreData]
    public class SafetyDataSheetInformation
    {
        [FirestoreProperty] public string IsRegulatedForTransportation { get; set; }
    }

    [FirestoreData]
    public class SafetyDataSheetModule
    {
        [FirestoreProperty] public List<SafetyDataSheetInformation> SafetyDataSheetInformation { get; set; }
    }

    [FirestoreData]
    public class PriceComparisonMeasurement
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class SalesInformation
    {
        [FirestoreProperty] public List<PriceComparisonMeasurement> PriceComparisonMeasurement { get; set; }
    }

    [FirestoreData]
    public class SalesInformationModule
    {
        [FirestoreProperty] public SalesInformation SalesInformation { get; set; }
    }

    //[FirestoreData]
    //public class DataCarrierTypeCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class DataCarrier
    {
        [FirestoreProperty] public ValueItem DataCarrierTypeCode { get; set; }
    }

    [FirestoreData]
    public class TradeItemDataCarrierAndIdentificationModule
    {
        [FirestoreProperty] public List<DataCarrier> DataCarrier { get; set; }
    }

    [FirestoreData]
    public class DescriptionShort
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class FunctionalName
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class RegulatedProductName
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class TradeItemDescription
    {
        [FirestoreProperty] public string LanguageCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class BrandNameInformation
    {
        [FirestoreProperty] public string BrandName { get; set; }
    }

    [FirestoreData]
    public class TradeItemDescriptionInformation
    {
        [FirestoreProperty] public List<DescriptionShort> DescriptionShort { get; set; }
        [FirestoreProperty] public List<FunctionalName> FunctionalName { get; set; }
        [FirestoreProperty] public List<RegulatedProductName> RegulatedProductName { get; set; }
        [FirestoreProperty] public List<TradeItemDescription> TradeItemDescription { get; set; }
        [FirestoreProperty] public BrandNameInformation BrandNameInformation { get; set; }
    }

    [FirestoreData]
    public class TradeItemDescriptionModule
    {
        [FirestoreProperty] public TradeItemDescriptionInformation TradeItemDescriptionInformation { get; set; }
    }

    //[FirestoreData]
    //public class HandlingInstructionsCodeReference
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class TradeItemHandlingInformation
    {
        [FirestoreProperty] public List<ValueItem> HandlingInstructionsCodeReference { get; set; }
    }

    [FirestoreData]
    public class TradeItemHandlingModule
    {
        [FirestoreProperty] public TradeItemHandlingInformation TradeItemHandlingInformation { get; set; }
    }

    [FirestoreData]
    public class TradeItemLifespan
    {
        [FirestoreProperty] public int MinimumTradeItemLifespanFromTimeOfProduction { get; set; }
    }

    [FirestoreData]
    public class TradeItemLifespanModule
    {
        [FirestoreProperty] public TradeItemLifespan TradeItemLifespan { get; set; }
    }

    [FirestoreData]
    public class Depth
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class Height
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class NetContent
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class Width
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class GrossWeight
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class NetWeight
    {
        [FirestoreProperty] public string MeasurementUnitCode { get; set; }
        [FirestoreProperty] public double Value { get; set; }
    }

    [FirestoreData]
    public class TradeItemWeight
    {
        [FirestoreProperty] public GrossWeight GrossWeight { get; set; }
        [FirestoreProperty] public NetWeight NetWeight { get; set; }
    }

    [FirestoreData]
    public class TradeItemMeasurements
    {
        [FirestoreProperty] public Depth Depth { get; set; }
        [FirestoreProperty] public Height Height { get; set; }
        [FirestoreProperty] public List<NetContent> NetContent { get; set; }
        [FirestoreProperty] public Width Width { get; set; }
        [FirestoreProperty] public TradeItemWeight TradeItemWeight { get; set; }
    }

    [FirestoreData]
    public class TradeItemMeasurementsModule
    {
        [FirestoreProperty] public TradeItemMeasurements TradeItemMeasurements { get; set; }
    }

    [FirestoreData]
    public class MaximumTemperature
    {
        [FirestoreProperty] public string TemperatureMeasurementUnitCode { get; set; }
        [FirestoreProperty] public int Value { get; set; }
    }

    [FirestoreData]
    public class MaximumToleranceTemperature
    {
        [FirestoreProperty] public string TemperatureMeasurementUnitCode { get; set; }
        [FirestoreProperty] public int Value { get; set; }
    }

    [FirestoreData]
    public class MinimumTemperature
    {
        [FirestoreProperty] public string TemperatureMeasurementUnitCode { get; set; }
        [FirestoreProperty] public int Value { get; set; }
    }

    [FirestoreData]
    public class MinimumToleranceTemperature
    {
        [FirestoreProperty] public string TemperatureMeasurementUnitCode { get; set; }
        [FirestoreProperty] public int Value { get; set; }
    }

    //[FirestoreData]
    //public class TemperatureQualifierCode
    //{
    //    [FirestoreProperty] public string Value { get; set; }
    //}

    [FirestoreData]
    public class TradeItemTemperatureInformation
    {
        [FirestoreProperty] public MaximumTemperature MaximumTemperature { get; set; }
        [FirestoreProperty] public MaximumToleranceTemperature MaximumToleranceTemperature { get; set; }
        [FirestoreProperty] public MinimumTemperature MinimumTemperature { get; set; }
        [FirestoreProperty] public MinimumToleranceTemperature MinimumToleranceTemperature { get; set; }
        [FirestoreProperty] public ValueItem TemperatureQualifierCode { get; set; }
    }

    [FirestoreData]
    public class TradeItemTemperatureInformationModule
    {
        [FirestoreProperty] public List<TradeItemTemperatureInformation> TradeItemTemperatureInformation { get; set; }
    }

    [FirestoreData]
    public class VariableTradeItemInformation
    {
        [FirestoreProperty] public bool IsTradeItemAVariableUnit { get; set; }
    }

    [FirestoreData]
    public class VariableTradeItemInformationModule
    {
        [FirestoreProperty] public VariableTradeItemInformation VariableTradeItemInformation { get; set; }
    }

    [FirestoreData]
    public class AdditionalTradeItemIdentification
    {
        [FirestoreProperty] public string AdditionalTradeItemIdentificationTypeCode { get; set; }
        [FirestoreProperty] public string Value { get; set; }
    }

    [FirestoreData]
    public class TradeItem
    {
        [FirestoreProperty] public bool IsBrandBankPublication { get; set; }
        [FirestoreProperty] public List<string> TargetSector { get; set; }
        [FirestoreProperty] public bool IsTradeItemABaseUnit { get; set; }
        [FirestoreProperty] public bool IsTradeItemAConsumerUnit { get; set; }
        [FirestoreProperty] public bool IsTradeItemADespatchUnit { get; set; }
        [FirestoreProperty] public bool IsTradeItemAnInvoiceUnit { get; set; }
        [FirestoreProperty] public bool IsTradeItemAnOrderableUnit { get; set; }
        [FirestoreProperty] public ValueItem TradeItemUnitDescriptorCode { get; set; }
        [FirestoreProperty] public List<ValueItem> TradeItemTradeChannelCode { get; set; }
        [FirestoreProperty] public InformationProviderOfTradeItem InformationProviderOfTradeItem { get; set; }
        [FirestoreProperty] public List<ManufacturerOfTradeItem> ManufacturerOfTradeItem { get; set; }
        [FirestoreProperty] public GdsnTradeItemClassification GdsnTradeItemClassification { get; set; }
        [FirestoreProperty] public TargetMarket TargetMarket { get; set; }
        [FirestoreProperty] public List<TradeItemContactInformation> TradeItemContactInformation { get; set; }
        [FirestoreProperty] public TradeItemSynchronisationDates TradeItemSynchronisationDates { get; set; }
        [FirestoreProperty] public AllergenInformationModule AllergenInformationModule { get; set; }
        [FirestoreProperty] public CertificationInformationModule CertificationInformationModule { get; set; }
        [FirestoreProperty] public ConsumerInstructionsModule ConsumerInstructionsModule { get; set; }
        [FirestoreProperty] public DangerousSubstanceInformationModule DangerousSubstanceInformationModule { get; set; }
        [FirestoreProperty] public DeliveryPurchasingInformationModule DeliveryPurchasingInformationModule { get; set; }
        [FirestoreProperty] public DutyFeeTaxInformationModule DutyFeeTaxInformationModule { get; set; }
        [FirestoreProperty] public FoodAndBeverageIngredientModule FoodAndBeverageIngredientModule { get; set; }
        [FirestoreProperty] public MarketingInformationModule MarketingInformationModule { get; set; }
        [FirestoreProperty] public NutritionalInformationModule NutritionalInformationModule { get; set; }
        [FirestoreProperty] public PackagingInformationModule PackagingInformationModule { get; set; }
        [FirestoreProperty] public PackagingMarkingModule PackagingMarkingModule { get; set; }
        [FirestoreProperty] public PlaceOfItemActivityModule PlaceOfItemActivityModule { get; set; }
        [FirestoreProperty] public ReferencedFileDetailInformationModule ReferencedFileDetailInformationModule { get; set; }
        [FirestoreProperty] public SafetyDataSheetModule SafetyDataSheetModule { get; set; }
        [FirestoreProperty] public SalesInformationModule SalesInformationModule { get; set; }
        [FirestoreProperty] public TradeItemDataCarrierAndIdentificationModule TradeItemDataCarrierAndIdentificationModule { get; set; }
        [FirestoreProperty] public TradeItemDescriptionModule TradeItemDescriptionModule { get; set; }
        [FirestoreProperty] public TradeItemHandlingModule TradeItemHandlingModule { get; set; }
        [FirestoreProperty] public TradeItemLifespanModule TradeItemLifespanModule { get; set; }
        [FirestoreProperty] public TradeItemMeasurementsModule TradeItemMeasurementsModule { get; set; }
        [FirestoreProperty] public TradeItemTemperatureInformationModule TradeItemTemperatureInformationModule { get; set; }
        [FirestoreProperty] public VariableTradeItemInformationModule VariableTradeItemInformationModule { get; set; }
        [FirestoreProperty] public string Gtin { get; set; }
        [FirestoreProperty] public List<AdditionalTradeItemIdentification> AdditionalTradeItemIdentification { get; set; }
    }

    [FirestoreData]
    public class Item
    {
        [FirestoreProperty] public bool IsRestricted { get; set; }
        [FirestoreProperty] public bool CopyLive { get; set; }
        [FirestoreProperty] public CatalogueItemState CatalogueItemState { get; set; }
        [FirestoreProperty] public TradeItem TradeItem { get; set; }
    }


}
