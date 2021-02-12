﻿using System;
using DataRepository.StoredProcedures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class ELD_PRODUCTION_31Context : DbContext
    {
        public ELD_PRODUCTION_31Context()
        {
        }

        public ELD_PRODUCTION_31Context(DbContextOptions<ELD_PRODUCTION_31Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AcctMaster> AcctMaster { get; set; }
        public virtual DbSet<AcctTrans> AcctTrans { get; set; }
        public virtual DbSet<AdditionalEntity> AdditionalEntity { get; set; }
        public virtual DbSet<AdditionalEntityOwner> AdditionalEntityOwner { get; set; }
        public virtual DbSet<ArTrans> ArTrans { get; set; }
        public virtual DbSet<AutoBlankFillInRules> AutoBlankFillInRules { get; set; }
        public virtual DbSet<BrokerContact> BrokerContact { get; set; }
        public virtual DbSet<BrokerLicense> BrokerLicense { get; set; }
        public virtual DbSet<BrokerMaster> BrokerMaster { get; set; }
        public virtual DbSet<ClmMaster> ClmMaster { get; set; }
        public virtual DbSet<CorpOwner> CorpOwner { get; set; }
        public virtual DbSet<EldDepartment> EldDepartment { get; set; }
        public virtual DbSet<EldRefGroup> EldRefGroup { get; set; }
        public virtual DbSet<EldUsers> EldUsers { get; set; }
        public virtual DbSet<InsuredInfo> InsuredInfo { get; set; }
        public virtual DbSet<LkpSubmissionStatus> LkpSubmissionStatus { get; set; }
        public virtual DbSet<SsEldUserRole> SsEldUserRole { get; set; }
        public virtual DbSet<SsPermission> SsPermission { get; set; }
        public virtual DbSet<SsRole> SsRole { get; set; }
        public virtual DbSet<SsRolePermission> SsRolePermission { get; set; }
        public virtual DbSet<UndFormBlanks> UndFormBlanks { get; set; }
        public virtual DbSet<UndFormTrans> UndFormTrans { get; set; }
        public virtual DbSet<UndLkpCoverageType> UndLkpCoverageType { get; set; }
        public virtual DbSet<WebQuoteUsers> WebQuoteUsers { get; set; }

        public virtual DbSet<UndFormVersion> UndFormVersion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ELDSQL02t;Database=ELD_PRODUCTION_NYS;Trusted_Connection=True;");
            }
        }

        public virtual DbSet<GetEndorsementByFeatureName> GetEndorsementByFeatureName { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UndFormVersion>(entity =>
            {
                entity.HasKey(e => e.FormVersionId);

                entity.ToTable("undFORM_VERSION");

                entity.HasIndex(e => e.FormMasterId)
                    .HasName("IX_FORM_MASTER_ID");

                entity.Property(e => e.FormVersionId)
                    .HasColumnName("FORM_VERSION_ID")
                    .HasComment("Unique Form ID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.BinderSort)
                    .HasColumnName("BINDER_SORT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlankCount).HasColumnName("BLANK_COUNT");

                entity.Property(e => e.CreatedById)
                    .HasColumnName("CREATED_BY_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormApprovedDate)
                    .HasColumnName("FORM_APPROVED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FormApprovedId)
                    .HasColumnName("FORM_APPROVED_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormDesc)
                    .HasColumnName("FORM_DESC")
                    .HasColumnType("text");

                entity.Property(e => e.FormDescChangeAllowed).HasColumnName("FORM_DESC_CHANGE_ALLOWED");

                entity.Property(e => e.FormDisplay)
                    .HasColumnName("FORM_DISPLAY")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FormEffectiveDate)
                    .HasColumnName("FORM_EFFECTIVE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FormInternalName)
                    .HasColumnName("FORM_INTERNAL_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FormMasterId)
                    .HasColumnName("FORM_MASTER_ID")
                    .HasComment("FK to FORM_MASTER");

                entity.Property(e => e.FormName)
                    .HasColumnName("FORM_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FormVersionNo)
                    .HasColumnName("FORM_VERSION_NO")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("Form Version Suffix");

                entity.Property(e => e.FormVersionSuf)
                    .HasColumnName("FORM_VERSION_SUF")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasComment("Full Form version key");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PageCount).HasColumnName("PAGE_COUNT");

                entity.Property(e => e.QuoteSort)
                    .HasColumnName("QUOTE_SORT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReferenceNo)
                    .HasColumnName("REFERENCE_NO")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasComment("Form Referrence Suffix");

                entity.Property(e => e.RevisionDate)
                    .HasColumnName("REVISION_DATE")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .HasColumnName("ROW_VERSION")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SignoffRequired).HasColumnName("SIGNOFF_REQUIRED");
            });

            modelBuilder.Entity<AcctMaster>(entity =>
            {
                entity.HasKey(e => e.AcctId);

                entity.ToTable("ACCT_MASTER");

                entity.HasIndex(e => e.PolNo)
                    .HasName("idxPOLNO");

                entity.HasIndex(e => new { e.AppNo, e.AppReceivedDate })
                    .HasName("idx_ano_adate_acct_master")
                    .IsUnique();

                entity.HasIndex(e => new { e.AcctId, e.PolNo, e.PolEffectiveDate, e.AppNo, e.AppReceivedDate, e.Location, e.MailId })
                    .HasName("idxACCT_MASTER_MAILID");

                entity.Property(e => e.AcctId)
                    .HasColumnName("ACCT_ID")
                    .HasComment("ID of Account Master Record ")
                    .ValueGeneratedNever();

                entity.Property(e => e.Acbr).HasColumnName("ACBR");

                entity.Property(e => e.AcctCycle)
                    .HasColumnName("ACCT_CYCLE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Account Cycle  (claim workstation)");

                entity.Property(e => e.AcctNo)
                    .HasColumnName("ACCT_NO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("Account No (claim workstation)");

                entity.Property(e => e.AnnualizedPremium)
                    .HasColumnName("ANNUALIZED_PREMIUM")
                    .HasComment("RATING");

                entity.Property(e => e.AppAssignDate)
                    .HasColumnName("APP_ASSIGN_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Application Assigned Date");

                entity.Property(e => e.AppForm)
                    .HasColumnName("APP_FORM")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AppNo)
                    .HasColumnName("APP_NO")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasComment("Application Number");

                entity.Property(e => e.AppReceivedDate)
                    .HasColumnName("APP_RECEIVED_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("The date application was received");

                entity.Property(e => e.AutHist)
                    .HasColumnName("AUT_HIST")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinderExpDate)
                    .HasColumnName("BINDER_EXP_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BnkrDate)
                    .HasColumnName("BNKR_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Cleared).HasColumnName("CLEARED");

                entity.Property(e => e.CompanyPaper)
                    .IsRequired()
                    .HasColumnName("COMPANY_PAPER")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("COMPANY QUOTED UNDER (G.A. OR AESIC)");

                entity.Property(e => e.CompanyRank)
                    .HasColumnName("COMPANY_RANK")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Company Rank");

                entity.Property(e => e.CurrCvgExpDate)
                    .HasColumnName("CURR_CVG_EXP_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExecutiveDirector)
                    .HasColumnName("EXECUTIVE_DIRECTOR")
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiringYrmo)
                    .HasColumnName("EXPIRING_YRMO")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("YearMonth of Expiration");

                entity.Property(e => e.FwStat)
                    .HasColumnName("FW_STAT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InFrom)
                    .HasColumnName("IN_FROM")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Where records come from");

                entity.Property(e => e.IndicationDate)
                    .HasColumnName("INDICATION_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Indication Date");

                entity.Property(e => e.InitialSubmissionDate)
                    .HasColumnName("INITIAL_SUBMISSION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsurAgreement)
                    .HasColumnName("INSUR_AGREEMENT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredRanksId).HasColumnName("INSURED_RANKS_ID");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("The date the record was changed last time");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("UserId that changed the record last time");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MailId)
                    .HasColumnName("MAIL_ID")
                    .HasComment("Key that relates ACCT_MASTER to mail table");

                entity.Property(e => e.MaxLimit).HasColumnName("MAX_LIMIT");

                entity.Property(e => e.MaxTerm).HasColumnName("MAX_TERM");

                entity.Property(e => e.PfcCodeId)
                    .HasColumnName("PFC_CODE_ID")
                    .HasComment("Key that relates ACCT_MASTER to PFC codes");

                entity.Property(e => e.PolEffectiveDate)
                    .HasColumnName("POL_EFFECTIVE_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("POLICY EFFECTIVE DATE");

                entity.Property(e => e.PolForm)
                    .HasColumnName("POL_FORM")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasComment("Policy From No");

                entity.Property(e => e.PolFormId).HasColumnName("POL_FORM_ID");

                entity.Property(e => e.PolNo)
                    .HasColumnName("POL_NO")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasComment("POLICY NUMBER");

                entity.Property(e => e.PolNoteByClm)
                    .HasColumnName("POL_NOTE_by_CLM")
                    .HasComment("Notes fields for claims");

                entity.Property(e => e.PplDate)
                    .HasColumnName("PPL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PpldateDescription)
                    .HasColumnName("PPLDateDescription")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PremiumFinanceCompany)
                    .HasColumnName("PREMIUM_FINANCE_COMPANY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Premium Finance Company");

                entity.Property(e => e.PremiumOverRide).HasColumnName("PREMIUM_OVER_RIDE");

                entity.Property(e => e.Product)
                    .HasColumnName("PRODUCT")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Product");

                entity.Property(e => e.QuoteDate)
                    .HasColumnName("QUOTE_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Quote Date");

                entity.Property(e => e.QuoteExpDate)
                    .HasColumnName("QUOTE_EXP_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.QuoteNeedbyDate)
                    .HasColumnName("QUOTE_NEEDBY_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Quote needed by Date");

                entity.Property(e => e.RenewedStatus)
                    .IsRequired()
                    .HasColumnName("RENEWED_STATUS")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("POLICY STATUS");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasColumnName("ROW_VERSION")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SenderId)
                    .HasColumnName("SENDER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Transfer).HasColumnName("TRANSFER");

                entity.Property(e => e.TrnMethod)
                    .HasColumnName("TRN_METHOD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnderwritingManagerId)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcctTrans>(entity =>
            {
                entity.ToTable("ACCT_TRANS");

                entity.HasIndex(e => e.AcctId)
                    .HasName("idxACCT_TRANS_ACCT_ID");

                entity.HasIndex(e => e.BrokerId)
                    .HasName("IX_BROKER_ID");

                entity.HasIndex(e => e.InsuredInfoId)
                    .HasName("IX_INSURED_INFO_ID");

                entity.HasIndex(e => e.PolEffectiveDate)
                    .HasName("idx_ACCT_TRANS_PEDATE");

                entity.HasIndex(e => e.PolNo)
                    .HasName("idxACCT_TRANS_POL_NO");

                entity.HasIndex(e => new { e.AcctId, e.PolLimit, e.AcctStage })
                    .HasName("idx_ACCT_STAGE");

                entity.Property(e => e.AcctTransId)
                    .HasColumnName("ACCT_TRANS_ID")
                    .HasComment("Unique key for ACCT_TRANS table")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcctCycle)
                    .HasColumnName("ACCT_CYCLE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Account Cycle (claims workstation)");

                entity.Property(e => e.AcctId)
                    .HasColumnName("ACCT_ID")
                    .HasComment("Key that relates ACCT_TRANS to ACCT_MASTER");

                entity.Property(e => e.AcctNo)
                    .HasColumnName("ACCT_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Account number(claims workstation)");

                entity.Property(e => e.AcctStage)
                    .HasColumnName("ACCT_STAGE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Account Stage");

                entity.Property(e => e.AcctSubStage)
                    .IsRequired()
                    .HasColumnName("ACCT_SUB_STAGE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Key that relates ACCT_TRANS to CODES table");

                entity.Property(e => e.AcctTransNotes)
                    .HasColumnName("ACCT_TRANS_NOTES")
                    .HasComment("Notes for ACCT_TRANS table");

                entity.Property(e => e.AppNo)
                    .HasColumnName("APP_NO")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasComment("Application No");

                entity.Property(e => e.AppReceivedDate)
                    .HasColumnName("APP_RECEIVED_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Date application was received");

                entity.Property(e => e.Billingaccountnumber)
                    .HasColumnName("BILLINGACCOUNTNUMBER")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Billingtypeid).HasColumnName("BILLINGTYPEID");

                entity.Property(e => e.BrokerCommisPct)
                    .HasColumnName("BROKER_COMMIS_PCT")
                    .HasComment("Broker commission percentage");

                entity.Property(e => e.BrokerContactId)
                    .HasColumnName("BROKER_CONTACT_ID")
                    .HasComment("Key that relates ACCT_TRANS to BROKER_CONTACT table");

                entity.Property(e => e.BrokerId)
                    .HasColumnName("BROKER_ID")
                    .HasComment("Key that relates ACCT_TRANS to BROKER_MASTER");

                entity.Property(e => e.BrokerProgram)
                    .IsRequired()
                    .HasColumnName("BROKER_PROGRAM")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Broker Program");

                entity.Property(e => e.CboLimit)
                    .HasColumnName("CBO_LIMIT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ClmNotes)
                    .HasColumnName("CLM_NOTES")
                    .HasComment("Notes for claims");

                entity.Property(e => e.Currency)
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasComment("Currency ");

                entity.Property(e => e.CurrencyRateUsed).HasColumnType("decimal(12, 6)");

                entity.Property(e => e.GeneralProduct)
                    .IsRequired()
                    .HasColumnName("GENERAL_PRODUCT")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Key that relates ACCT_TRANS to CODES table ");

                entity.Property(e => e.InFrom)
                    .HasColumnName("IN_FROM")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Where record comes from ");

                entity.Property(e => e.IndustryCode)
                    .IsRequired()
                    .HasColumnName("INDUSTRY_CODE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Key that relates ACCT_TRANS to CODES table");

                entity.Property(e => e.InsuredInfoId)
                    .HasColumnName("INSURED_INFO_ID")
                    .HasComment("Key that relates ACCT_TRANS to INSURED_INFO");

                entity.Property(e => e.IssuedDate)
                    .HasColumnName("ISSUED_DATE")
                    .HasColumnType("datetime")
                    .HasComment("Issued Date");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("The date the record was changed last time");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasComment("UserId that changed the record last time");

                entity.Property(e => e.MasterSheetId).HasColumnName("MASTER_SHEET_ID");

                entity.Property(e => e.NaicsIndustryCode)
                    .HasColumnName("NAICS_INDUSTRY_CODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentplanid).HasColumnName("PAYMENTPLANID");

                entity.Property(e => e.PolEffectiveDate)
                    .HasColumnName("POL_EFFECTIVE_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Policy Effective Date");

                entity.Property(e => e.PolExcessLimit)
                    .HasColumnName("POL_EXCESS_LIMIT")
                    .HasComment("Policy Access Limit");

                entity.Property(e => e.PolExpirationDate)
                    .HasColumnName("POL_EXPIRATION_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Policy Expiration Date");

                entity.Property(e => e.PolLimit)
                    .HasColumnName("POL_LIMIT")
                    .HasComment("Limit on a policy");

                entity.Property(e => e.PolNo)
                    .HasColumnName("POL_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Policy Number");

                entity.Property(e => e.PolRetention)
                    .HasColumnName("POL_RETENTION")
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasComment("Policy Retention");

                entity.Property(e => e.Ptranid)
                    .HasColumnName("PTRANID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("temporary will be removed");

                entity.Property(e => e.Ptrans)
                    .HasColumnName("PTRANS")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("temporary will be removed");

                entity.Property(e => e.RetSetId).HasColumnName("RET_SET_ID");

                entity.Property(e => e.RmCycle)
                    .HasColumnName("RM_CYCLE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("temporary wil be removed");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasColumnName("ROW_VERSION")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TaxLocator)
                    .HasColumnName("TAX_LOCATOR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransEffectiveDate)
                    .HasColumnName("TRANS_EFFECTIVE_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Effective date of the transaction");

                entity.Property(e => e.UnderwriterId)
                    .IsRequired()
                    .HasColumnName("UNDERWRITER_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Key that relates ACCT_TRANS to CODES table");

                entity.HasOne(d => d.Acct)
                    .WithMany(p => p.AcctTrans)
                    .HasForeignKey(d => d.AcctId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCT_TRANS_ACCT_MASTER");

                entity.HasOne(d => d.Broker)
                    .WithMany(p => p.AcctTrans)
                    .HasForeignKey(d => d.BrokerId)
                    .HasConstraintName("FK_ACCT_TRANS_BROKER_MASTER");

                entity.HasOne(d => d.InsuredInfo)
                    .WithMany(p => p.AcctTrans)
                    .HasForeignKey(d => d.InsuredInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCT_TRANS_INSURED_INFO");
            });

            modelBuilder.Entity<AdditionalEntity>(entity =>
            {
                entity.HasKey(e => e.EntityId);

                entity.Property(e => e.Dbaname)
                    .HasColumnName("DBAName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LegalName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdditionalEntityOwner>(entity =>
            {
                entity.HasKey(e => e.EntityOwnerId)
                    .HasName("PK_AdditionalEntityOwnerId");

                entity.Property(e => e.LastChangedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerPercent).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.FkEntity)
                    .WithMany(p => p.AdditionalEntityOwner)
                    .HasForeignKey(d => d.FkEntityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Fk_AdditionalEntityId");
            });

            modelBuilder.Entity<ArTrans>(entity =>
            {
                entity.HasKey(e => e.ArId)
                    .HasName("PK_AR_TRANS_1");

                entity.ToTable("AR_TRANS");

                entity.HasIndex(e => e.AcctId)
                    .HasName("IX_ACCT_ID");

                entity.HasIndex(e => e.AcctTransId)
                    .HasName("IX_ACCT_TRANS_ID");

                entity.HasIndex(e => e.InvoiceNo)
                    .HasName("idxAR_TRANS_INVOICE_NO");

                entity.HasIndex(e => new { e.AcctId, e.ArTransYrmo, e.ArTransType, e.GrossPremium, e.ProfitCtrId })
                    .HasName("idx_PROF_CTR_ID");

                entity.HasIndex(e => new { e.ArId, e.AcctId, e.ArTransYrmo, e.ProfitCtrId, e.ArTransType })
                    .HasName("idx_AR_TRANS_TYPE");

                entity.Property(e => e.ArId)
                    .HasColumnName("AR_ID")
                    .HasComment("unique id for ar_trans table")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcctId)
                    .HasColumnName("ACCT_ID")
                    .HasComment("Key that relates Ar_trans to Acct_master");

                entity.Property(e => e.AcctTransId)
                    .HasColumnName("ACCT_TRANS_ID")
                    .HasComment("Key that relates Ar_trans to Acct_Trans");

                entity.Property(e => e.AppNo)
                    .HasColumnName("APP_NO")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasComment("Application Name");

                entity.Property(e => e.AppReceivedDate)
                    .HasColumnName("APP_RECEIVED_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("The date application was received");

                entity.Property(e => e.ArTransDate)
                    .HasColumnName("AR_TRANS_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("The date of the transaction");

                entity.Property(e => e.ArTransType)
                    .IsRequired()
                    .HasColumnName("AR_TRANS_TYPE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Type of transaction");

                entity.Property(e => e.ArTransYrmo)
                    .HasColumnName("AR_TRANS_YRMO")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("YrMo of the record");

                entity.Property(e => e.BillBrokerId)
                    .HasColumnName("BILL_BROKER_ID")
                    .HasComment("Key that relates Ar_trans to Broker_master");

                entity.Property(e => e.CheckDisbursementDate)
                    .HasColumnName("CHECK_DISBURSEMENT_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Disbursement Check Date");

                entity.Property(e => e.CheckId)
                    .HasColumnName("CHECK_ID")
                    .HasComment("Disbursement Check ID");

                entity.Property(e => e.CheckNo)
                    .HasColumnName("CHECK_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Disbursement Check No");

                entity.Property(e => e.DueDate)
                    .HasColumnName("DUE_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("Due Date");

                entity.Property(e => e.GrossPremium)
                    .HasColumnName("GROSS_PREMIUM")
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Gross Premium");

                entity.Property(e => e.InFrom)
                    .HasColumnName("IN_FROM")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("Where records come from");

                entity.Property(e => e.InstallmentNo)
                    .HasColumnName("INSTALLMENT_NO")
                    .HasComment("Installment No");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Invoice No");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("The date the record was changed last time");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasComment("UserId that changed the record last time");

                entity.Property(e => e.NetPremium)
                    .HasColumnName("NET_PREMIUM")
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Net Premium");

                entity.Property(e => e.ProfitCtrId).HasColumnName("PROFIT_CTR_ID");

                entity.Property(e => e.ReinsPremium)
                    .HasColumnName("REINS_PREMIUM")
                    .HasColumnType("numeric(12, 2)")
                    .HasComment("Reinsurance Premium");

                entity.Property(e => e.SelectRec).HasColumnName("SELECT_REC");

                entity.HasOne(d => d.Acct)
                    .WithMany(p => p.ArTrans)
                    .HasForeignKey(d => d.AcctId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_TRANS_ACCT_MASTER");

                entity.HasOne(d => d.AcctTrans)
                    .WithMany(p => p.ArTrans)
                    .HasForeignKey(d => d.AcctTransId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AR_TRANS_ACCT_TRANS");

                entity.HasOne(d => d.BillBroker)
                    .WithMany(p => p.ArTrans)
                    .HasForeignKey(d => d.BillBrokerId)
                    .HasConstraintName("FK_AR_TRANS_BROKER_MASTER1");
            });

            modelBuilder.Entity<AutoBlankFillInRules>(entity =>
            {
                entity.HasKey(e => e.BlankRuleId)
                    .HasName("PK_BlankRuleId");

                entity.Property(e => e.BlankValue).IsUnicode(false);

                entity.Property(e => e.BusinessType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LastChangedID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stage)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValueType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokerContact>(entity =>
            {
                entity.ToTable("BROKER_CONTACT");

                entity.HasIndex(e => e.BrokerId)
                    .HasName("IX_BROKER_ID");

                entity.HasIndex(e => new { e.BrokerId, e.BrokerContactNo })
                    .HasName("idx_BR_ID_BCODE_BCONTACT");

                entity.Property(e => e.BrokerContactId)
                    .HasColumnName("BROKER_CONTACT_ID")
                    .HasComment("unique id for broker_contact table")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bremoved).HasColumnName("BREMOVED");

                entity.Property(e => e.BrokerContactNo)
                    .HasColumnName("BROKER_CONTACT_NO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("contact number within broker");

                entity.Property(e => e.BrokerContactType)
                    .HasColumnName("BROKER_CONTACT_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("broker contact type");

                entity.Property(e => e.BrokerEmail)
                    .HasColumnName("BROKER_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("broker email");

                entity.Property(e => e.BrokerFax)
                    .HasColumnName("BROKER_FAX")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("broker fax");

                entity.Property(e => e.BrokerFirstName)
                    .HasColumnName("BROKER_FIRST_NAME")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasComment("broker contact first name");

                entity.Property(e => e.BrokerId)
                    .HasColumnName("BROKER_ID")
                    .HasComment("links broker_contact to broker_master");

                entity.Property(e => e.BrokerLastName)
                    .HasColumnName("BROKER_LAST_NAME")
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasComment("broker contact last name");

                entity.Property(e => e.BrokerNo)
                    .HasColumnName("BROKER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("broker number");

                entity.Property(e => e.BrokerTel)
                    .HasColumnName("BROKER_TEL")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("broker telephone");

                entity.Property(e => e.BrokerTitle)
                    .HasColumnName("BROKER_TITLE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("broker title");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SalesForceLinkId)
                    .HasColumnName("SalesForceLinkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unsubscribe).HasColumnName("UNSUBSCRIBE");

                entity.HasOne(d => d.Broker)
                    .WithMany(p => p.BrokerContact)
                    .HasForeignKey(d => d.BrokerId)
                    .HasConstraintName("FK_BROKER_CONTACT_BROKER_MASTER");
            });

            modelBuilder.Entity<BrokerLicense>(entity =>
            {
                entity.HasKey(e => e.LicenseId);

                entity.ToTable("BROKER_LICENSE");

                entity.Property(e => e.LicenseId)
                    .HasColumnName("LICENSE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrokerAgentCode)
                    .HasColumnName("BROKER_AGENT_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerAgentId).HasColumnName("BROKER_AGENT_ID");

                entity.Property(e => e.BrokerAgreeDate)
                    .HasColumnName("BROKER_AGREE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.BrokerAgreeReceived).HasColumnName("BROKER_AGREE_RECEIVED");

                entity.Property(e => e.BrokerAppointExpirationDate)
                    .HasColumnName("BROKER_APPOINT_EXPIRATION_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.BrokerId).HasColumnName("BROKER_ID");

                entity.Property(e => e.BrokerLicense1).HasColumnName("BROKER_LICENSE");

                entity.Property(e => e.BrokerLicenseCode)
                    .HasColumnName("BROKER_LICENSE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerLicensePol)
                    .HasColumnName("BROKER_LICENSE_POL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerLicenseReleaseDate)
                    .HasColumnName("BROKER_LICENSE_RELEASE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.BrokerLicenseSta)
                    .HasColumnName("BROKER_LICENSE_STA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerNo)
                    .HasColumnName("BROKER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastAppointDate)
                    .HasColumnName("LAST_APPOINT_DATE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseStateExpirationDate)
                    .HasColumnName("LICENSE_STATE_EXPIRATION_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Link)
                    .HasColumnName("LINK")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LinkId).HasColumnName("LINK_ID");

                entity.Property(e => e.SlLicNoSta)
                    .HasColumnName("SL_LIC_NO_STA")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SurplusLinesExpirationDate)
                    .HasColumnName("SURPLUS_LINES_EXPIRATION_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BrokerMaster>(entity =>
            {
                entity.HasKey(e => e.BrokerId);

                entity.ToTable("BROKER_MASTER");

                entity.Property(e => e.BrokerId)
                    .HasColumnName("BROKER_ID")
                    .HasComment("unique id for broker_master table")
                    .ValueGeneratedNever();

                entity.Property(e => e.BillMethod)
                    .HasColumnName("BILL_METHOD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BrokerAddress)
                    .HasColumnName("BROKER_ADDRESS")
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasComment("broker address");

                entity.Property(e => e.BrokerAddress2)
                    .HasColumnName("BROKER_ADDRESS2")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("broker address line 2");

                entity.Property(e => e.BrokerAgreementDate)
                    .HasColumnName("BROKER_AGREEMENT_DATE")
                    .HasColumnType("datetime")
                    .HasComment("broker agreement date");

                entity.Property(e => e.BrokerAgreementReceived)
                    .HasColumnName("BROKER_AGREEMENT_RECEIVED")
                    .HasComment("broker agreement received");

                entity.Property(e => e.BrokerAssignedDate)
                    .HasColumnName("BROKER_ASSIGNED_DATE")
                    .HasColumnType("datetime")
                    .HasComment("broker assigned date");

                entity.Property(e => e.BrokerCity)
                    .HasColumnName("BROKER_CITY")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("broker city");

                entity.Property(e => e.BrokerMasterPhone)
                    .HasColumnName("BROKER_MASTER_PHONE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerName)
                    .HasColumnName("BROKER_NAME")
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasComment("full broker name");

                entity.Property(e => e.BrokerNo)
                    .IsRequired()
                    .HasColumnName("BROKER_NO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("broker number");

                entity.Property(e => e.BrokerRank)
                    .HasColumnName("BROKER_RANK")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("broker rank");

                entity.Property(e => e.BrokerRegion)
                    .HasColumnName("BROKER_REGION")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("broker region");

                entity.Property(e => e.BrokerSta)
                    .HasColumnName("BROKER_STA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("broker state");

                entity.Property(e => e.BrokerTaxId)
                    .HasColumnName("BROKER_TAX_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BrokerType)
                    .HasColumnName("BROKER_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("broker type");

                entity.Property(e => e.BrokerZip)
                    .HasColumnName("BROKER_ZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("broker zip code");

                entity.Property(e => e.CommissionPct)
                    .HasColumnName("COMMISSION_PCT")
                    .HasComment("commission percentage");

                entity.Property(e => e.EntryMethod)
                    .HasColumnName("ENTRY_METHOD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Hide).HasColumnName("HIDE");

                entity.Property(e => e.HouseId)
                    .HasColumnName("HOUSE_ID")
                    .HasComment("unique id for broker house ");

                entity.Property(e => e.LastAppReceived)
                    .HasColumnName("LAST_APP_RECEIVED")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Link)
                    .HasColumnName("LINK")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarketingNotes)
                    .HasColumnName("Marketing_Notes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Merged).HasColumnName("MERGED");

                entity.Property(e => e.PrmNo).HasColumnName("PRM_NO");

                entity.Property(e => e.PrmProducerName)
                    .HasColumnName("PrmProducer_Name")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipManager)
                    .HasColumnName("RELATIONSHIP_MANAGER")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasColumnName("ROW_VERSION")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SalesForceLinkId)
                    .HasColumnName("SalesForceLinkID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlLicNo)
                    .HasColumnName("SL_LIC_NO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SurplusApplied)
                    .HasColumnName("SURPLUS_APPLIED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("SURPLUS APPLIED");

                entity.Property(e => e.SurplusLicExpDate)
                    .HasColumnName("SURPLUS_LIC_EXP_DATE")
                    .HasColumnType("datetime")
                    .HasComment("surplus license expiration date");

                entity.Property(e => e.VisitedRegion)
                    .HasColumnName("VISITED_REGION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("visited region");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClmMaster>(entity =>
            {
                entity.ToTable("CLM_MASTER");

                entity.HasIndex(e => e.AcctId)
                    .HasName("IX_ACCT_ID");

                entity.Property(e => e.ClmMasterId)
                    .HasColumnName("CLM_MASTER_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ASideCvg).HasColumnName("A_SIDE_CVG");

                entity.Property(e => e.AcctCycle)
                    .HasColumnName("ACCT_CYCLE")
                    .HasMaxLength(2);

                entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");

                entity.Property(e => e.AcctNo)
                    .HasColumnName("ACCT_NO")
                    .HasMaxLength(12);

                entity.Property(e => e.Attorney)
                    .HasColumnName("ATTORNEY")
                    .HasMaxLength(3);

                entity.Property(e => e.BasisForDenial1)
                    .HasColumnName("BASIS_FOR_DENIAL_1")
                    .HasMaxLength(2);

                entity.Property(e => e.BasisForDenial2)
                    .HasColumnName("BASIS_FOR_DENIAL_2")
                    .HasMaxLength(2);

                entity.Property(e => e.BasisForDenial3)
                    .HasColumnName("BASIS_FOR_DENIAL_3")
                    .HasMaxLength(2);

                entity.Property(e => e.BodilyInjury).HasColumnName("BODILY_INJURY");

                entity.Property(e => e.Capped)
                    .HasColumnName("CAPPED")
                    .HasMaxLength(1);

                entity.Property(e => e.CaseSummary)
                    .HasColumnName("CASE_SUMMARY")
                    .IsUnicode(false);

                entity.Property(e => e.Cause1)
                    .HasColumnName("CAUSE1")
                    .HasMaxLength(3);

                entity.Property(e => e.Cause2)
                    .HasColumnName("CAUSE2")
                    .HasMaxLength(3);

                entity.Property(e => e.Cause3)
                    .HasColumnName("CAUSE3")
                    .HasMaxLength(3);

                entity.Property(e => e.CedLaePaid).HasColumnName("CED_LAE_PAID");

                entity.Property(e => e.CedLaeRes).HasColumnName("CED_LAE_RES");

                entity.Property(e => e.CedLossPaid).HasColumnName("CED_LOSS_PAID");

                entity.Property(e => e.CedLossRes).HasColumnName("CED_LOSS_RES");

                entity.Property(e => e.ClaimStatus)
                    .HasColumnName("CLAIM_STATUS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Claimant)
                    .HasColumnName("CLAIMANT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClassAction).HasColumnName("CLASS_ACTION");

                entity.Property(e => e.ClmCreatedDate)
                    .HasColumnName("CLM_CREATED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClmMadeDate)
                    .HasColumnName("CLM_MADE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClmNo)
                    .IsRequired()
                    .HasColumnName("CLM_NO")
                    .HasMaxLength(11);

                entity.Property(e => e.ClmRelatedType)
                    .HasColumnName("CLM_RELATED_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClmRet).HasColumnName("CLM_RET");

                entity.Property(e => e.ClmReviewDate)
                    .HasColumnName("CLM_REVIEW_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ClmStatus)
                    .HasColumnName("CLM_STATUS")
                    .HasMaxLength(3);

                entity.Property(e => e.ClmType)
                    .HasColumnName("CLM_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("CLOSED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ContactInfo)
                    .HasColumnName("CONTACT_INFO")
                    .IsUnicode(false);

                entity.Property(e => e.CoverageCounsel)
                    .HasColumnName("COVERAGE_COUNSEL")
                    .HasMaxLength(3);

                entity.Property(e => e.CoverageDefense)
                    .HasColumnName("COVERAGE_DEFENSE")
                    .HasMaxLength(21);

                entity.Property(e => e.CoverageDefenseEst)
                    .HasColumnName("COVERAGE_DEFENSE_EST")
                    .HasMaxLength(2);

                entity.Property(e => e.CoverageDenied)
                    .HasColumnName("COVERAGE_DENIED")
                    .HasMaxLength(3);

                entity.Property(e => e.CoverageType)
                    .HasColumnName("COVERAGE_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CvgContactId).HasColumnName("CVG_CONTACT_ID");

                entity.Property(e => e.CvgLegalId).HasColumnName("CVG_LEGAL_ID");

                entity.Property(e => e.CvgUpdateStatus)
                    .HasColumnName("CVG_UPDATE_STATUS")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DamageDevPotEst)
                    .HasColumnName("DAMAGE_DEV_POT_EST")
                    .HasMaxLength(2);

                entity.Property(e => e.Defendant1)
                    .HasColumnName("DEFENDANT1")
                    .HasMaxLength(2);

                entity.Property(e => e.Defendant2)
                    .HasColumnName("DEFENDANT2")
                    .HasMaxLength(50);

                entity.Property(e => e.Defendant3)
                    .HasColumnName("DEFENDANT3")
                    .HasMaxLength(50);

                entity.Property(e => e.DefenseContactId).HasColumnName("DEFENSE_CONTACT_ID");

                entity.Property(e => e.DefenseFirmCode)
                    .HasColumnName("DEFENSE_FIRM_CODE")
                    .HasMaxLength(4);

                entity.Property(e => e.DefenseLegalId).HasColumnName("DEFENSE_LEGAL_ID");

                entity.Property(e => e.DerivativeSuit).HasColumnName("DERIVATIVE_SUIT");

                entity.Property(e => e.DiscoveryDate)
                    .HasColumnName("DISCOVERY_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Imaged).HasColumnName("IMAGED");

                entity.Property(e => e.IndustryHealth)
                    .HasColumnName("INDUSTRY_HEALTH")
                    .HasMaxLength(3);

                entity.Property(e => e.Journal)
                    .HasColumnName("JOURNAL")
                    .IsUnicode(false);

                entity.Property(e => e.JurisCourt)
                    .HasColumnName("JURIS_COURT")
                    .HasMaxLength(1);

                entity.Property(e => e.JurisState)
                    .HasColumnName("JURIS_STATE")
                    .HasMaxLength(2);

                entity.Property(e => e.LaePaidAuthority).HasColumnName("LAE_PAID_AUTHORITY");

                entity.Property(e => e.LastAdjustDate)
                    .HasColumnName("LAST_ADJUST_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3);

                entity.Property(e => e.LastTransDate)
                    .HasColumnName("LAST_TRANS_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LitigationDate)
                    .HasColumnName("LITIGATION_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LongFormChecked).HasColumnName("LONG_FORM_CHECKED");

                entity.Property(e => e.LossPaidAuthority).HasColumnName("LOSS_PAID_AUTHORITY");

                entity.Property(e => e.MemberCode)
                    .HasColumnName("MEMBER_CODE")
                    .HasMaxLength(7);

                entity.Property(e => e.NextUpdateDate)
                    .HasColumnName("NEXT_UPDATE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoticeDate)
                    .HasColumnName("NOTICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NoticeType)
                    .HasColumnName("NOTICE_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.PaidA).HasColumnName("PAID_A");

                entity.Property(e => e.PaidB).HasColumnName("PAID_B");

                entity.Property(e => e.PaidB2).HasColumnName("PAID_B2");

                entity.Property(e => e.PaidB3).HasColumnName("PAID_B3");

                entity.Property(e => e.PaidC).HasColumnName("PAID_C");

                entity.Property(e => e.PlaintiffFirmCode)
                    .HasColumnName("PLAINTIFF_FIRM_CODE")
                    .HasMaxLength(4);

                entity.Property(e => e.PlaintiffType)
                    .HasColumnName("PLAINTIFF_TYPE")
                    .HasMaxLength(2);

                entity.Property(e => e.PotentialOverincurred).HasColumnName("POTENTIAL_OVERINCURRED");

                entity.Property(e => e.PotentialSeverityEst)
                    .HasColumnName("POTENTIAL_SEVERITY_EST")
                    .HasMaxLength(2);

                entity.Property(e => e.RenewalComments)
                    .HasColumnName("RENEWAL_COMMENTS")
                    .IsUnicode(false);

                entity.Property(e => e.RenewalCommentsDate)
                    .HasColumnName("RENEWAL_COMMENTS_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReopenDate)
                    .HasColumnName("REOPEN_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReopenReason)
                    .HasColumnName("REOPEN_REASON")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveA).HasColumnName("RESERVE_A");

                entity.Property(e => e.ReserveB).HasColumnName("RESERVE_B");

                entity.Property(e => e.ReserveB2).HasColumnName("RESERVE_B2");

                entity.Property(e => e.ReserveB3).HasColumnName("RESERVE_B3");

                entity.Property(e => e.ReserveB31).HasColumnName("RESERVE_B31");

                entity.Property(e => e.ReserveC).HasColumnName("RESERVE_C");

                entity.Property(e => e.ReserveConfidenceEst)
                    .HasColumnName("RESERVE_CONFIDENCE_EST")
                    .HasMaxLength(2);

                entity.Property(e => e.StatusRequestDate)
                    .HasColumnName("STATUS_REQUEST_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SuitDate)
                    .HasColumnName("SUIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SuitFiled).HasColumnName("SUIT_FILED");

                entity.Property(e => e.SummaryJudgeDate)
                    .HasColumnName("SUMMARY_JUDGE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TotalDamages).HasColumnName("TOTAL_DAMAGES");

                entity.Property(e => e.TrialDate)
                    .HasColumnName("TRIAL_DATE")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.Acct)
                    .WithMany(p => p.ClmMaster)
                    .HasForeignKey(d => d.AcctId)
                    .HasConstraintName("FK_CLM_MASTER_ACCT_MASTER1");
            });

            modelBuilder.Entity<CorpOwner>(entity =>
            {
                entity.Property(e => e.CorpOwnerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CorpOwnerPercent).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LastChangedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EldDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("eld_Department");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.DepartmentAbbreviatedName)
                    .HasColumnName("Department_Abbreviated_Name")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepartmentHeadId).HasColumnName("Department_Head_Id");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasColumnName("Department_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentRowVersion)
                    .HasColumnName("Department_Row_Version")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<EldRefGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.DepartmentId });

                entity.ToTable("eld_refGroup");

                entity.Property(e => e.GroupId)
                    .HasColumnName("Group_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.GroupAbbreviatedName)
                    .HasColumnName("Group_Abbreviated_Name")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GroupHeadId).HasColumnName("Group_Head_Id");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("Group_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupRowVersion)
                    .HasColumnName("Group_Row_Version")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EldRefGroup)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eld_refGroup_eld_Department");
            });

            modelBuilder.Entity<EldUsers>(entity =>
            {
                entity.HasKey(e => e.EldUserId);

                entity.ToTable("eld_Users");

                entity.Property(e => e.EldUserId).HasColumnName("ELD_UserID");

                entity.Property(e => e.AdGuid).HasColumnName("AD_Guid");

                entity.Property(e => e.CodesId)
                    .HasColumnName("CODES_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_Of_Birth")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DisplayName)
                    .HasColumnName("Display_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.GroupId).HasColumnName("Group_Id");

                entity.Property(e => e.Ihazard)
                    .HasColumnName("IHazard")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastChangedOn)
                    .HasColumnName("LAST_CHANGED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginName)
                    .HasColumnName("Login_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("Manager_Id");

                entity.Property(e => e.OfficeLocationId).HasColumnName("Office_Location_Id");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PositionTitle)
                    .HasColumnName("Position_Title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleLevel).HasColumnName("TITLE_LEVEL");

                entity.Property(e => e.UserCode)
                    .HasColumnName("USER_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserGuid).HasColumnName("User_Guid");

                entity.Property(e => e.UsersRowVersion)
                    .HasColumnName("Users_Row_Version")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<InsuredInfo>(entity =>
            {
                entity.ToTable("INSURED_INFO");

                entity.Property(e => e.InsuredInfoId)
                    .HasColumnName("INSURED_INFO_ID")
                    .HasComment("unique id for insured_info field")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ein).HasColumnName("EIN");

                entity.Property(e => e.EinVerified).HasColumnName("EIN_Verified");

                entity.Property(e => e.InsuredAddress)
                    .HasColumnName("INSURED_ADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("insured address");

                entity.Property(e => e.InsuredAddresschk)
                    .HasColumnName("INSURED_ADDRESSCHK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredCity)
                    .HasColumnName("INSURED_CITY")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("insured city");

                entity.Property(e => e.InsuredCounty)
                    .HasColumnName("INSURED_COUNTY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredDbaName)
                    .HasColumnName("INSURED_DBA_NAME")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredMailingAddress)
                    .HasColumnName("INSURED_MailingADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredMailingCity)
                    .HasColumnName("INSURED_MailingCITY")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredMailingCounty)
                    .HasColumnName("INSURED_MailingCOUNTY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredMailingSta)
                    .HasColumnName("INSURED_MailingSTA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InsuredMailingZip)
                    .HasColumnName("INSURED_MailingZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredName)
                    .HasColumnName("INSURED_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("insured name");

                entity.Property(e => e.InsuredNamechk)
                    .HasColumnName("INSURED_NAMECHK")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("insured name check");

                entity.Property(e => e.InsuredNamechkFull)
                    .HasColumnName("INSURED_NAMECHK_FULL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InsuredNotes)
                    .HasColumnName("INSURED_NOTES")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("insured notes");

                entity.Property(e => e.InsuredSta)
                    .IsRequired()
                    .HasColumnName("INSURED_STA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("insured state");

                entity.Property(e => e.InsuredZip)
                    .HasColumnName("INSURED_ZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("insured zip code");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterInsuredId).HasColumnName("MASTER_INSURED_ID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasColumnName("ROW_VERSION")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Ticker)
                    .HasColumnName("TICKER")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LkpSubmissionStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lkpSUBMISSION_STATUS");

                entity.Property(e => e.CodesId)
                    .IsRequired()
                    .HasColumnName("CODES_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasColumnName("DESCRIP")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GenStat)
                    .HasColumnName("GEN_STAT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GenWord)
                    .HasColumnName("GEN_WORD")
                    .HasColumnType("text");

                entity.Property(e => e.HideWeb).HasColumnName("HIDE_WEB");

                entity.Property(e => e.LetterWording)
                    .HasColumnName("Letter_Wording")
                    .HasColumnType("text");

                entity.Property(e => e.LongWord)
                    .HasColumnName("LONG_WORD")
                    .HasColumnType("text");

                entity.Property(e => e.OpenStat)
                    .HasColumnName("OPEN_STAT")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReportWord)
                    .HasColumnName("REPORT_WORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subcode)
                    .HasColumnName("SUBCODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SsEldUserRole>(entity =>
            {
                entity.HasKey(e => e.SsUserRoleId);

                entity.ToTable("SS_EldUser_Role");

                entity.Property(e => e.SsUserRoleId).HasColumnName("SS_User_RoleID");

                entity.Property(e => e.SsEldUserId).HasColumnName("SS_eld_UserID");

                entity.Property(e => e.SsRoleId).HasColumnName("SS_RoleID");

                entity.HasOne(d => d.SsEldUser)
                    .WithMany(p => p.SsEldUserRole)
                    .HasForeignKey(d => d.SsEldUserId)
                    .HasConstraintName("FK_SS_EldUser_Role_eld_Users");

                entity.HasOne(d => d.SsRole)
                    .WithMany(p => p.SsEldUserRole)
                    .HasForeignKey(d => d.SsRoleId)
                    .HasConstraintName("FK_SS_EldUser_Role_SS_Role");
            });

            modelBuilder.Entity<SsPermission>(entity =>
            {
                entity.ToTable("SS_Permission");

                entity.Property(e => e.SsPermissionId).HasColumnName("SS_PermissionID");

                entity.Property(e => e.AppName)
                    .HasColumnName("App_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionName)
                    .HasColumnName("Permission_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SsRole>(entity =>
            {
                entity.ToTable("SS_Role");

                entity.Property(e => e.SsRoleId).HasColumnName("SS_RoleID");

                entity.Property(e => e.AppName)
                    .HasColumnName("App_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasColumnName("Role_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SsRolePermission>(entity =>
            {
                entity.ToTable("SS_Role_Permission");

                entity.Property(e => e.SsRolePermissionId).HasColumnName("SS_Role_PermissionID");

                entity.Property(e => e.OtherDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SsPermissionId).HasColumnName("SS_PermissionID");

                entity.Property(e => e.SsRoleId).HasColumnName("SS_RoleID");

                entity.HasOne(d => d.SsPermission)
                    .WithMany(p => p.SsRolePermission)
                    .HasForeignKey(d => d.SsPermissionId)
                    .HasConstraintName("FK_SS_Role_Permission_SS_Permission");

                entity.HasOne(d => d.SsRole)
                    .WithMany(p => p.SsRolePermission)
                    .HasForeignKey(d => d.SsRoleId)
                    .HasConstraintName("FK_SS_Role_Permission_SS_Role");
            });

            modelBuilder.Entity<UndFormBlanks>(entity =>
            {
                entity.HasKey(e => e.BlanksId);

                entity.ToTable("undFORM_BLANKS");

                entity.HasIndex(e => e.FormTransId)
                    .HasName("IX_FORM_TRANS_ID");

                entity.Property(e => e.BlanksId).HasColumnName("BLANKS_ID");

                entity.Property(e => e.Adate)
                    .HasColumnName("ADATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ano)
                    .HasColumnName("ANO")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.BlankNo)
                    .HasColumnName("BLANK_NO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlankText)
                    .HasColumnName("BLANK_TEXT")
                    .HasColumnType("text");

                entity.Property(e => e.BlankTextRtf)
                    .HasColumnName("BLANK_TEXT_RTF")
                    .HasColumnType("text");

                entity.Property(e => e.Fno)
                    .HasColumnName("FNO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FormTransId).HasColumnName("FORM_TRANS_ID");

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RowVersion)
                    .HasColumnName("ROW_VERSION")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FormTrans)
                    .WithMany(p => p.UndFormBlanks)
                    .HasForeignKey(d => d.FormTransId)
                    .HasConstraintName("FK_undFORM_BLANKS_undFORM_TRANS");
            });

            modelBuilder.Entity<UndFormTrans>(entity =>
            {
                entity.HasKey(e => e.FormTransId);

                entity.ToTable("undFORM_TRANS");

                entity.HasComment("Transaction Table");

                entity.Property(e => e.FormTransId).HasColumnName("FORM_TRANS_ID");

                entity.Property(e => e.AcctId).HasColumnName("ACCT_ID");

                entity.Property(e => e.AcctTransId).HasColumnName("ACCT_TRANS_ID");

                entity.Property(e => e.Adate)
                    .HasColumnName("ADATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Ano)
                    .HasColumnName("ANO")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Bstatus)
                    .HasColumnName("BSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fno)
                    .HasColumnName("FNO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FormCategory)
                    .HasColumnName("FORM_CATEGORY")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FormCustomName)
                    .HasColumnName("FORM_CUSTOM_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FormVersionId).HasColumnName("FORM_VERSION_ID");

                entity.Property(e => e.InFrom)
                    .HasColumnName("IN_FROM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IssuePageNo)
                    .HasColumnName("ISSUE_PAGE_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Istatus)
                    .HasColumnName("ISTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastChangedDate)
                    .HasColumnName("LAST_CHANGED_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangedId)
                    .HasColumnName("LAST_CHANGED_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mstatus)
                    .HasColumnName("MSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Optional).HasColumnName("OPTIONAL");

                entity.Property(e => e.Qstatus)
                    .HasColumnName("QSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RowVersion)
                    .HasColumnName("ROW_VERSION")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TransEffectiveDate)
                    .HasColumnName("TRANS_EFFECTIVE_DATE")
                    .HasColumnType("smalldatetime")
                    .HasComment("");
            });

            modelBuilder.Entity<UndLkpCoverageType>(entity =>
            {
                entity.HasKey(e => e.CoverageTypeId);

                entity.ToTable("und_lkpCoverageType");

                entity.Property(e => e.CoverageTypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CoverageTypeDecription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebQuoteUsers>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.Property(e => e.LoginId)
                    .HasColumnName("LoginID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);

                entity.Property(e => e.LoginPassword).IsRequired();

                entity.Property(e => e.UserLinkId).HasColumnName("UserLinkID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
