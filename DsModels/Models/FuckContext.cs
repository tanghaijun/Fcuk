using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DsModels.Models.Mapping;

namespace DsModels.Models
{
    public partial class FuckContext : DbContext
    {
        static FuckContext()
        {
            Database.SetInitializer<FuckContext>(null);
        }

        public FuckContext()
            : base("Name=FuckContext")
        {
        }

        public DbSet<DsAskPrice> DsAskPrices { get; set; }
        public DbSet<DsAskPriceFy> DsAskPriceFies { get; set; }
        public DbSet<DsAskPriceOrder> DsAskPriceOrders { get; set; }
        public DbSet<DsAskPricePay> DsAskPricePays { get; set; }
        public DbSet<DsAskPriceSettlement> DsAskPriceSettlements { get; set; }
        public DbSet<DsAskPriceSettlementCertificate> DsAskPriceSettlementCertificates { get; set; }
        public DbSet<DsAskPriceSettlementToOrder> DsAskPriceSettlementToOrders { get; set; }
        public DbSet<DsBuilding> DsBuildings { get; set; }
        public DbSet<DsBuildingFloor> DsBuildingFloors { get; set; }
        public DbSet<DsBuildingGroup> DsBuildingGroups { get; set; }
        public DbSet<DsBuildingGroupHouseType> DsBuildingGroupHouseTypes { get; set; }
        public DbSet<DsBuildingGroupHouseTypePhoto> DsBuildingGroupHouseTypePhotoes { get; set; }
        public DbSet<DsBuildingGroupToConsultant> DsBuildingGroupToConsultants { get; set; }
        public DbSet<DsBuildingHouse> DsBuildingHouses { get; set; }
        public DbSet<DsBuildingHouseNumber> DsBuildingHouseNumbers { get; set; }
        public DbSet<DsBuildingPhoto> DsBuildingPhotoes { get; set; }
        public DbSet<DsBuildingUnit> DsBuildingUnits { get; set; }
        public DbSet<DsCity> DsCities { get; set; }
        public DbSet<DsCostPeriod> DsCostPeriods { get; set; }
        public DbSet<DsCoupon> DsCoupons { get; set; }
        public DbSet<DsCouponFollow> DsCouponFollows { get; set; }
        public DbSet<DsCouponOrder> DsCouponOrders { get; set; }
        public DbSet<DsCouponPay> DsCouponPays { get; set; }
        public DbSet<DsCouponReturn> DsCouponReturns { get; set; }
        public DbSet<DsCouponSettlement> DsCouponSettlements { get; set; }
        public DbSet<DsCouponSettlementCertificate> DsCouponSettlementCertificates { get; set; }
        public DbSet<DsCouponSettlementToOrder> DsCouponSettlementToOrders { get; set; }
        public DbSet<DsEnterprise> DsEnterprises { get; set; }
        public DbSet<DsEnterpriseBankCard> DsEnterpriseBankCards { get; set; }
        public DbSet<DsEnterpriseCertificate> DsEnterpriseCertificates { get; set; }
        public DbSet<DsEnterpriseJoinInApply> DsEnterpriseJoinInApplies { get; set; }
        public DbSet<DsEnterpriseToBuildingGroup> DsEnterpriseToBuildingGroups { get; set; }
        public DbSet<DsFocu> DsFocus { get; set; }
        public DbSet<DsFocusFy> DsFocusFies { get; set; }
        public DbSet<DsFocusGroup> DsFocusGroups { get; set; }
        public DbSet<DsFocusGroupToFy> DsFocusGroupToFies { get; set; }
        public DbSet<DsFocusGroupToQueue> DsFocusGroupToQueues { get; set; }
        public DbSet<DsFocusGroupToSimulateFy> DsFocusGroupToSimulateFies { get; set; }
        public DbSet<DsFocusQueue> DsFocusQueues { get; set; }
        public DbSet<DsFocusSimulateFy> DsFocusSimulateFies { get; set; }
        public DbSet<DsFy> DsFies { get; set; }
        public DbSet<DsFyFollow> DsFyFollows { get; set; }
        public DbSet<DsFyOrder> DsFyOrders { get; set; }
        public DbSet<DsFyPay> DsFyPays { get; set; }
        public DbSet<DsFyReturn> DsFyReturns { get; set; }
        public DbSet<DsFySettlement> DsFySettlements { get; set; }
        public DbSet<DsFySettlementCertificate> DsFySettlementCertificates { get; set; }
        public DbSet<DsFySettlementToOrder> DsFySettlementToOrders { get; set; }
        public DbSet<DsLog> DsLogs { get; set; }
        public DbSet<DsMessage> DsMessages { get; set; }
        public DbSet<DsSecondKill> DsSecondKills { get; set; }
        public DbSet<DsSecondKillFy> DsSecondKillFies { get; set; }
        public DbSet<DsSequence> DsSequences { get; set; }
        public DbSet<DsUser> DsUsers { get; set; }
        public DbSet<DsUserCertificate> DsUserCertificates { get; set; }
        public DbSet<rsync_data> rsync_data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DsAskPriceMap());
            modelBuilder.Configurations.Add(new DsAskPriceFyMap());
            modelBuilder.Configurations.Add(new DsAskPriceOrderMap());
            modelBuilder.Configurations.Add(new DsAskPricePayMap());
            modelBuilder.Configurations.Add(new DsAskPriceSettlementMap());
            modelBuilder.Configurations.Add(new DsAskPriceSettlementCertificateMap());
            modelBuilder.Configurations.Add(new DsAskPriceSettlementToOrderMap());
            modelBuilder.Configurations.Add(new DsBuildingMap());
            modelBuilder.Configurations.Add(new DsBuildingFloorMap());
            modelBuilder.Configurations.Add(new DsBuildingGroupMap());
            modelBuilder.Configurations.Add(new DsBuildingGroupHouseTypeMap());
            modelBuilder.Configurations.Add(new DsBuildingGroupHouseTypePhotoMap());
            modelBuilder.Configurations.Add(new DsBuildingGroupToConsultantMap());
            modelBuilder.Configurations.Add(new DsBuildingHouseMap());
            modelBuilder.Configurations.Add(new DsBuildingHouseNumberMap());
            modelBuilder.Configurations.Add(new DsBuildingPhotoMap());
            modelBuilder.Configurations.Add(new DsBuildingUnitMap());
            modelBuilder.Configurations.Add(new DsCityMap());
            modelBuilder.Configurations.Add(new DsCostPeriodMap());
            modelBuilder.Configurations.Add(new DsCouponMap());
            modelBuilder.Configurations.Add(new DsCouponFollowMap());
            modelBuilder.Configurations.Add(new DsCouponOrderMap());
            modelBuilder.Configurations.Add(new DsCouponPayMap());
            modelBuilder.Configurations.Add(new DsCouponReturnMap());
            modelBuilder.Configurations.Add(new DsCouponSettlementMap());
            modelBuilder.Configurations.Add(new DsCouponSettlementCertificateMap());
            modelBuilder.Configurations.Add(new DsCouponSettlementToOrderMap());
            modelBuilder.Configurations.Add(new DsEnterpriseMap());
            modelBuilder.Configurations.Add(new DsEnterpriseBankCardMap());
            modelBuilder.Configurations.Add(new DsEnterpriseCertificateMap());
            modelBuilder.Configurations.Add(new DsEnterpriseJoinInApplyMap());
            modelBuilder.Configurations.Add(new DsEnterpriseToBuildingGroupMap());
            modelBuilder.Configurations.Add(new DsFocuMap());
            modelBuilder.Configurations.Add(new DsFocusFyMap());
            modelBuilder.Configurations.Add(new DsFocusGroupMap());
            modelBuilder.Configurations.Add(new DsFocusGroupToFyMap());
            modelBuilder.Configurations.Add(new DsFocusGroupToQueueMap());
            modelBuilder.Configurations.Add(new DsFocusGroupToSimulateFyMap());
            modelBuilder.Configurations.Add(new DsFocusQueueMap());
            modelBuilder.Configurations.Add(new DsFocusSimulateFyMap());
            modelBuilder.Configurations.Add(new DsFyMap());
            modelBuilder.Configurations.Add(new DsFyFollowMap());
            modelBuilder.Configurations.Add(new DsFyOrderMap());
            modelBuilder.Configurations.Add(new DsFyPayMap());
            modelBuilder.Configurations.Add(new DsFyReturnMap());
            modelBuilder.Configurations.Add(new DsFySettlementMap());
            modelBuilder.Configurations.Add(new DsFySettlementCertificateMap());
            modelBuilder.Configurations.Add(new DsFySettlementToOrderMap());
            modelBuilder.Configurations.Add(new DsLogMap());
            modelBuilder.Configurations.Add(new DsMessageMap());
            modelBuilder.Configurations.Add(new DsSecondKillMap());
            modelBuilder.Configurations.Add(new DsSecondKillFyMap());
            modelBuilder.Configurations.Add(new DsSequenceMap());
            modelBuilder.Configurations.Add(new DsUserMap());
            modelBuilder.Configurations.Add(new DsUserCertificateMap());
            modelBuilder.Configurations.Add(new rsync_dataMap());
        }
    }
}
