using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using tsmess.Models;

namespace tsmess.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CsaMAcademicYear> CsaMAcademicYears { get; set; }

    public virtual DbSet<CsaMAdmission> CsaMAdmissions { get; set; }

    public virtual DbSet<CsaMAttendance> CsaMAttendances { get; set; }

    public virtual DbSet<CsaMDashBoard> CsaMDashBoards { get; set; }

    public virtual DbSet<CsaMFinance> CsaMFinances { get; set; }

    public virtual DbSet<CsaMLessonPlan> CsaMLessonPlans { get; set; }

    public virtual DbSet<CsaMMcadmission> CsaMMcadmissions { get; set; }

    public virtual DbSet<CsaMPerformance> CsaMPerformances { get; set; }

    public virtual DbSet<CsaTVideoMetri> CsaTVideoMetris { get; set; }

    public virtual DbSet<EdusyncMiscFeeTracker> EdusyncMiscFeeTrackers { get; set; }

    public virtual DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }

    public virtual DbSet<EsyncApprovalHierarchyMaster> EsyncApprovalHierarchyMasters { get; set; }

    public virtual DbSet<EsyncApprovalHierarchyMasterDeatil> EsyncApprovalHierarchyMasterDeatils { get; set; }

    public virtual DbSet<EsyncCampaignMaster> EsyncCampaignMasters { get; set; }

    public virtual DbSet<EsyncExamTemplateConfig> EsyncExamTemplateConfigs { get; set; }

    public virtual DbSet<EsyncExamTemplateMaster> EsyncExamTemplateMasters { get; set; }

    public virtual DbSet<EsyncFeedBackMapping> EsyncFeedBackMappings { get; set; }

    public virtual DbSet<EsyncFeedBackQuery> EsyncFeedBackQueries { get; set; }

    public virtual DbSet<EsyncFeedBackUserRating> EsyncFeedBackUserRatings { get; set; }

    public virtual DbSet<EsyncHierarchyType> EsyncHierarchyTypes { get; set; }

    public virtual DbSet<EsyncInventoryworkflowMaster> EsyncInventoryworkflowMasters { get; set; }

    public virtual DbSet<EsyncInventoryworkflowTransaction> EsyncInventoryworkflowTransactions { get; set; }

    public virtual DbSet<EsyncMApplregistration> EsyncMApplregistrations { get; set; }

    public virtual DbSet<EsyncMAppluser> EsyncMApplusers { get; set; }

    public virtual DbSet<EsyncMCertificatesmaster> EsyncMCertificatesmasters { get; set; }

    public virtual DbSet<EsyncMRmsdocument> EsyncMRmsdocuments { get; set; }

    public virtual DbSet<EsyncMRmsnotification> EsyncMRmsnotifications { get; set; }

    public virtual DbSet<EsyncMRmsuser> EsyncMRmsusers { get; set; }

    public virtual DbSet<EsyncMSwrhallTicketDatum> EsyncMSwrhallTicketData { get; set; }

    public virtual DbSet<EsyncMSwruser> EsyncMSwrusers { get; set; }

    public virtual DbSet<EsyncPayrollTemplate> EsyncPayrollTemplates { get; set; }

    public virtual DbSet<EsyncShortTermJobApplicant> EsyncShortTermJobApplicants { get; set; }

    public virtual DbSet<EsyncStudentFeeDueTaxdetail> EsyncStudentFeeDueTaxdetails { get; set; }

    public virtual DbSet<EsyncStudentInstantFeeTaxdetail> EsyncStudentInstantFeeTaxdetails { get; set; }

    public virtual DbSet<EsyncTAppldoc> EsyncTAppldocs { get; set; }

    public virtual DbSet<EsyncTCertificatestransaction> EsyncTCertificatestransactions { get; set; }

    public virtual DbSet<EsyncTRmsapplication> EsyncTRmsapplications { get; set; }

    public virtual DbSet<EsyncTRmsapplicationConcession> EsyncTRmsapplicationConcessions { get; set; }

    public virtual DbSet<EsyncTRmsapplicationPayment> EsyncTRmsapplicationPayments { get; set; }

    public virtual DbSet<EsyncTRmscandidateContactDetail> EsyncTRmscandidateContactDetails { get; set; }

    public virtual DbSet<EsyncTRmscandidateCouncilReg> EsyncTRmscandidateCouncilRegs { get; set; }

    public virtual DbSet<EsyncTRmscandidateDeatil> EsyncTRmscandidateDeatils { get; set; }

    public virtual DbSet<EsyncTRmscandidateDocument> EsyncTRmscandidateDocuments { get; set; }

    public virtual DbSet<EsyncTRmscandidateExperienceDetail> EsyncTRmscandidateExperienceDetails { get; set; }

    public virtual DbSet<EsyncTRmscandidateJobProfile> EsyncTRmscandidateJobProfiles { get; set; }

    public virtual DbSet<EsyncTRmscandidateOtherDetail> EsyncTRmscandidateOtherDetails { get; set; }

    public virtual DbSet<EsyncTRmscandidateProfileLookup> EsyncTRmscandidateProfileLookups { get; set; }

    public virtual DbSet<EsyncTRmscandidatePublication> EsyncTRmscandidatePublications { get; set; }

    public virtual DbSet<EsyncTRmscandidateQualificationDetail> EsyncTRmscandidateQualificationDetails { get; set; }

    public virtual DbSet<EsyncTRmsjobPosition> EsyncTRmsjobPositions { get; set; }

    public virtual DbSet<EsyncTRmsnotificationDet> EsyncTRmsnotificationDets { get; set; }

    public virtual DbSet<EsyncTRmsnotificationResult> EsyncTRmsnotificationResults { get; set; }

    public virtual DbSet<EsyncTRmspgapplicationPayment> EsyncTRmspgapplicationPayments { get; set; }

    public virtual DbSet<EsyncTSwrpayment> EsyncTSwrpayments { get; set; }

    public virtual DbSet<EsyncTSwrpgpayment> EsyncTSwrpgpayments { get; set; }

    public virtual DbSet<EsyncTSwrstudentDetail> EsyncTSwrstudentDetails { get; set; }

    public virtual DbSet<EsyncTaxConfigurationDetail> EsyncTaxConfigurationDetails { get; set; }

    public virtual DbSet<EsyncTaxConfigurationMaster> EsyncTaxConfigurationMasters { get; set; }

    public virtual DbSet<EsyncUserHierarchyTransaction> EsyncUserHierarchyTransactions { get; set; }

    public virtual DbSet<FormTemplate> FormTemplates { get; set; }

    public virtual DbSet<GpsTLocationstatus> GpsTLocationstatuses { get; set; }

    public virtual DbSet<ImAsmassetDet> ImAsmassetDets { get; set; }

    public virtual DbSet<ImAsmassetProductDet> ImAsmassetProductDets { get; set; }

    public virtual DbSet<ImAsmassetTransaction> ImAsmassetTransactions { get; set; }

    public virtual DbSet<ImBillingOrder> ImBillingOrders { get; set; }

    public virtual DbSet<ImBillingOrdersDetail> ImBillingOrdersDetails { get; set; }

    public virtual DbSet<ImCategoryMaster> ImCategoryMasters { get; set; }

    public virtual DbSet<ImDepartmentMaster> ImDepartmentMasters { get; set; }

    public virtual DbSet<ImGrndetail> ImGrndetails { get; set; }

    public virtual DbSet<ImGrnmaster> ImGrnmasters { get; set; }

    public virtual DbSet<ImGrnreleasedHistory> ImGrnreleasedHistories { get; set; }

    public virtual DbSet<ImIndentDetail> ImIndentDetails { get; set; }

    public virtual DbSet<ImIndentMaster> ImIndentMasters { get; set; }

    public virtual DbSet<ImInsuranceDetail> ImInsuranceDetails { get; set; }

    public virtual DbSet<ImInsuranceMaster> ImInsuranceMasters { get; set; }

    public virtual DbSet<ImIssueItemDetail> ImIssueItemDetails { get; set; }

    public virtual DbSet<ImIssueMaster> ImIssueMasters { get; set; }

    public virtual DbSet<ImItemExistingStock> ImItemExistingStocks { get; set; }

    public virtual DbSet<ImItemmaster> ImItemmasters { get; set; }

    public virtual DbSet<ImItemsReceivedStock> ImItemsReceivedStocks { get; set; }

    public virtual DbSet<ImKitItemDetail> ImKitItemDetails { get; set; }

    public virtual DbSet<ImKitMaster> ImKitMasters { get; set; }

    public virtual DbSet<ImOutPassDetail> ImOutPassDetails { get; set; }

    public virtual DbSet<ImOutPassMaster> ImOutPassMasters { get; set; }

    public virtual DbSet<ImPurchaseOrderItem> ImPurchaseOrderItems { get; set; }

    public virtual DbSet<ImPurchaseOrderMaster> ImPurchaseOrderMasters { get; set; }

    public virtual DbSet<ImRepairAndMaintenanceDetail> ImRepairAndMaintenanceDetails { get; set; }

    public virtual DbSet<ImRepairAndMaintenanceMaster> ImRepairAndMaintenanceMasters { get; set; }

    public virtual DbSet<ImStaffItemsRequest> ImStaffItemsRequests { get; set; }

    public virtual DbSet<ImStaffItemsRequestDetail> ImStaffItemsRequestDetails { get; set; }

    public virtual DbSet<ImStoreDetail> ImStoreDetails { get; set; }

    public virtual DbSet<ImStoreItemStockDetail> ImStoreItemStockDetails { get; set; }

    public virtual DbSet<ImStoreSaleRegister> ImStoreSaleRegisters { get; set; }

    public virtual DbSet<ImStoreSaleRegisterDetail> ImStoreSaleRegisterDetails { get; set; }

    public virtual DbSet<ImStoreStaffDetail> ImStoreStaffDetails { get; set; }

    public virtual DbSet<ImSupplierMaster> ImSupplierMasters { get; set; }

    public virtual DbSet<ImUnitsMaster> ImUnitsMasters { get; set; }

    public virtual DbSet<ImUserTypeItemsLimit> ImUserTypeItemsLimits { get; set; }

    public virtual DbSet<IndexDatum> IndexData { get; set; }

    public virtual DbSet<Logsjob> Logsjobs { get; set; }

    public virtual DbSet<Mahindramultiportaldatum> Mahindramultiportaldata { get; set; }

    public virtual DbSet<MenuTable> MenuTables { get; set; }

    public virtual DbSet<OcStaffUrldetail> OcStaffUrldetails { get; set; }

    public virtual DbSet<OcStaffWiseClassEvent> OcStaffWiseClassEvents { get; set; }

    public virtual DbSet<OcStudentAttendance> OcStudentAttendances { get; set; }

    public virtual DbSet<OcStudentPeriodAttendance> OcStudentPeriodAttendances { get; set; }

    public virtual DbSet<ProcedureLog> ProcedureLogs { get; set; }

    public virtual DbSet<Rfidprocessedattendance> Rfidprocessedattendances { get; set; }

    public virtual DbSet<SaveQuery> SaveQueries { get; set; }

    public virtual DbSet<StudentDetail> StudentDetails { get; set; }

    public virtual DbSet<UbaM2mregistrationType> UbaM2mregistrationTypes { get; set; }

    public virtual DbSet<UbaMFinancialyeardetail> UbaMFinancialyeardetails { get; set; }

    public virtual DbSet<UbaMM2mvoucherMaster> UbaMM2mvoucherMasters { get; set; }

    public virtual DbSet<UbaOrganizationBankMaster> UbaOrganizationBankMasters { get; set; }

    public virtual DbSet<UbaOrganizationMaster> UbaOrganizationMasters { get; set; }

    public virtual DbSet<UbaSsconcessionDetail> UbaSsconcessionDetails { get; set; }

    public virtual DbSet<UbaSsconcessionMaster> UbaSsconcessionMasters { get; set; }

    public virtual DbSet<UbaSsconcessionType> UbaSsconcessionTypes { get; set; }

    public virtual DbSet<UbaSsconsessionTransaction> UbaSsconsessionTransactions { get; set; }

    public virtual DbSet<UcLmLeaveTransaction> UcLmLeaveTransactions { get; set; }

    public virtual DbSet<UcLmLeavesEligibilityForUser> UcLmLeavesEligibilityForUsers { get; set; }

    public virtual DbSet<UcLmMLeaveType> UcLmMLeaveTypes { get; set; }

    public virtual DbSet<UcLmMLeavesEligibility> UcLmMLeavesEligibilities { get; set; }

    public virtual DbSet<UcLmMLeavesProcessingDetail> UcLmMLeavesProcessingDetails { get; set; }

    public virtual DbSet<Ucerrorlog> Ucerrorlogs { get; set; }

    public virtual DbSet<VwAdmissionsDetail> VwAdmissionsDetails { get; set; }

    public virtual DbSet<VwExamPerformance> VwExamPerformances { get; set; }

    public virtual DbSet<VwFeeDetail> VwFeeDetails { get; set; }

    public virtual DbSet<VwStaffDetail> VwStaffDetails { get; set; }

    public virtual DbSet<VwStudentDetail> VwStudentDetails { get; set; }

    public virtual DbSet<VwStudentFeeDueDetail> VwStudentFeeDueDetails { get; set; }

    public virtual DbSet<VwTransportDetail> VwTransportDetails { get; set; }

    public virtual DbSet<WdITBudgetAc> WdITBudgetAcs { get; set; }

    public virtual DbSet<WdiMAcademicClassSection> WdiMAcademicClassSections { get; set; }

    public virtual DbSet<WdiMAcademicYearDetail> WdiMAcademicYearDetails { get; set; }

    public virtual DbSet<WdiMAccesspermission> WdiMAccesspermissions { get; set; }

    public virtual DbSet<WdiMAccountHeadMaster> WdiMAccountHeadMasters { get; set; }

    public virtual DbSet<WdiMAccountsMainMaster> WdiMAccountsMainMasters { get; set; }

    public virtual DbSet<WdiMAchievement> WdiMAchievements { get; set; }

    public virtual DbSet<WdiMAdminuseraccess> WdiMAdminuseraccesses { get; set; }

    public virtual DbSet<WdiMAdmissionvacancyPosition> WdiMAdmissionvacancyPositions { get; set; }

    public virtual DbSet<WdiMAllotmentdetail> WdiMAllotmentdetails { get; set; }

    public virtual DbSet<WdiMAppnotification> WdiMAppnotifications { get; set; }

    public virtual DbSet<WdiMAssessmentType> WdiMAssessmentTypes { get; set; }

    public virtual DbSet<WdiMBankDetail> WdiMBankDetails { get; set; }

    public virtual DbSet<WdiMBatchMaster> WdiMBatchMasters { get; set; }

    public virtual DbSet<WdiMBillingOrder> WdiMBillingOrders { get; set; }

    public virtual DbSet<WdiMBillingOrdersDetail> WdiMBillingOrdersDetails { get; set; }

    public virtual DbSet<WdiMBlockMaster> WdiMBlockMasters { get; set; }

    public virtual DbSet<WdiMBookMarksForApp> WdiMBookMarksForApps { get; set; }

    public virtual DbSet<WdiMBudgetHead> WdiMBudgetHeads { get; set; }

    public virtual DbSet<WdiMBuildingMaster> WdiMBuildingMasters { get; set; }

    public virtual DbSet<WdiMBusinessRuleMaster> WdiMBusinessRuleMasters { get; set; }

    public virtual DbSet<WdiMBussinessType> WdiMBussinessTypes { get; set; }

    public virtual DbSet<WdiMCaste> WdiMCastes { get; set; }

    public virtual DbSet<WdiMCategoryMaster> WdiMCategoryMasters { get; set; }

    public virtual DbSet<WdiMCcreportTemplate> WdiMCcreportTemplates { get; set; }

    public virtual DbSet<WdiMClass> WdiMClasses { get; set; }

    public virtual DbSet<WdiMClassWiseStypendAmount> WdiMClassWiseStypendAmounts { get; set; }

    public virtual DbSet<WdiMClub> WdiMClubs { get; set; }

    public virtual DbSet<WdiMCoCurricularActivity> WdiMCoCurricularActivities { get; set; }

    public virtual DbSet<WdiMCommTemplate> WdiMCommTemplates { get; set; }

    public virtual DbSet<WdiMComplaintDetail> WdiMComplaintDetails { get; set; }

    public virtual DbSet<WdiMCountry> WdiMCountries { get; set; }

    public virtual DbSet<WdiMCourseGroupMaster> WdiMCourseGroupMasters { get; set; }

    public virtual DbSet<WdiMDailyActivity> WdiMDailyActivities { get; set; }

    public virtual DbSet<WdiMDepartmentMaster> WdiMDepartmentMasters { get; set; }

    public virtual DbSet<WdiMDocument> WdiMDocuments { get; set; }

    public virtual DbSet<WdiMEmailtemplateMaster> WdiMEmailtemplateMasters { get; set; }

    public virtual DbSet<WdiMEmpLeaveMaster> WdiMEmpLeaveMasters { get; set; }

    public virtual DbSet<WdiMEmployeeLeaveTypeDatum> WdiMEmployeeLeaveTypeData { get; set; }

    public virtual DbSet<WdiMEnquiry> WdiMEnquiries { get; set; }

    public virtual DbSet<WdiMEpayTransaction> WdiMEpayTransactions { get; set; }

    public virtual DbSet<WdiMEvaluationSubject> WdiMEvaluationSubjects { get; set; }

    public virtual DbSet<WdiMEvent> WdiMEvents { get; set; }

    public virtual DbSet<WdiMEventActivityType> WdiMEventActivityTypes { get; set; }

    public virtual DbSet<WdiMExaminationName> WdiMExaminationNames { get; set; }

    public virtual DbSet<WdiMExpenseType> WdiMExpenseTypes { get; set; }

    public virtual DbSet<WdiMFacultyMapping> WdiMFacultyMappings { get; set; }

    public virtual DbSet<WdiMFacultyvacancyposition> WdiMFacultyvacancypositions { get; set; }

    public virtual DbSet<WdiMFamilyMember> WdiMFamilyMembers { get; set; }

    public virtual DbSet<WdiMFeeHeadGroupMaster> WdiMFeeHeadGroupMasters { get; set; }

    public virtual DbSet<WdiMFeeHeadMaster> WdiMFeeHeadMasters { get; set; }

    public virtual DbSet<WdiMFeeHeadsMappingMaster> WdiMFeeHeadsMappingMasters { get; set; }

    public virtual DbSet<WdiMFinancialYear> WdiMFinancialYears { get; set; }

    public virtual DbSet<WdiMFpmachine> WdiMFpmachines { get; set; }

    public virtual DbSet<WdiMGrade> WdiMGrades { get; set; }

    public virtual DbSet<WdiMHostel> WdiMHostels { get; set; }

    public virtual DbSet<WdiMHouseSystem> WdiMHouseSystems { get; set; }

    public virtual DbSet<WdiMIcsecoCurricularActivity> WdiMIcsecoCurricularActivities { get; set; }

    public virtual DbSet<WdiMIcsesubTool> WdiMIcsesubTools { get; set; }

    public virtual DbSet<WdiMIcsetool> WdiMIcsetools { get; set; }

    public virtual DbSet<WdiMItemDescription> WdiMItemDescriptions { get; set; }

    public virtual DbSet<WdiMItemPhoto> WdiMItemPhotoes { get; set; }

    public virtual DbSet<WdiMItemmaster> WdiMItemmasters { get; set; }

    public virtual DbSet<WdiMLanguage> WdiMLanguages { get; set; }

    public virtual DbSet<WdiMLeaveMaster> WdiMLeaveMasters { get; set; }

    public virtual DbSet<WdiMLeaveType> WdiMLeaveTypes { get; set; }

    public virtual DbSet<WdiMLibraryeligibility> WdiMLibraryeligibilities { get; set; }

    public virtual DbSet<WdiMLibraryrack> WdiMLibraryracks { get; set; }

    public virtual DbSet<WdiMLicencing> WdiMLicencings { get; set; }

    public virtual DbSet<WdiMMealMenuConfiguration> WdiMMealMenuConfigurations { get; set; }

    public virtual DbSet<WdiMMealMenuConfigurationTransactionDetail> WdiMMealMenuConfigurationTransactionDetails { get; set; }

    public virtual DbSet<WdiMMessageFolder> WdiMMessageFolders { get; set; }

    public virtual DbSet<WdiMMetricsDetail> WdiMMetricsDetails { get; set; }

    public virtual DbSet<WdiMMobileAccessModule> WdiMMobileAccessModules { get; set; }

    public virtual DbSet<WdiMMtnfeePayRequest> WdiMMtnfeePayRequests { get; set; }

    public virtual DbSet<WdiMMtnfeePayRequestDetail> WdiMMtnfeePayRequestDetails { get; set; }

    public virtual DbSet<WdiMMultiBranchAccess> WdiMMultiBranchAccesses { get; set; }

    public virtual DbSet<WdiMObjestsmaster> WdiMObjestsmasters { get; set; }

    public virtual DbSet<WdiMOtpengine> WdiMOtpengines { get; set; }

    public virtual DbSet<WdiMPageMaster> WdiMPageMasters { get; set; }

    public virtual DbSet<WdiMPartner> WdiMPartners { get; set; }

    public virtual DbSet<WdiMPartnerSiteDetail> WdiMPartnerSiteDetails { get; set; }

    public virtual DbSet<WdiMPaymentExtraDetail> WdiMPaymentExtraDetails { get; set; }

    public virtual DbSet<WdiMPayrollMasterhead> WdiMPayrollMasterheads { get; set; }

    public virtual DbSet<WdiMPayrollPartnerHead> WdiMPayrollPartnerHeads { get; set; }

    public virtual DbSet<WdiMPaytmpgplusrespmaster> WdiMPaytmpgplusrespmasters { get; set; }

    public virtual DbSet<WdiMPeriodMaster> WdiMPeriodMasters { get; set; }

    public virtual DbSet<WdiMPgpartnerMerchantDetail> WdiMPgpartnerMerchantDetails { get; set; }

    public virtual DbSet<WdiMPgspecialfeepayment> WdiMPgspecialfeepayments { get; set; }

    public virtual DbSet<WdiMPgstatus> WdiMPgstatuses { get; set; }

    public virtual DbSet<WdiMPublisherMaster> WdiMPublisherMasters { get; set; }

    public virtual DbSet<WdiMQualification> WdiMQualifications { get; set; }

    public virtual DbSet<WdiMReligion> WdiMReligions { get; set; }

    public virtual DbSet<WdiMRemark> WdiMRemarks { get; set; }

    public virtual DbSet<WdiMRolemaster> WdiMRolemasters { get; set; }

    public virtual DbSet<WdiMRoomMaster> WdiMRoomMasters { get; set; }

    public virtual DbSet<WdiMScholarshipTypeMaster> WdiMScholarshipTypeMasters { get; set; }

    public virtual DbSet<WdiMSchoolLeaveMaster> WdiMSchoolLeaveMasters { get; set; }

    public virtual DbSet<WdiMSeason> WdiMSeasons { get; set; }

    public virtual DbSet<WdiMSection> WdiMSections { get; set; }

    public virtual DbSet<WdiMSemisterMaster> WdiMSemisterMasters { get; set; }

    public virtual DbSet<WdiMSession> WdiMSessions { get; set; }

    public virtual DbSet<WdiMSkill> WdiMSkills { get; set; }

    public virtual DbSet<WdiMSkillschedule> WdiMSkillschedules { get; set; }

    public virtual DbSet<WdiMSmslog> WdiMSmslogs { get; set; }

    public virtual DbSet<WdiMSmstypeMaster> WdiMSmstypeMasters { get; set; }

    public virtual DbSet<WdiMSpecialEnquiry> WdiMSpecialEnquiries { get; set; }

    public virtual DbSet<WdiMSpecialfeepayment> WdiMSpecialfeepayments { get; set; }

    public virtual DbSet<WdiMSplFeeCategory> WdiMSplFeeCategories { get; set; }

    public virtual DbSet<WdiMStreamMaster> WdiMStreamMasters { get; set; }

    public virtual DbSet<WdiMStudentFeeDue> WdiMStudentFeeDues { get; set; }

    public virtual DbSet<WdiMSubTool> WdiMSubTools { get; set; }

    public virtual DbSet<WdiMSubject> WdiMSubjects { get; set; }

    public virtual DbSet<WdiMSubscribeDetail> WdiMSubscribeDetails { get; set; }

    public virtual DbSet<WdiMSuppliermaster> WdiMSuppliermasters { get; set; }

    public virtual DbSet<WdiMTemplate> WdiMTemplates { get; set; }

    public virtual DbSet<WdiMTenantAdminUser> WdiMTenantAdminUsers { get; set; }

    public virtual DbSet<WdiMTenantModule> WdiMTenantModules { get; set; }

    public virtual DbSet<WdiMTenantSchema> WdiMTenantSchemas { get; set; }

    public virtual DbSet<WdiMTenantchanneltemplate> WdiMTenantchanneltemplates { get; set; }

    public virtual DbSet<WdiMTenantrolemaster> WdiMTenantrolemasters { get; set; }

    public virtual DbSet<WdiMTenanttemplatetypegroup> WdiMTenanttemplatetypegroups { get; set; }

    public virtual DbSet<WdiMTicket> WdiMTickets { get; set; }

    public virtual DbSet<WdiMTicketStatus> WdiMTicketStatuses { get; set; }

    public virtual DbSet<WdiMTicketType> WdiMTicketTypes { get; set; }

    public virtual DbSet<WdiMTodolist> WdiMTodolists { get; set; }

    public virtual DbSet<WdiMTool> WdiMTools { get; set; }

    public virtual DbSet<WdiMTraismstemplateMaster> WdiMTraismstemplateMasters { get; set; }

    public virtual DbSet<WdiMTransportlocationmaster> WdiMTransportlocationmasters { get; set; }

    public virtual DbSet<WdiMTransportroutemaster> WdiMTransportroutemasters { get; set; }

    public virtual DbSet<WdiMTransportvehiclemaster> WdiMTransportvehiclemasters { get; set; }

    public virtual DbSet<WdiMUser> WdiMUsers { get; set; }

    public virtual DbSet<WdiMUseraccesspermission> WdiMUseraccesspermissions { get; set; }

    public virtual DbSet<WdiMUseridentity> WdiMUseridentities { get; set; }

    public virtual DbSet<WdiMUserssecure> WdiMUserssecures { get; set; }

    public virtual DbSet<WdiMVechicletype> WdiMVechicletypes { get; set; }

    public virtual DbSet<WdiMVehicleExpense> WdiMVehicleExpenses { get; set; }

    public virtual DbSet<WdiMView> WdiMViews { get; set; }

    public virtual DbSet<WdiMVisitorLog> WdiMVisitorLogs { get; set; }

    public virtual DbSet<WdiMWebsitePage> WdiMWebsitePages { get; set; }

    public virtual DbSet<WdiTAbsent> WdiTAbsents { get; set; }

    public virtual DbSet<WdiTAccountDet> WdiTAccountDets { get; set; }

    public virtual DbSet<WdiTAccountTransaction> WdiTAccountTransactions { get; set; }

    public virtual DbSet<WdiTActionLog> WdiTActionLogs { get; set; }

    public virtual DbSet<WdiTAdjustFacultyPeriodTimetable> WdiTAdjustFacultyPeriodTimetables { get; set; }

    public virtual DbSet<WdiTAdmissionEnquiry> WdiTAdmissionEnquiries { get; set; }

    public virtual DbSet<WdiTApplication> WdiTApplications { get; set; }

    public virtual DbSet<WdiTApplicationFollowup> WdiTApplicationFollowups { get; set; }

    public virtual DbSet<WdiTAssessmentTransction> WdiTAssessmentTransctions { get; set; }

    public virtual DbSet<WdiTAttendancelog> WdiTAttendancelogs { get; set; }

    public virtual DbSet<WdiTBankTransaction> WdiTBankTransactions { get; set; }

    public virtual DbSet<WdiTBatchAttendance> WdiTBatchAttendances { get; set; }

    public virtual DbSet<WdiTBatchAttendanceDetail> WdiTBatchAttendanceDetails { get; set; }

    public virtual DbSet<WdiTBatchPeriodAttendanceDetail> WdiTBatchPeriodAttendanceDetails { get; set; }

    public virtual DbSet<WdiTBranchRegister> WdiTBranchRegisters { get; set; }

    public virtual DbSet<WdiTBranchWiseStudentDue> WdiTBranchWiseStudentDues { get; set; }

    public virtual DbSet<WdiTBranchwisefeeCollection> WdiTBranchwisefeeCollections { get; set; }

    public virtual DbSet<WdiTBreak> WdiTBreaks { get; set; }

    public virtual DbSet<WdiTBudgetAccount> WdiTBudgetAccounts { get; set; }

    public virtual DbSet<WdiTCalendarEvent> WdiTCalendarEvents { get; set; }

    public virtual DbSet<WdiTCallBackDetail> WdiTCallBackDetails { get; set; }

    public virtual DbSet<WdiTCceareaMaster> WdiTCceareaMasters { get; set; }

    public virtual DbSet<WdiTCceclassmappingdetail> WdiTCceclassmappingdetails { get; set; }

    public virtual DbSet<WdiTCceexamsMapping> WdiTCceexamsMappings { get; set; }

    public virtual DbSet<WdiTCcefieldMaster> WdiTCcefieldMasters { get; set; }

    public virtual DbSet<WdiTCcemasterTemplate> WdiTCcemasterTemplates { get; set; }

    public virtual DbSet<WdiTCcetermMaster> WdiTCcetermMasters { get; set; }

    public virtual DbSet<WdiTCcpartnerReportTemplate> WdiTCcpartnerReportTemplates { get; set; }

    public virtual DbSet<WdiTCertificateTypesDatum> WdiTCertificateTypesData { get; set; }

    public virtual DbSet<WdiTCheckClasswiseAttendance> WdiTCheckClasswiseAttendances { get; set; }

    public virtual DbSet<WdiTClassTermMapping> WdiTClassTermMappings { get; set; }

    public virtual DbSet<WdiTClassWiseExaminationMapping> WdiTClassWiseExaminationMappings { get; set; }

    public virtual DbSet<WdiTCoCurricularActivitiyGrade> WdiTCoCurricularActivitiyGrades { get; set; }

    public virtual DbSet<WdiTCoScholasticGrade> WdiTCoScholasticGrades { get; set; }

    public virtual DbSet<WdiTConcessionDetail> WdiTConcessionDetails { get; set; }

    public virtual DbSet<WdiTContact> WdiTContacts { get; set; }

    public virtual DbSet<WdiTDashboardView> WdiTDashboardViews { get; set; }

    public virtual DbSet<WdiTDeActivatedStudent> WdiTDeActivatedStudents { get; set; }

    public virtual DbSet<WdiTDeleteLog> WdiTDeleteLogs { get; set; }

    public virtual DbSet<WdiTDescriptorIndicator> WdiTDescriptorIndicators { get; set; }

    public virtual DbSet<WdiTDisciplineDetail> WdiTDisciplineDetails { get; set; }

    public virtual DbSet<WdiTEmailReceipentsTable> WdiTEmailReceipentsTables { get; set; }

    public virtual DbSet<WdiTEmpCompleteLeaveTrasaction> WdiTEmpCompleteLeaveTrasactions { get; set; }

    public virtual DbSet<WdiTEmpDeductionLeaveTrasaction> WdiTEmpDeductionLeaveTrasactions { get; set; }

    public virtual DbSet<WdiTEmpLeaveEligibilityTracker> WdiTEmpLeaveEligibilityTrackers { get; set; }

    public virtual DbSet<WdiTEmployeeCompensatoryLeaf> WdiTEmployeeCompensatoryLeaves { get; set; }

    public virtual DbSet<WdiTEmployeeLeaf> WdiTEmployeeLeaves { get; set; }

    public virtual DbSet<WdiTEmployeeLeaveEligibility> WdiTEmployeeLeaveEligibilities { get; set; }

    public virtual DbSet<WdiTEmployeeLeaveTrasaction> WdiTEmployeeLeaveTrasactions { get; set; }

    public virtual DbSet<WdiTEnquire> WdiTEnquires { get; set; }

    public virtual DbSet<WdiTEnquiryFollowup> WdiTEnquiryFollowups { get; set; }

    public virtual DbSet<WdiTEvaluationMark> WdiTEvaluationMarks { get; set; }

    public virtual DbSet<WdiTEventAttendanceDetail> WdiTEventAttendanceDetails { get; set; }

    public virtual DbSet<WdiTExamMark> WdiTExamMarks { get; set; }

    public virtual DbSet<WdiTExamSchedule> WdiTExamSchedules { get; set; }

    public virtual DbSet<WdiTExamTimeTable> WdiTExamTimeTables { get; set; }

    public virtual DbSet<WdiTFacultyDetail> WdiTFacultyDetails { get; set; }

    public virtual DbSet<WdiTFeeAccountMapping> WdiTFeeAccountMappings { get; set; }

    public virtual DbSet<WdiTFeeDueMonth> WdiTFeeDueMonths { get; set; }

    public virtual DbSet<WdiTFeePayment> WdiTFeePayments { get; set; }

    public virtual DbSet<WdiTFeePaymentDetail> WdiTFeePaymentDetails { get; set; }

    public virtual DbSet<WdiTFeepaymentsCopy> WdiTFeepaymentsCopies { get; set; }

    public virtual DbSet<WdiTFinalExamWeightage> WdiTFinalExamWeightages { get; set; }

    public virtual DbSet<WdiTFineAmountDetail> WdiTFineAmountDetails { get; set; }

    public virtual DbSet<WdiTGrouplevelrb> WdiTGrouplevelrbs { get; set; }

    public virtual DbSet<WdiTHalfDayAttendance> WdiTHalfDayAttendances { get; set; }

    public virtual DbSet<WdiTHeadwiseFeeCollection> WdiTHeadwiseFeeCollections { get; set; }

    public virtual DbSet<WdiTHomeworkfile> WdiTHomeworkfiles { get; set; }

    public virtual DbSet<WdiTHostelAttendanceRawDatum> WdiTHostelAttendanceRawData { get; set; }

    public virtual DbSet<WdiTHourlyAttendance> WdiTHourlyAttendances { get; set; }

    public virtual DbSet<WdiTHourlyEventAttendance> WdiTHourlyEventAttendances { get; set; }

    public virtual DbSet<WdiTIcseclassWiseExaminationMapping> WdiTIcseclassWiseExaminationMappings { get; set; }

    public virtual DbSet<WdiTIcseclassWisePercentage> WdiTIcseclassWisePercentages { get; set; }

    public virtual DbSet<WdiTIcseclassmappingdetail> WdiTIcseclassmappingdetails { get; set; }

    public virtual DbSet<WdiTIcsecoCurricularActivitiyGrade> WdiTIcsecoCurricularActivitiyGrades { get; set; }

    public virtual DbSet<WdiTIcsecoScholasticGrade> WdiTIcsecoScholasticGrades { get; set; }

    public virtual DbSet<WdiTIcsedescriptorIndicator> WdiTIcsedescriptorIndicators { get; set; }

    public virtual DbSet<WdiTIcseexamMark> WdiTIcseexamMarks { get; set; }

    public virtual DbSet<WdiTIcseexamSchedule> WdiTIcseexamSchedules { get; set; }

    public virtual DbSet<WdiTIcseexamTimeTable> WdiTIcseexamTimeTables { get; set; }

    public virtual DbSet<WdiTIcseexamsMapping> WdiTIcseexamsMappings { get; set; }

    public virtual DbSet<WdiTIcsefieldMaster> WdiTIcsefieldMasters { get; set; }

    public virtual DbSet<WdiTIcsemasterTemplate> WdiTIcsemasterTemplates { get; set; }

    public virtual DbSet<WdiTIcsepartnerDescriptorsMaster> WdiTIcsepartnerDescriptorsMasters { get; set; }

    public virtual DbSet<WdiTIcsescholasticGrade> WdiTIcsescholasticGrades { get; set; }

    public virtual DbSet<WdiTIcsestudentCoScholasticMark> WdiTIcsestudentCoScholasticMarks { get; set; }

    public virtual DbSet<WdiTIcsestudentConsolidatedExamResult> WdiTIcsestudentConsolidatedExamResults { get; set; }

    public virtual DbSet<WdiTIcsetermMaster> WdiTIcsetermMasters { get; set; }

    public virtual DbSet<WdiTIcsetermWiseRemark> WdiTIcsetermWiseRemarks { get; set; }

    public virtual DbSet<WdiTIcsetermWiseReportDate> WdiTIcsetermWiseReportDates { get; set; }

    public virtual DbSet<WdiTIcsetoolMapping> WdiTIcsetoolMappings { get; set; }

    public virtual DbSet<WdiTIcsetoolMark> WdiTIcsetoolMarks { get; set; }

    public virtual DbSet<WdiTInWard> WdiTInWards { get; set; }

    public virtual DbSet<WdiTIncomTaxRecord> WdiTIncomTaxRecords { get; set; }

    public virtual DbSet<WdiTInvIssuedStock> WdiTInvIssuedStocks { get; set; }

    public virtual DbSet<WdiTInvIssuedStockPartner> WdiTInvIssuedStockPartners { get; set; }

    public virtual DbSet<WdiTInvRecStock> WdiTInvRecStocks { get; set; }

    public virtual DbSet<WdiTInvStock> WdiTInvStocks { get; set; }

    public virtual DbSet<WdiTInventoryLog> WdiTInventoryLogs { get; set; }

    public virtual DbSet<WdiTInventoryWorkflow> WdiTInventoryWorkflows { get; set; }

    public virtual DbSet<WdiTIssuesFeedback> WdiTIssuesFeedbacks { get; set; }

    public virtual DbSet<WdiTLateAttendanceCounting> WdiTLateAttendanceCountings { get; set; }

    public virtual DbSet<WdiTLeaveTransaction> WdiTLeaveTransactions { get; set; }

    public virtual DbSet<WdiTLeaveTransactionDetail> WdiTLeaveTransactionDetails { get; set; }

    public virtual DbSet<WdiTLessonPlanner> WdiTLessonPlanners { get; set; }

    public virtual DbSet<WdiTLibraryaccession> WdiTLibraryaccessions { get; set; }

    public virtual DbSet<WdiTLibraryissuereturn> WdiTLibraryissuereturns { get; set; }

    public virtual DbSet<WdiTLibrarypenalty> WdiTLibrarypenalties { get; set; }

    public virtual DbSet<WdiTLoginJsession> WdiTLoginJsessions { get; set; }

    public virtual DbSet<WdiTM2mStudentExitDetail> WdiTM2mStudentExitDetails { get; set; }

    public virtual DbSet<WdiTM2mmoneyDeposit> WdiTM2mmoneyDeposits { get; set; }

    public virtual DbSet<WdiTMealMenuConsumedDetail> WdiTMealMenuConsumedDetails { get; set; }

    public virtual DbSet<WdiTMedium> WdiTMediums { get; set; }

    public virtual DbSet<WdiTMessage> WdiTMessages { get; set; }

    public virtual DbSet<WdiTMessageFolder> WdiTMessageFolders { get; set; }

    public virtual DbSet<WdiTMetricsTransactionDetail> WdiTMetricsTransactionDetails { get; set; }

    public virtual DbSet<WdiTMobilereglog> WdiTMobilereglogs { get; set; }

    public virtual DbSet<WdiTMonthwisestudentattendance> WdiTMonthwisestudentattendances { get; set; }

    public virtual DbSet<WdiTNewLetterSubscription> WdiTNewLetterSubscriptions { get; set; }

    public virtual DbSet<WdiTNonbranchfeepaydetail> WdiTNonbranchfeepaydetails { get; set; }

    public virtual DbSet<WdiTOnBoardApplication> WdiTOnBoardApplications { get; set; }

    public virtual DbSet<WdiTOnboardAndExcessPayment> WdiTOnboardAndExcessPayments { get; set; }

    public virtual DbSet<WdiTOutPassDetail> WdiTOutPassDetails { get; set; }

    public virtual DbSet<WdiTPartnerBusinessRule> WdiTPartnerBusinessRules { get; set; }

    public virtual DbSet<WdiTPartnerDescriptorsMaster> WdiTPartnerDescriptorsMasters { get; set; }

    public virtual DbSet<WdiTPartnerProfile> WdiTPartnerProfiles { get; set; }

    public virtual DbSet<WdiTPartnerScheduler> WdiTPartnerSchedulers { get; set; }

    public virtual DbSet<WdiTPartnerTemplate> WdiTPartnerTemplates { get; set; }

    public virtual DbSet<WdiTPartnerTemplatesNew> WdiTPartnerTemplatesNews { get; set; }

    public virtual DbSet<WdiTPayRollAccountTransaction> WdiTPayRollAccountTransactions { get; set; }

    public virtual DbSet<WdiTPayRollSalaryRangeTransaction> WdiTPayRollSalaryRangeTransactions { get; set; }

    public virtual DbSet<WdiTPayTransaction> WdiTPayTransactions { get; set; }

    public virtual DbSet<WdiTPayTransactionRemark> WdiTPayTransactionRemarks { get; set; }

    public virtual DbSet<WdiTPayrollLoanAdvancesPaymentSchedule> WdiTPayrollLoanAdvancesPaymentSchedules { get; set; }

    public virtual DbSet<WdiTPayrollLoansAdvance> WdiTPayrollLoansAdvances { get; set; }

    public virtual DbSet<WdiTPaytmpgplusresponse> WdiTPaytmpgplusresponses { get; set; }

    public virtual DbSet<WdiTPeriodAttendanceDetail> WdiTPeriodAttendanceDetails { get; set; }

    public virtual DbSet<WdiTPeriodConfig> WdiTPeriodConfigs { get; set; }

    public virtual DbSet<WdiTPeriodSmsDetail> WdiTPeriodSmsDetails { get; set; }

    public virtual DbSet<WdiTPgatomCallBackDetail> WdiTPgatomCallBackDetails { get; set; }

    public virtual DbSet<WdiTPgfeePayment> WdiTPgfeePayments { get; set; }

    public virtual DbSet<WdiTPgfeePaymentDetail> WdiTPgfeePaymentDetails { get; set; }

    public virtual DbSet<WdiTPgfineAmountDetail> WdiTPgfineAmountDetails { get; set; }

    public virtual DbSet<WdiTPgrequest> WdiTPgrequests { get; set; }

    public virtual DbSet<WdiTPgresponse> WdiTPgresponses { get; set; }

    public virtual DbSet<WdiTPgsplFeeTransaction> WdiTPgsplFeeTransactions { get; set; }

    public virtual DbSet<WdiTPgtransaction> WdiTPgtransactions { get; set; }

    public virtual DbSet<WdiTPocketAndMedicalBalance> WdiTPocketAndMedicalBalances { get; set; }

    public virtual DbSet<WdiTPocketAndMedicalService> WdiTPocketAndMedicalServices { get; set; }

    public virtual DbSet<WdiTPrePostProcessLog> WdiTPrePostProcessLogs { get; set; }

    public virtual DbSet<WdiTPublishDateofBirthStatus> WdiTPublishDateofBirthStatuses { get; set; }

    public virtual DbSet<WdiTPurchaseOrderDetail> WdiTPurchaseOrderDetails { get; set; }

    public virtual DbSet<WdiTQuickConnectSm> WdiTQuickConnectSms { get; set; }

    public virtual DbSet<WdiTRefundDetail> WdiTRefundDetails { get; set; }

    public virtual DbSet<WdiTRegularAttendanceRawDatum> WdiTRegularAttendanceRawData { get; set; }

    public virtual DbSet<WdiTReportTemplate> WdiTReportTemplates { get; set; }

    public virtual DbSet<WdiTRoleSpecificHoliday> WdiTRoleSpecificHolidays { get; set; }

    public virtual DbSet<WdiTSchedulerDataFilter> WdiTSchedulerDataFilters { get; set; }

    public virtual DbSet<WdiTSchedulerDetail> WdiTSchedulerDetails { get; set; }

    public virtual DbSet<WdiTScholasticGrade> WdiTScholasticGrades { get; set; }

    public virtual DbSet<WdiTSchoolTimeTable> WdiTSchoolTimeTables { get; set; }

    public virtual DbSet<WdiTSchoolTimeTableOld> WdiTSchoolTimeTableOlds { get; set; }

    public virtual DbSet<WdiTSessionAttendee> WdiTSessionAttendees { get; set; }

    public virtual DbSet<WdiTSkillMapping> WdiTSkillMappings { get; set; }

    public virtual DbSet<WdiTSkillmark> WdiTSkillmarks { get; set; }

    public virtual DbSet<WdiTSmsdetail> WdiTSmsdetails { get; set; }

    public virtual DbSet<WdiTSplFeeParticular> WdiTSplFeeParticulars { get; set; }

    public virtual DbSet<WdiTSplFeeTransaction> WdiTSplFeeTransactions { get; set; }

    public virtual DbSet<WdiTStagingAccountTransaction> WdiTStagingAccountTransactions { get; set; }

    public virtual DbSet<WdiTStudentAcademicDetail> WdiTStudentAcademicDetails { get; set; }

    public virtual DbSet<WdiTStudentAcademicProfile> WdiTStudentAcademicProfiles { get; set; }

    public virtual DbSet<WdiTStudentActivity> WdiTStudentActivities { get; set; }

    public virtual DbSet<WdiTStudentBatchDetail> WdiTStudentBatchDetails { get; set; }

    public virtual DbSet<WdiTStudentCoScholasticMark> WdiTStudentCoScholasticMarks { get; set; }

    public virtual DbSet<WdiTStudentConsolidatedExamResult> WdiTStudentConsolidatedExamResults { get; set; }

    public virtual DbSet<WdiTStudentExamDetail> WdiTStudentExamDetails { get; set; }

    public virtual DbSet<WdiTStudentExamRemark> WdiTStudentExamRemarks { get; set; }

    public virtual DbSet<WdiTStudentFeeDetail> WdiTStudentFeeDetails { get; set; }

    public virtual DbSet<WdiTStudentFeeDueDetail> WdiTStudentFeeDueDetails { get; set; }

    public virtual DbSet<WdiTStudentHealthDetail> WdiTStudentHealthDetails { get; set; }

    public virtual DbSet<WdiTStudentHealthIssue> WdiTStudentHealthIssues { get; set; }

    public virtual DbSet<WdiTStudentHistoricalDet> WdiTStudentHistoricalDets { get; set; }

    public virtual DbSet<WdiTStudentLeaveTransaction> WdiTStudentLeaveTransactions { get; set; }

    public virtual DbSet<WdiTStudentLookup> WdiTStudentLookups { get; set; }

    public virtual DbSet<WdiTStudentMigrationLog> WdiTStudentMigrationLogs { get; set; }

    public virtual DbSet<WdiTStudentSecurityDepositDetail> WdiTStudentSecurityDepositDetails { get; set; }

    public virtual DbSet<WdiTStudentSemisterDetail> WdiTStudentSemisterDetails { get; set; }

    public virtual DbSet<WdiTStudentStypendAmountDetail> WdiTStudentStypendAmountDetails { get; set; }

    public virtual DbSet<WdiTSupportQuery> WdiTSupportQueries { get; set; }

    public virtual DbSet<WdiTTask> WdiTTasks { get; set; }

    public virtual DbSet<WdiTTaskSmsemailstatus> WdiTTaskSmsemailstatuses { get; set; }

    public virtual DbSet<WdiTTemplateExamMark> WdiTTemplateExamMarks { get; set; }

    public virtual DbSet<WdiTTemplateMark> WdiTTemplateMarks { get; set; }

    public virtual DbSet<WdiTTenantuserProfile> WdiTTenantuserProfiles { get; set; }

    public virtual DbSet<WdiTTenantusertemplateaccess> WdiTTenantusertemplateaccesses { get; set; }

    public virtual DbSet<WdiTTermWiseRemark> WdiTTermWiseRemarks { get; set; }

    public virtual DbSet<WdiTTicketlog> WdiTTicketlogs { get; set; }

    public virtual DbSet<WdiTTimeTableConfig> WdiTTimeTableConfigs { get; set; }

    public virtual DbSet<WdiTToolMapping> WdiTToolMappings { get; set; }

    public virtual DbSet<WdiTToolMark> WdiTToolMarks { get; set; }

    public virtual DbSet<WdiTTopStudent> WdiTTopStudents { get; set; }

    public virtual DbSet<WdiTTransactionLog> WdiTTransactionLogs { get; set; }

    public virtual DbSet<WdiTTransportLocationTracking> WdiTTransportLocationTrackings { get; set; }

    public virtual DbSet<WdiTTransportdirvermapping> WdiTTransportdirvermappings { get; set; }

    public virtual DbSet<WdiTTransportroutetran> WdiTTransportroutetrans { get; set; }

    public virtual DbSet<WdiTTransportroutevehicle> WdiTTransportroutevehicles { get; set; }

    public virtual DbSet<WdiTUserAttendanceLookUp> WdiTUserAttendanceLookUps { get; set; }

    public virtual DbSet<WdiTUserCumulativeAttendance> WdiTUserCumulativeAttendances { get; set; }

    public virtual DbSet<WdiTUserPayRollTransMaster> WdiTUserPayRollTransMasters { get; set; }

    public virtual DbSet<WdiTUserQuery> WdiTUserQueries { get; set; }

    public virtual DbSet<WdiTUserSpecificHoliday> WdiTUserSpecificHolidays { get; set; }

    public virtual DbSet<WdiTUserdoc> WdiTUserdocs { get; set; }

    public virtual DbSet<WdiTVisitorDetail> WdiTVisitorDetails { get; set; }

    public virtual DbSet<WdiTXmlpartnerTemplate> WdiTXmlpartnerTemplates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("shastrischema")
            .UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<CsaMAcademicYear>(entity =>
        {
            entity.HasKey(e => e.Csaid).HasName("PK_CSA_M_AcademicYears_1");

            entity.ToTable("CSA_M_AcademicYears");

            entity.Property(e => e.Csaid).HasColumnName("CSAID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<CsaMAdmission>(entity =>
        {
            entity.HasKey(e => e.AdmissionId);

            entity.ToTable("CSA_M_Admissions");

            entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdmType).HasComment("0 -Enquiries, 1 - Applications, 2 - Admissions, 4 - Vacancy Position ");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CsaMAttendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId);

            entity.ToTable("CSA_M_Attendance");

            entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Leave).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MdmstudentPresent).HasColumnName("MDMStudentPresent");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TypeOfUser).HasComment("0 - Student, 1 - Staff");
        });

        modelBuilder.Entity<CsaMDashBoard>(entity =>
        {
            entity.HasKey(e => e.DashboardId);

            entity.ToTable("CSA_M_DashBoard");

            entity.Property(e => e.DashboardId).HasColumnName("DashboardID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.Partnerlogincount)
                .HasDefaultValue(0)
                .HasColumnName("partnerlogincount");
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Smsbalance).HasColumnName("SMSBalance");
        });

        modelBuilder.Entity<CsaMFinance>(entity =>
        {
            entity.HasKey(e => e.FinanceId);

            entity.ToTable("CSA_M_Finance");

            entity.Property(e => e.FinanceId).HasColumnName("FinanceID");
            entity.Property(e => e.AcBalance).HasColumnType("money");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Concession).HasColumnType("money");
            entity.Property(e => e.DailyExpenses).HasColumnType("money");
            entity.Property(e => e.DailyFeeCollected).HasColumnType("money");
            entity.Property(e => e.Expenses).HasColumnType("money");
            entity.Property(e => e.FeeCollected).HasColumnType("money");
            entity.Property(e => e.FeeDue).HasColumnType("money");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalFee).HasColumnType("money");
        });

        modelBuilder.Entity<CsaMLessonPlan>(entity =>
        {
            entity.HasKey(e => e.LessonPlanId);

            entity.ToTable("CSA_M_LessonPlan");

            entity.Property(e => e.LessonPlanId).HasColumnName("LessonPlanID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassName).HasMaxLength(100);
            entity.Property(e => e.ClessonPlan)
                .HasComment("Completed Lesson Plan")
                .HasColumnName("CLessonPlan");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TlessonPlan)
                .HasComment("Target Lesson Plan")
                .HasColumnName("TLessonPlan");
        });

        modelBuilder.Entity<CsaMMcadmission>(entity =>
        {
            entity.ToTable("CSA_M_MCAdmissions");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Classname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLASSNAME");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerName).HasMaxLength(400);
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Totalallindiaseats).HasColumnName("TOTALALLINDIASEATS");
            entity.Property(e => e.Totalallindiaseatsfilled).HasColumnName("TOTALALLINDIASEATSFILLED");
            entity.Property(e => e.Totalallindiavacantseats).HasColumnName("TOTALALLINDIAVACANTSEATS");
            entity.Property(e => e.Totalseatssanctioned).HasColumnName("TOTALSEATSSANCTIONED");
            entity.Property(e => e.Totalstateseats).HasColumnName("TOTALSTATESEATS");
            entity.Property(e => e.Totalstateseatsfilled).HasColumnName("TOTALSTATESEATSFILLED");
            entity.Property(e => e.Totalstatevacantseats).HasColumnName("TOTALSTATEVACANTSEATS");
            entity.Property(e => e.Totalvacantseats).HasColumnName("TOTALVACANTSEATS");
        });

        modelBuilder.Entity<CsaMPerformance>(entity =>
        {
            entity.HasKey(e => e.PerformanceId);

            entity.ToTable("CSA_M_Performance");

            entity.Property(e => e.PerformanceId).HasColumnName("PerformanceID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassName).HasMaxLength(100);
            entity.Property(e => e.ExamName).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.PassPercent).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProcessedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CsaTVideoMetri>(entity =>
        {
            entity.ToTable("CSA_T_VideoMetris");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("watch2learn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SyncDate).HasColumnType("datetime");
            entity.Property(e => e.SyncStatus).HasComment("By Deafult false , Once Service sync done will be changed to true");
            entity.Property(e => e.ViewCount).HasComment("If viewed same video same day multiple times then increment view count else add new entry");
            entity.Property(e => e.ViewedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ViewedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<EdusyncMiscFeeTracker>(entity =>
        {
            entity.HasKey(e => e.EdsyncMftid).HasName("PK_Edusync_MiscFeeTracker_1");

            entity.ToTable("Edusync_MiscFeeTracker");

            entity.Property(e => e.EdsyncMftid).HasColumnName("EdsyncMFTId");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AppAmountPaidDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Batch).HasMaxLength(200);
            entity.Property(e => e.Branch).HasMaxLength(200);
            entity.Property(e => e.ConcessionAmount).HasColumnType("money");
            entity.Property(e => e.ConcessionDetails)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(200);
            entity.Property(e => e.FeeAmount).HasColumnType("money");
            entity.Property(e => e.FeeItemDetails).HasColumnType("xml");
            entity.Property(e => e.FeePaymentStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MiscFeeReceiptNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Online");
            entity.Property(e => e.PaymentReferenceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PgTransactionId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(100);
            entity.Property(e => e.Programme).HasMaxLength(200);
            entity.Property(e => e.Rollno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName).HasMaxLength(200);
            entity.Property(e => e.TransAmount).HasColumnType("money");
        });

        modelBuilder.Entity<EmployeeAttendance>(entity =>
        {
            entity.ToTable("EmployeeAttendance");

            entity.HasIndex(e => new { e.EnrollNo, e.MachineNo, e.Date, e.DutyOn }, "EA_23SEP2019001");

            entity.HasIndex(e => new { e.UserId, e.AcademicYearId, e.Date }, "NCI_EA001");

            entity.HasIndex(e => new { e.UserId, e.Date, e.AcademicYearId, e.EnrollNo }, "idx_temp_useriddateEMP");

            entity.HasIndex(e => new { e.EnrollNo, e.MachineNo, e.Date, e.DutyOn }, "missing_index_1607513_1607512");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AttdType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("H");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DutyOff)
                .HasMaxLength(40)
                .HasColumnName("Duty_Off");
            entity.Property(e => e.DutyOffDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DutyOn)
                .HasMaxLength(40)
                .HasColumnName("Duty_On");
            entity.Property(e => e.DutyOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InOutTime)
                .HasMaxLength(40)
                .HasColumnName("In_Out_Time");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.OtHours).HasColumnName("OT_Hours");
            entity.Property(e => e.OtOff)
                .HasMaxLength(40)
                .HasColumnName("OT_Off");
            entity.Property(e => e.OtOn)
                .HasMaxLength(40)
                .HasColumnName("OT_On");
            entity.Property(e => e.Otdate)
                .HasColumnType("datetime")
                .HasColumnName("OTDate");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .HasDefaultValue("FULLDAY");
            entity.Property(e => e.Status).HasDefaultValue(false);
            entity.Property(e => e.TotalHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<EsyncApprovalHierarchyMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_ApprovalHierarchyMaster");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");
            entity.Property(e => e.Type).HasMaxLength(80);
            entity.Property(e => e.WfahconfigId)
                .ValueGeneratedOnAdd()
                .HasColumnName("WFAHConfigID");
            entity.Property(e => e.Wfname)
                .HasMaxLength(80)
                .HasColumnName("WFName");
        });

        modelBuilder.Entity<EsyncApprovalHierarchyMasterDeatil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_ApprovalHierarchyMasterDeatils");

            entity.Property(e => e.AuthorisedPerson).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HierarchyName).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.WfahconfigId).HasColumnName("WFAHConfigID");
            entity.Property(e => e.WfahmasterId)
                .ValueGeneratedOnAdd()
                .HasColumnName("WFAHMasterID");
        });

        modelBuilder.Entity<EsyncCampaignMaster>(entity =>
        {
            entity.HasKey(e => e.CampaignId).HasName("PK__ESYNC_Ca__3F5E8D798210D28B");

            entity.ToTable("ESYNC_CampaignMaster");

            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.CampaignName).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Pending");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasDefaultValue("FEEDBACK");
        });

        modelBuilder.Entity<EsyncExamTemplateConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESYNC_Ex__3213E83F24EAE7C0");

            entity.ToTable("ESYNC_ExamTemplateConfig");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExamTemplatename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExaminationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsExamorTemplate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NoRankOnAbsent)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("NA");
        });

        modelBuilder.Entity<EsyncExamTemplateMaster>(entity =>
        {
            entity.HasKey(e => e.ExamTemplateId).HasName("PK__ESYNC_Ex__C46FA893E8AF3F79");

            entity.ToTable("ESYNC_ExamTemplateMaster");

            entity.Property(e => e.Assignmentmarks).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Assignmentrule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.BoardType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DisplayOriginalMarksSubIds)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExamTemplatename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Externalmarks).HasColumnType("decimal(15, 1)");
            entity.Property(e => e.Externalrule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.Internalmarks).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Internalrule)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(15, 1)");
        });

        modelBuilder.Entity<EsyncFeedBackMapping>(entity =>
        {
            entity.HasKey(e => e.FbmappingId);

            entity.ToTable("ESYNC_FeedBackMappings");

            entity.Property(e => e.FbmappingId).HasColumnName("FBMappingId");
            entity.Property(e => e.CampaignId)
                .HasDefaultValue(-1L)
                .HasColumnName("CampaignID");
            entity.Property(e => e.FbqueryId).HasColumnName("FBQueryId");
            entity.Property(e => e.RatingScaleValue).HasDefaultValue((short)5);
        });

        modelBuilder.Entity<EsyncFeedBackQuery>(entity =>
        {
            entity.HasKey(e => e.FbqueryId);

            entity.ToTable("ESYNC_FeedBackQueries");

            entity.Property(e => e.FbqueryId).HasColumnName("FBQueryId");
            entity.Property(e => e.FbqueryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FBQueryCode");
            entity.Property(e => e.FbqueryText)
                .IsUnicode(false)
                .HasColumnName("FBQueryText");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<EsyncFeedBackUserRating>(entity =>
        {
            entity.HasKey(e => e.FbuserRatingId);

            entity.ToTable("ESYNC_FeedBackUserRatings");

            entity.Property(e => e.FbuserRatingId).HasColumnName("FBUserRatingId");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FacultyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FbmappingId).HasColumnName("FBMappingId");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RatingResponse).HasDefaultValue((short)5);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EsyncHierarchyType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESYNC_Hi__3213E83F703F3473");

            entity.ToTable("ESYNC_HierarchyTypes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EsyncInventoryworkflowMaster>(entity =>
        {
            entity.HasKey(e => e.InvWfmid).HasName("PK__ESYNC_In__8F9C6C0D753EA03C");

            entity.ToTable("ESYNC_InventoryworkflowMaster");

            entity.Property(e => e.InvWfmid).HasColumnName("InvWFMId");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InvType)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RefMasterId)
                .HasMaxLength(80)
                .HasColumnName("RefMasterID");
            entity.Property(e => e.RefWorkflowTransId).HasColumnName("RefWorkflowTransID");
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<EsyncInventoryworkflowTransaction>(entity =>
        {
            entity.HasKey(e => e.InvWfTransId).HasName("PK__ESYNC_In__05F0D0B55B551D12");

            entity.ToTable("ESYNC_InventoryworkflowTransactions");

            entity.Property(e => e.InvWfTransId).HasColumnName("InvWfTransID");
            entity.Property(e => e.AdditionalExp).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.Costprice).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExpCost).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.Gst)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("GST");
            entity.Property(e => e.InvWfmid).HasColumnName("InvWFMId");
            entity.Property(e => e.ItemId)
                .HasMaxLength(80)
                .HasColumnName("ItemID");
            entity.Property(e => e.ManufacturingDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Mrpprice)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("MRPPrice");
            entity.Property(e => e.RequestedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Surcharge).HasMaxLength(100);
            entity.Property(e => e.Units)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<EsyncMApplregistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_M_APPLRegistrations");

            entity.Property(e => e.AdmissionYear).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId).HasMaxLength(100);
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("FName");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .HasColumnName("LName");
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<EsyncMAppluser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_M_APPLUSERS");

            entity.Property(e => e.ApplRefId).HasColumnName("ApplRefID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsFirstLogin).HasDefaultValue(true);
            entity.Property(e => e.LastVisit).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Permissions).HasMaxLength(40);
            entity.Property(e => e.Shahs)
                .HasMaxLength(400)
                .HasColumnName("SHAHS");
            entity.Property(e => e.Sslat)
                .HasMaxLength(100)
                .HasColumnName("SSLAT");
            entity.Property(e => e.SuserType)
                .HasMaxLength(200)
                .HasColumnName("SUserType");
            entity.Property(e => e.SusertypeId).HasColumnName("SUsertypeId");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<EsyncMCertificatesmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_M_CERTIFICATESMASTER");

            entity.Property(e => e.CertificateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CertificateID");
            entity.Property(e => e.CertificateName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.Reprintable).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<EsyncMRmsdocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__ESYNC_M___1ABEEF6FBA3AC914");

            entity.ToTable("ESYNC_M_RMSDocuments");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.DocumentName).HasMaxLength(150);
            entity.Property(e => e.IsActive).HasDefaultValue((byte)1);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EsyncMRmsnotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESYNC_M___3214EC27D1A46F39");

            entity.ToTable("ESYNC_M_RMSNotifications");

            entity.HasIndex(e => e.NotificationId, "UQ__ESYNC_M___20CF2E33365D1163").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApplicationAmount).HasColumnType("money");
            entity.Property(e => e.ApplicationEnddate).HasColumnType("datetime");
            entity.Property(e => e.ApplicationStartDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastDateforApply).HasColumnType("datetime");
            entity.Property(e => e.LastDateforModifications).HasColumnType("datetime");
            entity.Property(e => e.LastDateforPayment).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NotificationID");
            entity.Property(e => e.NotificationMode)
                .HasMaxLength(100)
                .HasDefaultValue("Offline");
            entity.Property(e => e.NotificationNo).HasMaxLength(200);
            entity.Property(e => e.NotificationStage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("TEST");
            entity.Property(e => e.NotificationStatus)
                .HasMaxLength(100)
                .HasDefaultValue("Open");
            entity.Property(e => e.ReleasedDate).HasColumnType("datetime");
            entity.Property(e => e.ResultsDate).HasColumnType("datetime");
            entity.Property(e => e.ResultsDynamicUrl)
                .HasMaxLength(250)
                .HasColumnName("ResultsDynamicURL");
            entity.Property(e => e.ResultsStaticUrl)
                .HasMaxLength(250)
                .HasColumnName("ResultsStaticURL");
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.Type).HasDefaultValue(1);
            entity.Property(e => e.WebNoteUrl)
                .HasMaxLength(250)
                .HasColumnName("WebNoteURL");
        });

        modelBuilder.Entity<EsyncMRmsuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESYNC_M___3214EC2796A4779A");

            entity.ToTable("ESYNC_M_RMSUSERS");

            entity.HasIndex(e => e.RmsuserId, "UQ__ESYNC_M___529CEB1930306BC1").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("EmailID");
            entity.Property(e => e.IsFirstLogin).HasDefaultValue(true);
            entity.Property(e => e.LastVisit).HasColumnType("datetime");
            entity.Property(e => e.MobileNo).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.Shahs)
                .HasMaxLength(400)
                .HasColumnName("SHAHS");
            entity.Property(e => e.Sslat)
                .HasMaxLength(100)
                .HasColumnName("SSLAT");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Active");
            entity.Property(e => e.SuserType)
                .HasMaxLength(200)
                .HasColumnName("SUserType");
            entity.Property(e => e.SusertypeId)
                .HasDefaultValue(-1)
                .HasColumnName("SUsertypeId");
        });

        modelBuilder.Entity<EsyncMSwrhallTicketDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_M_SWRHallTicketData");

            entity.Property(e => e.Caste)
                .HasMaxLength(200)
                .HasColumnName("CASTE");
            entity.Property(e => e.Class)
                .HasMaxLength(200)
                .HasColumnName("CLASS");
            entity.Property(e => e.District)
                .HasMaxLength(200)
                .HasColumnName("DISTRICT");
            entity.Property(e => e.Gender)
                .HasMaxLength(200)
                .HasColumnName("GENDER");
            entity.Property(e => e.Hallticket)
                .HasMaxLength(200)
                .HasColumnName("HALLTICKET");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("NAME");
            entity.Property(e => e.Sc)
                .HasMaxLength(200)
                .HasColumnName("SC");
            entity.Property(e => e.Schoolname)
                .HasMaxLength(200)
                .HasColumnName("SCHOOLNAME");
            entity.Property(e => e.Section)
                .HasMaxLength(200)
                .HasColumnName("SECTION");
            entity.Property(e => e.Zone)
                .HasMaxLength(200)
                .HasColumnName("ZONE");
        });

        modelBuilder.Entity<EsyncMSwruser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_M_SWRUsers");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.SwruserId)
                .HasMaxLength(200)
                .HasColumnName("SWRUserID");
        });

        modelBuilder.Entity<EsyncPayrollTemplate>(entity =>
        {
            entity.HasKey(e => e.ProllTemplateId);

            entity.ToTable("ESYNC_PayrollTemplates");

            entity.Property(e => e.ProllTemplateId).HasColumnName("PRollTemplateId");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("EDUSYNC");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasDefaultValue(-1L);
            entity.Property(e => e.ProllTemplateName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRollTemplateName");
        });

        modelBuilder.Entity<EsyncShortTermJobApplicant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_shastrischema.ShortTermJobApplicants");

            entity.ToTable("ESYNC_ShortTermJobApplicants");

            entity.Property(e => e.AdvertisementNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CandidateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComputedColumnSql("('STERMEMPAPPL'+right('00000000'+CONVERT([varchar](8),[ID]),(8)))", true)
                .HasColumnName("CandidateID");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("eduSync");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JobPostingName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EsyncStudentFeeDueTaxdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Esync_StudentFeeDueTaxdetails");

            entity.Property(e => e.ActualAmount).HasColumnType("money");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsPrevsPresentFuture).HasColumnName("isPrevsPresentFuture");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDetailsId).HasColumnName("PaymentDetailsID");
            entity.Property(e => e.RemainingAmount).HasColumnType("money");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TaxReceiptNo).HasMaxLength(150);
        });

        modelBuilder.Entity<EsyncStudentInstantFeeTaxdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Esync_StudentInstantFeeTaxdetails");

            entity.Property(e => e.ActualAmount).HasColumnType("money");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FeeId).HasColumnName("FeeID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsPrevsPresentFuture).HasColumnName("isPrevsPresentFuture");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentTransId).HasColumnName("PaymentTransID");
            entity.Property(e => e.RemainingAmount).HasColumnType("money");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
        });

        modelBuilder.Entity<EsyncTAppldoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_APPLDOCS");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentFileName).HasMaxLength(80);
            entity.Property(e => e.DocumentRefNo).HasMaxLength(80);
            entity.Property(e => e.DocumentType).HasMaxLength(50);
            entity.Property(e => e.FileType)
                .HasMaxLength(80)
                .HasDefaultValue("Jpg");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.UserDocId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserId)
                .HasMaxLength(80)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(40);
        });

        modelBuilder.Entity<EsyncTCertificatestransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_CERTIFICATESTRANSACTIONS");

            entity.Property(e => e.AuthorisedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.AuthorisedOn).HasColumnType("datetime");
            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CertificateNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FeeCollectedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.FeeRefNumber)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OtherDetails).HasColumnType("xml");
            entity.Property(e => e.PrintedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.PrintedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Reprintable).HasDefaultValue((byte)1);
            entity.Property(e => e.Status).HasDefaultValue((byte)1);
            entity.Property(e => e.TransId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TransID");
            entity.Property(e => e.UcuniqueCertificateNumber)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UCUniqueCertificateNumber");
            entity.Property(e => e.UserId)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<EsyncTRmsapplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESYNC_T___3214EC2740948BD3");

            entity.ToTable("ESYNC_T_RMSApplications");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.AcknowledgementNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationFeeAmount).HasColumnType("money");
            entity.Property(e => e.ApplicationFeeStatus).HasMaxLength(100);
            entity.Property(e => e.ApplicationFeereceiptNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationUniqueId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ApplicationUniqueID");
            entity.Property(e => e.AppliedPost).HasMaxLength(150);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(150);
            entity.Property(e => e.ExtraFields).HasColumnType("xml");
            entity.Property(e => e.JobId)
                .HasMaxLength(150)
                .HasColumnName("JobID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NotificationID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RecordStatus).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
        });

        modelBuilder.Entity<EsyncTRmsapplicationConcession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSApplicationConcessions");

            entity.Property(e => e.ActualAmount).HasColumnType("money");
            entity.Property(e => e.ApplicationNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ConcessionAmount).HasColumnType("money");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateofPayment).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).IsUnicode(false);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EsyncTRmsapplicationPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSApplicationPayments");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ApplicationNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateofPayment).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionRemarks).IsUnicode(false);
        });

        modelBuilder.Entity<EsyncTRmscandidateContactDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSCandidateContactDetails");

            entity.Property(e => e.AlternativeEmailId)
                .HasMaxLength(200)
                .HasColumnName("AlternativeEmailID");
            entity.Property(e => e.AlternativeMobileNo).HasMaxLength(100);
            entity.Property(e => e.CommunicationRequiredFor).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(200)
                .HasColumnName("EmailID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LandlineNo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(200);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PermanentCity).HasMaxLength(200);
            entity.Property(e => e.PermanentHouseNo).HasMaxLength(200);
            entity.Property(e => e.PermanentPinCode).HasMaxLength(200);
            entity.Property(e => e.PermanentPo)
                .HasMaxLength(200)
                .HasColumnName("PermanentPO");
            entity.Property(e => e.PermanentState).HasMaxLength(200);
            entity.Property(e => e.PermanentStreetNo).HasMaxLength(200);
            entity.Property(e => e.PermanentVia).HasMaxLength(200);
            entity.Property(e => e.PresentCity).HasMaxLength(200);
            entity.Property(e => e.PresentHouseNo).HasMaxLength(200);
            entity.Property(e => e.PresentPinCode).HasMaxLength(100);
            entity.Property(e => e.PresentPo)
                .HasMaxLength(200)
                .HasColumnName("PresentPO");
            entity.Property(e => e.PresentState).HasMaxLength(200);
            entity.Property(e => e.PresentStreetNo).HasMaxLength(200);
            entity.Property(e => e.PresentVia).HasMaxLength(200);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
        });

        modelBuilder.Entity<EsyncTRmscandidateCouncilReg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSCandidateCouncilReg");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Qualification).HasMaxLength(150);
            entity.Property(e => e.RegAuthorityUrl)
                .HasMaxLength(500)
                .HasColumnName("RegAuthorityURL");
            entity.Property(e => e.RegComments).HasMaxLength(500);
            entity.Property(e => e.RegNo).HasMaxLength(100);
            entity.Property(e => e.RegState).HasMaxLength(250);
            entity.Property(e => e.RegValidUpto).HasColumnType("datetime");
            entity.Property(e => e.RegVerificationUrl)
                .HasMaxLength(500)
                .HasColumnName("RegVerificationURL");
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
        });

        modelBuilder.Entity<EsyncTRmscandidateDeatil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESYNC_T___3214EC275B5D1CAD");

            entity.ToTable("ESYNC_T_RMSCandidateDeatils");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AadharNo).HasMaxLength(100);
            entity.Property(e => e.Category).HasMaxLength(150);
            entity.Property(e => e.CentrolGovtCivilDoj)
                .HasColumnType("datetime")
                .HasColumnName("CentrolGovtCivilDOJ");
            entity.Property(e => e.CentrolGovtCivilDor)
                .HasColumnType("datetime")
                .HasColumnName("CentrolGovtCivilDOR");
            entity.Property(e => e.CentrolGovtCivilPost).HasMaxLength(100);
            entity.Property(e => e.CentrolGovtCivilTotalYears).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DefenceForeignHostilities).HasMaxLength(100);
            entity.Property(e => e.DefenceHostilitiesInfo).HasMaxLength(500);
            entity.Property(e => e.DisabilityCategory).HasMaxLength(100);
            entity.Property(e => e.DisabilityPercentage).HasMaxLength(100);
            entity.Property(e => e.DisabilityPerson).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EcoadnSscototalYears)
                .HasMaxLength(50)
                .HasColumnName("ECOadnSSCOTotalYears");
            entity.Property(e => e.EcoandSscoassignment)
                .HasMaxLength(100)
                .HasColumnName("ECOandSSCOAssignment");
            entity.Property(e => e.EcoandSscodoj)
                .HasColumnType("datetime")
                .HasColumnName("ECOandSSCODOJ");
            entity.Property(e => e.EcoandSscodor)
                .HasColumnType("datetime")
                .HasColumnName("ECOandSSCODOR");
            entity.Property(e => e.ExServiceDoj)
                .HasColumnType("datetime")
                .HasColumnName("ExServiceDOJ");
            entity.Property(e => e.ExServiceDor)
                .HasColumnType("datetime")
                .HasColumnName("ExServiceDOR");
            entity.Property(e => e.ExServiceMan).HasMaxLength(100);
            entity.Property(e => e.ExServiceTotalYears).HasMaxLength(100);
            entity.Property(e => e.FatherName).HasMaxLength(150);
            entity.Property(e => e.GovPsuorganisationName)
                .HasMaxLength(200)
                .HasColumnName("GovPSUOrganisationName");
            entity.Property(e => e.GovPsuworkingStatus)
                .HasMaxLength(100)
                .HasColumnName("GovPSUWorkingStatus");
            entity.Property(e => e.GovtServant).HasMaxLength(100);
            entity.Property(e => e.GovtServantDoj)
                .HasColumnType("datetime")
                .HasColumnName("GovtServantDOJ");
            entity.Property(e => e.GovtServantDor)
                .HasColumnType("datetime")
                .HasColumnName("GovtServantDOR");
            entity.Property(e => e.GovtServantOrganisation).HasMaxLength(150);
            entity.Property(e => e.GovtServantServiceYears).HasMaxLength(50);
            entity.Property(e => e.IndianCitizen).HasMaxLength(100);
            entity.Property(e => e.JandKdomiciled)
                .HasMaxLength(100)
                .HasColumnName("JandKDomiciled");
            entity.Property(e => e.MaritalStatus).HasMaxLength(100);
            entity.Property(e => e.MobileNo).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MotherName).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.SpouceName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasDefaultValue("Active");
            entity.Property(e => e.SubCategory).HasMaxLength(100);
        });

        modelBuilder.Entity<EsyncTRmscandidateDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESYNC_T___3214EC27B6D20E64");

            entity.ToTable("ESYNC_T_RMSCandidateDocuments");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentFileName).HasMaxLength(150);
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.DocumentRefNo).HasMaxLength(150);
            entity.Property(e => e.FileType)
                .HasMaxLength(80)
                .HasDefaultValue("Jpg");
            entity.Property(e => e.IsActive).HasDefaultValue((byte)1);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(140)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
        });

        modelBuilder.Entity<EsyncTRmscandidateExperienceDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSCandidateExperienceDetails");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateofJoining).HasColumnType("datetime");
            entity.Property(e => e.Dateofleaving).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.Experience).HasMaxLength(100);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsCurrentJob).HasColumnName("isCurrentJob");
            entity.Property(e => e.JobType).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(250);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MonthlyIncome).HasMaxLength(80);
            entity.Property(e => e.NatureOfWork).HasMaxLength(250);
            entity.Property(e => e.OrganisationAddress).HasMaxLength(500);
            entity.Property(e => e.OrganisationName).HasMaxLength(500);
            entity.Property(e => e.Reasonforleaving).HasMaxLength(400);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
        });

        modelBuilder.Entity<EsyncTRmscandidateJobProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSCandidateJobProfile");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Position).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.Status)
                .HasMaxLength(80)
                .HasDefaultValue("Active");
        });

        modelBuilder.Entity<EsyncTRmscandidateOtherDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSCandidateOtherDetails");

            entity.Property(e => e.AwardorFellowships1).HasMaxLength(250);
            entity.Property(e => e.AwardorFellowships2).HasMaxLength(250);
            entity.Property(e => e.AwardorFellowships3).HasMaxLength(250);
            entity.Property(e => e.AwardorFellowships4).HasMaxLength(250);
            entity.Property(e => e.AwardorFellowships5).HasMaxLength(250);
            entity.Property(e => e.AwardorFellowships6).HasMaxLength(250);
            entity.Property(e => e.CategoryType).HasMaxLength(200);
            entity.Property(e => e.CommunityProgram1).HasMaxLength(250);
            entity.Property(e => e.CommunityProgram2).HasMaxLength(250);
            entity.Property(e => e.CommunityProgram3).HasMaxLength(250);
            entity.Property(e => e.CommunityProgram4).HasMaxLength(250);
            entity.Property(e => e.CommunityProgram5).HasMaxLength(250);
            entity.Property(e => e.CommunityProgram6).HasMaxLength(250);
            entity.Property(e => e.Country1fromdate).HasMaxLength(100);
            entity.Property(e => e.Country1todate).HasMaxLength(100);
            entity.Property(e => e.Country2fromdate).HasMaxLength(100);
            entity.Property(e => e.Country2todate).HasMaxLength(100);
            entity.Property(e => e.Country3fromdate).HasMaxLength(100);
            entity.Property(e => e.Country3todate).HasMaxLength(100);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FellowshipAward).HasMaxLength(200);
            entity.Property(e => e.FellowshipExmQualifiedDate).HasMaxLength(100);
            entity.Property(e => e.FellowshipFundAgency).HasMaxLength(250);
            entity.Property(e => e.FellowshipTenable).HasMaxLength(50);
            entity.Property(e => e.FellowshipValidityDate).HasMaxLength(600);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InternshipCompletion).HasMaxLength(200);
            entity.Property(e => e.InternshipFromDate).HasMaxLength(100);
            entity.Property(e => e.InternshipToDate).HasMaxLength(600);
            entity.Property(e => e.Language1).HasMaxLength(100);
            entity.Property(e => e.Language2).HasMaxLength(100);
            entity.Property(e => e.Language3).HasMaxLength(100);
            entity.Property(e => e.MembershipEditorialBoard1).HasMaxLength(250);
            entity.Property(e => e.MembershipEditorialBoard2).HasMaxLength(250);
            entity.Property(e => e.MembershipEditorialBoard3).HasMaxLength(250);
            entity.Property(e => e.MembershipEditorialBoard4).HasMaxLength(250);
            entity.Property(e => e.MembershipEditorialBoard5).HasMaxLength(250);
            entity.Property(e => e.MembershipEditorialBoard6).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectAmount1).HasMaxLength(100);
            entity.Property(e => e.ProjectAmount2).HasMaxLength(100);
            entity.Property(e => e.ProjectAmount3).HasMaxLength(100);
            entity.Property(e => e.ProjectAmount4).HasMaxLength(100);
            entity.Property(e => e.ProjectAmount5).HasMaxLength(100);
            entity.Property(e => e.ProjectSourceFunding1).HasMaxLength(250);
            entity.Property(e => e.ProjectSourceFunding2).HasMaxLength(250);
            entity.Property(e => e.ProjectSourceFunding3).HasMaxLength(250);
            entity.Property(e => e.ProjectSourceFunding4).HasMaxLength(250);
            entity.Property(e => e.ProjectSourceFunding5).HasMaxLength(250);
            entity.Property(e => e.ProjectYear1).HasMaxLength(100);
            entity.Property(e => e.ProjectYear2).HasMaxLength(100);
            entity.Property(e => e.ProjectYear3).HasMaxLength(100);
            entity.Property(e => e.ProjectYear4).HasMaxLength(100);
            entity.Property(e => e.ProjectYear5).HasMaxLength(100);
            entity.Property(e => e.Purpose1).HasMaxLength(200);
            entity.Property(e => e.Purpose2).HasMaxLength(200);
            entity.Property(e => e.Purpose3).HasMaxLength(200);
            entity.Property(e => e.RefAddress1).HasMaxLength(200);
            entity.Property(e => e.RefAddress2).HasMaxLength(200);
            entity.Property(e => e.RefDesignation1).HasMaxLength(100);
            entity.Property(e => e.RefDesignation2).HasMaxLength(100);
            entity.Property(e => e.RefEmail1).HasMaxLength(200);
            entity.Property(e => e.RefEmail2).HasMaxLength(200);
            entity.Property(e => e.RefInstituition1).HasMaxLength(200);
            entity.Property(e => e.RefInstituition2).HasMaxLength(200);
            entity.Property(e => e.RefMobile1).HasMaxLength(100);
            entity.Property(e => e.RefMobile2).HasMaxLength(100);
            entity.Property(e => e.RefereeName1).HasMaxLength(100);
            entity.Property(e => e.RefereeName2).HasMaxLength(100);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.VistedCountry1).HasMaxLength(100);
            entity.Property(e => e.VistedCountry2).HasMaxLength(100);
            entity.Property(e => e.VistedCountry3).HasMaxLength(100);
        });

        modelBuilder.Entity<EsyncTRmscandidateProfileLookup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSCandidateProfileLookup");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.Status).HasMaxLength(80);
        });

        modelBuilder.Entity<EsyncTRmscandidatePublication>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSCandidatePublications");

            entity.Property(e => e.ChaptersInBooks).HasMaxLength(500);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EditedTextBookName).HasMaxLength(500);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IndexInternational).HasMaxLength(250);
            entity.Property(e => e.IndexNational).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.PublicationType).HasMaxLength(100);
            entity.Property(e => e.PublicationUrl)
                .HasMaxLength(500)
                .HasColumnName("PublicationURL");
            entity.Property(e => e.PublicationWebsite).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.TextBookName).HasMaxLength(500);
        });

        modelBuilder.Entity<EsyncTRmscandidateQualificationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSCandidateQualificationDetails");

            entity.Property(e => e.BoardorUniversity).HasMaxLength(150);
            entity.Property(e => e.Cgpa)
                .HasMaxLength(80)
                .HasColumnName("CGPA");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InstituitionAddress).HasMaxLength(250);
            entity.Property(e => e.InstituitionName).HasMaxLength(250);
            entity.Property(e => e.ModifiedBy).HasMaxLength(250);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NoofAttempts).HasMaxLength(20);
            entity.Property(e => e.Passedyear).HasMaxLength(100);
            entity.Property(e => e.Percentage).HasMaxLength(50);
            entity.Property(e => e.QualificationTitle).HasMaxLength(80);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.Speciality).HasMaxLength(150);
        });

        modelBuilder.Entity<EsyncTRmsjobPosition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSJobPositions");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FriendlyName).HasMaxLength(150);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MandatoryFeilds).HasMaxLength(1000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PositionName).HasMaxLength(150);
            entity.Property(e => e.Remarks).HasMaxLength(250);
        });

        modelBuilder.Entity<EsyncTRmsnotificationDet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSNotificationDet");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CategoryBc).HasColumnName("CategoryBC");
            entity.Property(e => e.CategoryEws).HasColumnName("CategoryEWS");
            entity.Property(e => e.CategoryObc).HasColumnName("CategoryOBC");
            entity.Property(e => e.CategorySc).HasColumnName("CategorySC");
            entity.Property(e => e.CategorySt).HasColumnName("CategoryST");
            entity.Property(e => e.CategoryType).HasMaxLength(500);
            entity.Property(e => e.CategoryUr).HasColumnName("CategoryUR");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DeptName).HasMaxLength(200);
            entity.Property(e => e.DocFileName).HasMaxLength(150);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.JobId)
                .HasMaxLength(150)
                .HasColumnName("JobID");
            entity.Property(e => e.MinimumQulification).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationId)
                .HasMaxLength(150)
                .HasColumnName("NotificationID");
            entity.Property(e => e.PositionId).HasColumnName("PositionID");
            entity.Property(e => e.PostJob).HasMaxLength(150);
            entity.Property(e => e.PostTitle).HasMaxLength(250);
        });

        modelBuilder.Entity<EsyncTRmsnotificationResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSNotificationResults");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NotificationID");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.Result).HasMaxLength(50);
            entity.Property(e => e.ResultInfo).HasColumnType("xml");
            entity.Property(e => e.ResultStatus).HasMaxLength(60);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
        });

        modelBuilder.Entity<EsyncTRmspgapplicationPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_RMSPGApplicationPayments");

            entity.Property(e => e.ActualGeneratedReceipt)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ApplicationNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateofPayment).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PgreceiptNo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PGReceiptNo");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RmsuserId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RMSUserID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransactionRemarks).IsUnicode(false);
        });

        modelBuilder.Entity<EsyncTSwrpayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_SWRPayments");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BankName).HasMaxLength(80);
            entity.Property(e => e.BranchName).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateofPayment).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(80)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.ModeofPayment).HasMaxLength(80);
            entity.Property(e => e.ReceiptNo).HasMaxLength(80);
            entity.Property(e => e.ReferenceNo).HasMaxLength(200);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(80);
            entity.Property(e => e.SwruserId)
                .HasMaxLength(200)
                .HasColumnName("SWRUserID");
            entity.Property(e => e.TransactionRemarks).HasMaxLength(500);
        });

        modelBuilder.Entity<EsyncTSwrpgpayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_SWRPGPayments");

            entity.Property(e => e.ActualGeneratedReceipt).HasMaxLength(80);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BankName).HasMaxLength(80);
            entity.Property(e => e.BranchName).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateofPayment).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(80)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.ModeofPayment).HasMaxLength(80);
            entity.Property(e => e.PgreceiptNo)
                .HasMaxLength(80)
                .HasColumnName("PGReceiptNo");
            entity.Property(e => e.ReferenceNo).HasMaxLength(200);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(80);
            entity.Property(e => e.SwruserId)
                .HasMaxLength(200)
                .HasColumnName("SWRUserID");
            entity.Property(e => e.TransactionRemarks).HasMaxLength(500);
        });

        modelBuilder.Entity<EsyncTSwrstudentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_T_SWRStudentDetails");

            entity.Property(e => e.Caste).HasMaxLength(50);
            entity.Property(e => e.CasteCertficateNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(180);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.GroupPref1).HasMaxLength(80);
            entity.Property(e => e.GroupPref2).HasMaxLength(80);
            entity.Property(e => e.GroupPref3).HasMaxLength(80);
            entity.Property(e => e.GroupPref4).HasMaxLength(80);
            entity.Property(e => e.GroupPref5).HasMaxLength(80);
            entity.Property(e => e.GroupPref6).HasMaxLength(80);
            entity.Property(e => e.HallticketNo).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IncomeCertificateNo).HasMaxLength(50);
            entity.Property(e => e.Mandal).HasMaxLength(180);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Orphon).HasMaxLength(50);
            entity.Property(e => e.Preference1).HasMaxLength(80);
            entity.Property(e => e.Preference2).HasMaxLength(80);
            entity.Property(e => e.Pwd)
                .HasMaxLength(50)
                .HasColumnName("PWD");
            entity.Property(e => e.SainikAdmission).HasMaxLength(50);
            entity.Property(e => e.SocialWelfare).HasMaxLength(50);
            entity.Property(e => e.SwruserId)
                .HasMaxLength(200)
                .HasColumnName("SWRUserID");
            entity.Property(e => e.Village).HasMaxLength(180);
        });

        modelBuilder.Entity<EsyncTaxConfigurationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Esync_TaxConfigurationDetails");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Gstno)
                .HasMaxLength(100)
                .HasColumnName("GSTNo");
            entity.Property(e => e.IsPercentage).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.TaxApplicableforMinAmount).HasColumnType("money");
            entity.Property(e => e.TaxConfigMid).HasColumnName("TaxConfigMID");
            entity.Property(e => e.TaxId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TaxID");
            entity.Property(e => e.TaxName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TaxPercentage).HasColumnType("decimal(15, 2)");
        });

        modelBuilder.Entity<EsyncTaxConfigurationMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Esync_TaxConfigurationMaster");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FriendlyName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxConfigMid)
                .ValueGeneratedOnAdd()
                .HasColumnName("TaxConfigMID");
            entity.Property(e => e.TaxConfigName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EsyncUserHierarchyTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESYNC_UserHierarchyTransactions");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Actionfor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Pending");
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ProcessedBy).HasMaxLength(80);
            entity.Property(e => e.RefTransId).HasColumnName("RefTransID");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.Status).HasMaxLength(80);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(80)
                .HasColumnName("UserID");
            entity.Property(e => e.WfahconfigId).HasColumnName("WFAHConfigID");
            entity.Property(e => e.WfahmasterId).HasColumnName("WFAHMasterID");
            entity.Property(e => e.WorkFlowTransId)
                .ValueGeneratedOnAdd()
                .HasColumnName("WorkFlowTransID");
        });

        modelBuilder.Entity<FormTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PK__FormTemp__F87ADD2754DA851E");

            entity.Property(e => e.TemplateName).HasMaxLength(100);
        });

        modelBuilder.Entity<GpsTLocationstatus>(entity =>
        {
            entity.ToTable("GPS_T_LOCATIONSTATUS");

            entity.Property(e => e.Dropstatus).HasColumnName("dropstatus");
            entity.Property(e => e.Pickupstatus).HasColumnName("pickupstatus");
            entity.Property(e => e.Tripdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("tripdate");
        });

        modelBuilder.Entity<ImAsmassetDet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IM_ASMAs__3214EC27A9CF829C");

            entity.ToTable("IM_ASMAssetDet");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.AssetDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AssetId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssetID");
            entity.Property(e => e.AssetLocation)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AssetName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.AssetStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizedPerson)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepreciationFrequency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepreciationPercentage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grnid).HasColumnName("GRNID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.ProductCatgoryId).HasColumnName("ProductCatgoryID");
            entity.Property(e => e.ProductSelfLifeExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.ProductType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseType)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SerialNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecifiactionValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SpecificationName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WarrantyExpiryDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImAsmassetProductDet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IM_ASMAs__3214EC27888D63F1");

            entity.ToTable("IM_ASMAssetProductDet");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Manufacture)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ProductCatgoryId).HasColumnName("ProductCatgoryID");
            entity.Property(e => e.ProductId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Active");
        });

        modelBuilder.Entity<ImAsmassetTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IM_ASMAs__3214EC27C14EA4B5");

            entity.ToTable("IM_ASMAssetTransactions");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AssetId)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("AssetID");
            entity.Property(e => e.AssetTransId)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("AssetTransID");
            entity.Property(e => e.AssignedTo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ImBillingOrder>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK__IM_Billi__11F2FC6A29D06341");

            entity.ToTable("IM_BillingOrders");

            entity.Property(e => e.BillId).HasMaxLength(80);
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(80)
                .HasDefaultValue("0");
            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.BankCharges)
                .HasMaxLength(80)
                .HasDefaultValue("0");
            entity.Property(e => e.BankName)
                .HasMaxLength(80)
                .HasDefaultValue("");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillingType).HasMaxLength(100);
            entity.Property(e => e.ChequeDate).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ImprestRefNo)
                .HasMaxLength(200)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentRemarks)
                .HasMaxLength(80)
                .HasDefaultValue("");
            entity.Property(e => e.RefernceNo)
                .HasMaxLength(80)
                .HasDefaultValue("0");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(150);
            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<ImBillingOrdersDetail>(entity =>
        {
            entity.HasKey(e => e.BillTranId).HasName("PK__IM_Billi__DA21237FFCBE67B1");

            entity.ToTable("IM_BillingOrdersDetails");

            entity.Property(e => e.BillTranId).HasMaxLength(80);
            entity.Property(e => e.BillId).HasMaxLength(80);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExistingStockItemId)
                .HasMaxLength(100)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("ExistingStockItemID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(100);

            entity.HasOne(d => d.Bill).WithMany(p => p.ImBillingOrdersDetails)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Billin__BillI__34360900");

            entity.HasOne(d => d.Category).WithMany(p => p.ImBillingOrdersDetails)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Billin__Categ__352A2D39");

            entity.HasOne(d => d.Item).WithMany(p => p.ImBillingOrdersDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Billin__ItemI__361E5172");
        });

        modelBuilder.Entity<ImCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__IM_Categ__19093A0BEB74E277");

            entity.ToTable("IM_CategoryMaster");

            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(100);
            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.CategoryType).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.ParentCategory).HasDefaultValueSql("('0')");
            entity.Property(e => e.Remarks).HasMaxLength(150);
        });

        modelBuilder.Entity<ImDepartmentMaster>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__IM_Depar__0148818EB01F473F");

            entity.ToTable("IM_DepartmentMaster");

            entity.Property(e => e.DeptId)
                .HasMaxLength(80)
                .HasColumnName("DeptID");
            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HoduserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HODUserId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<ImGrndetail>(entity =>
        {
            entity.HasKey(e => e.GrnitemId).HasName("PK__IM_GRNDe__89F1FE9E29688333");

            entity.ToTable("IM_GRNDetails");

            entity.Property(e => e.GrnitemId)
                .HasMaxLength(80)
                .HasColumnName("GRNItemId");
            entity.Property(e => e.AdditionalExp).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.BatchNo)
                .HasMaxLength(100)
                .HasColumnName("BatchNO");
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CostPrice).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.Grnid)
                .HasMaxLength(80)
                .HasColumnName("GRNId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemBrandName).HasMaxLength(100);
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.MfgDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Mrpprice)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("MRPPrice");
            entity.Property(e => e.ReceivedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Surcharge).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(100);
            entity.Property(e => e.VatTaxNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.ImGrndetails)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_GRNDet__Categ__371275AB");

            entity.HasOne(d => d.Grn).WithMany(p => p.ImGrndetails)
                .HasForeignKey(d => d.Grnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_GRNDet__GRNId__380699E4");

            entity.HasOne(d => d.Item).WithMany(p => p.ImGrndetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_GRNDet__ItemI__38FABE1D");
        });

        modelBuilder.Entity<ImGrnmaster>(entity =>
        {
            entity.HasKey(e => e.Grnid).HasName("PK__IM_GRNMa__BC0E8C42A3D12F55");

            entity.ToTable("IM_GRNMaster");

            entity.Property(e => e.Grnid)
                .HasMaxLength(80)
                .HasColumnName("GRNId");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FinalAmount).HasColumnType("money");
            entity.Property(e => e.Grndate)
                .HasColumnType("datetime")
                .HasColumnName("GRNDate");
            entity.Property(e => e.Grnno)
                .HasMaxLength(100)
                .HasColumnName("GRNNo");
            entity.Property(e => e.Grrrdate)
                .HasColumnType("datetime")
                .HasColumnName("GRRRDate");
            entity.Property(e => e.Grrrno)
                .HasMaxLength(50)
                .HasColumnName("GRRRNo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModificationRemarks).HasMaxLength(400);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderId).HasMaxLength(80);
            entity.Property(e => e.RefDate).HasColumnType("datetime");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.TaxAmount).HasColumnType("money");
            entity.Property(e => e.VendorId).HasMaxLength(80);

            entity.HasOne(d => d.Vendor).WithMany(p => p.ImGrnmasters)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_GRNMas__Vendo__39EEE256");
        });

        modelBuilder.Entity<ImGrnreleasedHistory>(entity =>
        {
            entity.HasKey(e => e.TrackId).HasName("PK__IM_GRNRe__7A74F8E0E7C85218");

            entity.ToTable("IM_GRNReleasedHistory");

            entity.Property(e => e.TrackId).HasMaxLength(80);
            entity.Property(e => e.BatchNo).HasDefaultValue(-1L);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CostPrice).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasDefaultValue(-1L);
            entity.Property(e => e.ExistingStockItemId)
                .HasMaxLength(80)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.Grnid)
                .HasMaxLength(80)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("GRNId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.MfgDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Mrpprice)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("MRPPrice");
            entity.Property(e => e.ReleaseDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReleasedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.StoreId)
                .HasMaxLength(80)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("StoreID");
            entity.Property(e => e.Units).HasMaxLength(50);

            entity.HasOne(d => d.ExistingStockItem).WithMany(p => p.ImGrnreleasedHistories)
                .HasForeignKey(d => d.ExistingStockItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_GRNRel__Exist__6F3F8FFA");

            entity.HasOne(d => d.Grn).WithMany(p => p.ImGrnreleasedHistories)
                .HasForeignKey(d => d.Grnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_GRNRel__GRNId__6B6EFF16");

            entity.HasOne(d => d.Store).WithMany(p => p.ImGrnreleasedHistories)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_GRNRel__Store__6986B6A4");
        });

        modelBuilder.Entity<ImIndentDetail>(entity =>
        {
            entity.HasKey(e => e.IndentItemId).HasName("PK__IM_Inden__D0EFB30C8D5ED789");

            entity.ToTable("IM_IndentDetails");

            entity.Property(e => e.IndentItemId).HasMaxLength(80);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExpCost).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IndentId).HasMaxLength(80);
            entity.Property(e => e.ItemBrandName).HasMaxLength(100);
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.ImIndentDetails)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__IM_Indent__Categ__3AE3068F");

            entity.HasOne(d => d.Indent).WithMany(p => p.ImIndentDetails)
                .HasForeignKey(d => d.IndentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Indent__Inden__3BD72AC8");

            entity.HasOne(d => d.Item).WithMany(p => p.ImIndentDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Indent__ItemI__3CCB4F01");
        });

        modelBuilder.Entity<ImIndentMaster>(entity =>
        {
            entity.HasKey(e => e.IndentId).HasName("PK__IM_Inden__C9A308DF3BFF2BA1");

            entity.ToTable("IM_IndentMaster");

            entity.Property(e => e.IndentId).HasMaxLength(80);
            entity.Property(e => e.ApprovedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DemandNote).HasMaxLength(200);
            entity.Property(e => e.FileReferenceNo).HasMaxLength(200);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IndentDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Purpose).HasMaxLength(300);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.StaffReqId)
                .HasMaxLength(100)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("StaffReqID");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<ImInsuranceDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IM_InsuranceDetails");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.Age)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DependantId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DependantID");
            entity.Property(e => e.DependantName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InsuranceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsuranceID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Relation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Active");

            entity.HasOne(d => d.Insurance).WithMany()
                .HasForeignKey(d => d.InsuranceId)
                .HasConstraintName("FK__IM_Insura__Insur__157A477B");
        });

        modelBuilder.Entity<ImInsuranceMaster>(entity =>
        {
            entity.HasKey(e => e.InsuranceId).HasName("PK__IM_Insur__74231BC4A8295B35");

            entity.ToTable("IM_InsuranceMaster");

            entity.Property(e => e.InsuranceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsuranceID");
            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InsuranceEndDate).HasColumnType("datetime");
            entity.Property(e => e.InsuranceName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InsuranceStartDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RenewalDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Active");
        });

        modelBuilder.Entity<ImIssueItemDetail>(entity =>
        {
            entity.HasKey(e => e.IssueTranId).HasName("PK__IM_Issue__2DF4CF5E90CD7664");

            entity.ToTable("IM_IssueItemDetails");

            entity.Property(e => e.IssueTranId).HasMaxLength(80);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExistingStockItemId)
                .HasMaxLength(100)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("ExistingStockItemID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IssueId).HasMaxLength(80);
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(100);

            entity.HasOne(d => d.Category).WithMany(p => p.ImIssueItemDetails)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_IssueI__Categ__699DF578");

            entity.HasOne(d => d.Issue).WithMany(p => p.ImIssueItemDetails)
                .HasForeignKey(d => d.IssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_IssueI__Issue__68A9D13F");

            entity.HasOne(d => d.Item).WithMany(p => p.ImIssueItemDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_IssueI__ItemI__6A9219B1");
        });

        modelBuilder.Entity<ImIssueMaster>(entity =>
        {
            entity.HasKey(e => e.IssueId).HasName("PK__IM_Issue__6C8616048726A634");

            entity.ToTable("IM_IssueMaster");

            entity.Property(e => e.IssueId).HasMaxLength(80);
            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.BillingType).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryNo).HasMaxLength(200);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ImprestRefNo)
                .HasMaxLength(200)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.IndentId)
                .HasMaxLength(80)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.IssudeDate).HasColumnType("datetime");
            entity.Property(e => e.IssuedTo).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedBy).HasMaxLength(80);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(150);
            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<ImItemExistingStock>(entity =>
        {
            entity.HasKey(e => e.ExistingItemId).HasName("PK__IM_ItemE__B1329393845C7F32");

            entity.ToTable("IM_ItemExistingStock");

            entity.Property(e => e.ExistingItemId).HasMaxLength(80);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BatchNo).HasDefaultValue(-1L);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CostPrice).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.MfgDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Mrpprice)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("MRPPrice");
            entity.Property(e => e.Units).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.ImItemExistingStocks)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__IM_ItemEx__Categ__3DBF733A");

            entity.HasOne(d => d.Item).WithMany(p => p.ImItemExistingStocks)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_ItemEx__ItemI__3EB39773");
        });

        modelBuilder.Entity<ImItemmaster>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__IM_ITEMM__727E838BB2227BC3");

            entity.ToTable("IM_ITEMMASTER");

            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.ItemName).HasMaxLength(150);
            entity.Property(e => e.ItemType).HasMaxLength(150);
            entity.Property(e => e.Ledger).HasMaxLength(150);
            entity.Property(e => e.Measurement).HasMaxLength(150);
            entity.Property(e => e.MinOrderQty).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.OpeningDate).HasColumnType("datetime");
            entity.Property(e => e.ReOrderQty).HasMaxLength(150);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(100);

            entity.HasOne(d => d.Category).WithMany(p => p.ImItemmasters)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__IM_ITEMMA__Categ__3FA7BBAC");
        });

        modelBuilder.Entity<ImItemsReceivedStock>(entity =>
        {
            entity.HasKey(e => e.ItemsReceivedStockId).HasName("PK__IM_Items__98B04BD4D7CE5A70");

            entity.ToTable("IM_ItemsReceivedStock");

            entity.Property(e => e.ItemsReceivedStockId).HasMaxLength(80);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Grnid)
                .HasMaxLength(80)
                .HasColumnName("GRNId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderId).HasMaxLength(80);
            entity.Property(e => e.ReceivedLessStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ReceivedMoreStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ReceivedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.RequestedStock).HasColumnType("decimal(15, 2)");

            entity.HasOne(d => d.Grn).WithMany(p => p.ImItemsReceivedStocks)
                .HasForeignKey(d => d.Grnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_ItemsR__GRNId__409BDFE5");

            entity.HasOne(d => d.Item).WithMany(p => p.ImItemsReceivedStocks)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_ItemsR__ItemI__4190041E");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.ImItemsReceivedStocks)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_ItemsR__Purch__42842857");
        });

        modelBuilder.Entity<ImKitItemDetail>(entity =>
        {
            entity.HasKey(e => e.KitItemId).HasName("PK__IM_KitIt__5A9E98385F7F1C53");

            entity.ToTable("IM_KitItemDetails");

            entity.Property(e => e.KitItemId).HasMaxLength(80);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.KitId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(100);

            entity.HasOne(d => d.Category).WithMany(p => p.ImKitItemDetails)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_KitIte__Categ__43011B09");

            entity.HasOne(d => d.Kit).WithMany(p => p.ImKitItemDetails)
                .HasForeignKey(d => d.KitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_KitIte__KitId__420CF6D0");
        });

        modelBuilder.Entity<ImKitMaster>(entity =>
        {
            entity.HasKey(e => e.KitId).HasName("PK__IM_KitMa__C96EE4A74589F9F2");

            entity.ToTable("IM_KitMaster");

            entity.Property(e => e.KitId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KitName).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<ImOutPassDetail>(entity =>
        {
            entity.HasKey(e => e.OutPassItemId).HasName("PK__IM_OutPa__1827EA6B1903AA99");

            entity.ToTable("IM_OutPassDetails");

            entity.Property(e => e.OutPassItemId).HasMaxLength(80);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExpCost).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemBrandName).HasMaxLength(100);
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.OutPassId).HasMaxLength(80);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(50);

            entity.HasOne(d => d.OutPass).WithMany(p => p.ImOutPassDetails)
                .HasForeignKey(d => d.OutPassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_OutPas__OutPa__666A52D7");
        });

        modelBuilder.Entity<ImOutPassMaster>(entity =>
        {
            entity.HasKey(e => e.OutPassId).HasName("PK__IM_OutPa__65AC0658FEBB252E");

            entity.ToTable("IM_OutPassMaster");

            entity.Property(e => e.OutPassId).HasMaxLength(80);
            entity.Property(e => e.ApprovedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.OutpassReason).HasMaxLength(300);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.StaffName).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.VehicleNumber).HasMaxLength(200);
        });

        modelBuilder.Entity<ImPurchaseOrderItem>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderItemId).HasName("PK__IM_Purch__3B33A03566C61EE0");

            entity.ToTable("IM_PurchaseOrderItems");

            entity.Property(e => e.PurchaseOrderItemId).HasMaxLength(80);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpCost).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IndentId).HasMaxLength(80);
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.Make).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderId).HasMaxLength(80);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.SubCategory).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.ImPurchaseOrderItems)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__IM_Purcha__Categ__43784C90");

            entity.HasOne(d => d.Item).WithMany(p => p.ImPurchaseOrderItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Purcha__ItemI__446C70C9");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.ImPurchaseOrderItems)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Purcha__Purch__45609502");
        });

        modelBuilder.Entity<ImPurchaseOrderMaster>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderId).HasName("PK__IM_Purch__036BACA472C22C50");

            entity.ToTable("IM_PurchaseOrderMaster");

            entity.Property(e => e.PurchaseOrderId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IndentId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
        });

        modelBuilder.Entity<ImRepairAndMaintenanceDetail>(entity =>
        {
            entity.HasKey(e => e.RepairItemId).HasName("PK__IM_Repai__170835724BE069F8");

            entity.ToTable("IM_RepairAndMaintenanceDetails");

            entity.Property(e => e.RepairItemId).HasMaxLength(80);
            entity.Property(e => e.AdditionalExp).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.BatchNo)
                .HasMaxLength(100)
                .HasColumnName("BatchNO");
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CostPrice).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemBrandName).HasMaxLength(100);
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.MfgDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Mrpprice)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("MRPPrice");
            entity.Property(e => e.ReceivedStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.RepairId)
                .HasMaxLength(80)
                .HasColumnName("RepairID");
            entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            entity.Property(e => e.ServiceCharge)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Surcharge).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(100);
            entity.Property(e => e.VatTaxNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.ImRepairAndMaintenanceDetails)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Repair__Categ__544BA29C");

            entity.HasOne(d => d.Item).WithMany(p => p.ImRepairAndMaintenanceDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Repair__ItemI__5633EB0E");

            entity.HasOne(d => d.Repair).WithMany(p => p.ImRepairAndMaintenanceDetails)
                .HasForeignKey(d => d.RepairId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Repair__Repai__553FC6D5");
        });

        modelBuilder.Entity<ImRepairAndMaintenanceMaster>(entity =>
        {
            entity.HasKey(e => e.RepairId).HasName("PK__IM_Repai__07D0BDCDAE793276");

            entity.ToTable("IM_RepairAndMaintenanceMaster");

            entity.Property(e => e.RepairId)
                .HasMaxLength(80)
                .HasColumnName("RepairID");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Grndate)
                .HasColumnType("datetime")
                .HasColumnName("GRNDate");
            entity.Property(e => e.Grnno)
                .HasMaxLength(100)
                .HasColumnName("GRNNo");
            entity.Property(e => e.Grrrdate)
                .HasColumnType("datetime")
                .HasColumnName("GRRRDate");
            entity.Property(e => e.Grrrno)
                .HasMaxLength(50)
                .HasColumnName("GRRRNo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderId).HasMaxLength(80);
            entity.Property(e => e.RefDate).HasColumnType("datetime");
            entity.Property(e => e.RefNo).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.ServiceCharge).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.VendorId).HasMaxLength(80);

            entity.HasOne(d => d.Vendor).WithMany(p => p.ImRepairAndMaintenanceMasters)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_Repair__Vendo__507B11B8");
        });

        modelBuilder.Entity<ImStaffItemsRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PK__IM_Staff__33A8517AE092B7AC");

            entity.ToTable("IM_StaffItemsRequest");

            entity.Property(e => e.RequestId).HasMaxLength(80);
            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasDefaultValue(-1L);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StoreId)
                .HasMaxLength(80)
                .HasColumnName("StoreID");
            entity.Property(e => e.UserId).HasMaxLength(150);
            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<ImStaffItemsRequestDetail>(entity =>
        {
            entity.HasKey(e => e.RequestTranId).HasName("PK__IM_Staff__9200E2091BE1BF27");

            entity.ToTable("IM_StaffItemsRequestDetails");

            entity.Property(e => e.RequestTranId).HasMaxLength(80);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasDefaultValue(-1L);
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.RequestId).HasMaxLength(80);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StoreStockItemId)
                .HasMaxLength(100)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("StoreStockItemID");
            entity.Property(e => e.Units).HasMaxLength(100);
        });

        modelBuilder.Entity<ImStoreDetail>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK__IM_Store__3B82F0E17EFE7A3C");

            entity.ToTable("IM_StoreDetails");

            entity.Property(e => e.StoreId)
                .HasMaxLength(80)
                .HasColumnName("StoreID");
            entity.Property(e => e.AuthorisedPerson)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ShortCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.StoreName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StoreType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImStoreItemStockDetail>(entity =>
        {
            entity.HasKey(e => e.StoreItemId).HasName("PK__IM_Store__A9B95658B5AF74B6");

            entity.ToTable("IM_StoreItemStockDetails");

            entity.Property(e => e.StoreItemId).HasMaxLength(80);
            entity.Property(e => e.BatchNo).HasDefaultValue(-1L);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CostPrice).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasDefaultValue(-1L);
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExistingStockItemId)
                .HasMaxLength(80)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.Grnid)
                .HasMaxLength(80)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("GRNId");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.MfgDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Mrpprice)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("MRPPrice");
            entity.Property(e => e.ReleaseDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StoreId)
                .HasMaxLength(80)
                .HasColumnName("StoreID");
            entity.Property(e => e.Units).HasMaxLength(50);

            entity.HasOne(d => d.ExistingStockItem).WithMany(p => p.ImStoreItemStockDetails)
                .HasForeignKey(d => d.ExistingStockItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_StoreI__Exist__78C8FA34");

            entity.HasOne(d => d.Grn).WithMany(p => p.ImStoreItemStockDetails)
                .HasForeignKey(d => d.Grnid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_StoreI__GRNId__74F86950");

            entity.HasOne(d => d.Store).WithMany(p => p.ImStoreItemStockDetails)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_StoreI__Store__731020DE");
        });

        modelBuilder.Entity<ImStoreSaleRegister>(entity =>
        {
            entity.HasKey(e => e.StoreSaleId).HasName("PK__IM_Store__95AC8BE80090898C");

            entity.ToTable("IM_StoreSaleRegister");

            entity.Property(e => e.StoreSaleId).HasMaxLength(80);
            entity.Property(e => e.AccountNumber).HasMaxLength(100);
            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.BankCharges).HasMaxLength(100);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillingBy).HasMaxLength(150);
            entity.Property(e => e.BillingType).HasMaxLength(100);
            entity.Property(e => e.ChequeDate).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasDefaultValue(-1L);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ImprestRefNo)
                .HasMaxLength(200)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentRemarks).HasMaxLength(200);
            entity.Property(e => e.RefernceNo).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.SaleType)
                .HasMaxLength(80)
                .HasDefaultValue("Sale");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StoreId)
                .HasMaxLength(80)
                .HasColumnName("StoreID");
            entity.Property(e => e.UserId).HasMaxLength(150);
            entity.Property(e => e.UserType).HasMaxLength(150);

            entity.HasOne(d => d.Store).WithMany(p => p.ImStoreSaleRegisters)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_StoreS__Store__259BA0AB");
        });

        modelBuilder.Entity<ImStoreSaleRegisterDetail>(entity =>
        {
            entity.HasKey(e => e.StoreSaleTranId).HasName("PK__IM_Store__B4C0DB712A3C90CA");

            entity.ToTable("IM_StoreSaleRegisterDetails");

            entity.Property(e => e.StoreSaleTranId).HasMaxLength(80);
            entity.Property(e => e.CategoryId).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId).HasDefaultValue(-1L);
            entity.Property(e => e.ExistingStock).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ItemId).HasMaxLength(80);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.StoreSaleId).HasMaxLength(80);
            entity.Property(e => e.StoreStockItemId)
                .HasMaxLength(100)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("StoreStockItemID");
            entity.Property(e => e.Units).HasMaxLength(100);

            entity.HasOne(d => d.StoreSale).WithMany(p => p.ImStoreSaleRegisterDetails)
                .HasForeignKey(d => d.StoreSaleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_StoreS__Store__2B547A01");
        });

        modelBuilder.Entity<ImStoreStaffDetail>(entity =>
        {
            entity.HasKey(e => e.AccessId).HasName("PK__IM_Store__4130D0BF4BAF8573");

            entity.ToTable("IM_StoreStaffDetails");

            entity.Property(e => e.AccessId)
                .HasMaxLength(80)
                .HasColumnName("AccessID");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.StoreId)
                .HasMaxLength(80)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("StoreID");
            entity.Property(e => e.UserId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Store).WithMany(p => p.ImStoreStaffDetails)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__IM_StoreS__Store__63CDDD4E");
        });

        modelBuilder.Entity<ImSupplierMaster>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__IM_Suppl__4BE666B43D83382D");

            entity.ToTable("IM_SupplierMaster");

            entity.Property(e => e.SupplierId).HasMaxLength(80);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address1).HasMaxLength(100);
            entity.Property(e => e.Address2).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.FaxNo).HasMaxLength(100);
            entity.Property(e => e.Gstno)
                .HasMaxLength(100)
                .HasColumnName("GSTNo");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ledger).HasMaxLength(200);
            entity.Property(e => e.Mobile).HasMaxLength(30);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.Pincode).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<ImUnitsMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IM_Units__3214EC07368D4396");

            entity.ToTable("IM_UnitsMaster");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.UnitName).HasMaxLength(100);
        });

        modelBuilder.Entity<ImUserTypeItemsLimit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IM_UserTypeItemsLimit");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<IndexDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IndexDat__3213E83F1A2F04C0");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.SelectedIndex).HasColumnName("selectedIndex");
        });

        modelBuilder.Entity<Logsjob>(entity =>
        {
            entity.ToTable("logsjob");

            entity.Property(e => e.Logtime)
                .HasColumnType("datetime")
                .HasColumnName("logtime");
        });

        modelBuilder.Entity<Mahindramultiportaldatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MAHINDRA__3214EC2709029D03");

            entity.ToTable("MAHINDRAMULTIPORTALDATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Addess)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("addess");
            entity.Property(e => e.AdmissionNo)
                .HasMaxLength(50)
                .HasColumnName("admissionNo");
            entity.Property(e => e.Classid).HasColumnName("CLASSID");
            entity.Property(e => e.Countryid).HasColumnName("COUNTRYID");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .HasDefaultValue("UniCampus")
                .HasColumnName("createdby");
            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .HasColumnName("DOB");
            entity.Property(e => e.Fatheremailid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fatheremailid");
            entity.Property(e => e.Fathermobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fathermobile");
            entity.Property(e => e.Fathername)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fathername");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("FNAME");
            entity.Property(e => e.Gender).HasColumnName("GENDER");
            entity.Property(e => e.Mothername)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("mothername");
            entity.Property(e => e.Nationality)
                .HasMaxLength(100)
                .HasColumnName("nationality");
            entity.Property(e => e.Partnerid).HasColumnName("partnerid");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PaymentMode).HasMaxLength(100);
            entity.Property(e => e.PaymentStatus).HasMaxLength(50);
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(150);
            entity.Property(e => e.Postcode)
                .HasMaxLength(100)
                .HasColumnName("POSTCODE");
            entity.Property(e => e.Pwdhsah)
                .HasMaxLength(400)
                .HasColumnName("pwdhsah");
            entity.Property(e => e.Pwdslat)
                .HasMaxLength(100)
                .HasColumnName("pwdslat");
            entity.Property(e => e.Section)
                .HasMaxLength(30)
                .HasColumnName("section");
            entity.Property(e => e.StudentType)
                .HasMaxLength(50)
                .HasColumnName("studentType");
            entity.Property(e => e.Studentemailid)
                .HasMaxLength(100)
                .HasColumnName("studentemailid");
            entity.Property(e => e.Studentmobile)
                .HasMaxLength(100)
                .HasColumnName("studentmobile");
            entity.Property(e => e.StusentAdmissionType)
                .HasMaxLength(50)
                .HasColumnName("stusentAdmissionType");
            entity.Property(e => e.TranAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("tranAmount");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(250)
                .HasColumnName("transactionId");
            entity.Property(e => e.Transactiondate)
                .HasColumnType("datetime")
                .HasColumnName("transactiondate");
            entity.Property(e => e.Userid)
                .HasMaxLength(100)
                .HasColumnName("USERID");
            entity.Property(e => e.Vcode)
                .HasMaxLength(100)
                .HasColumnName("VCODE");
        });

        modelBuilder.Entity<MenuTable>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("MenuTable");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PageId).HasDefaultValue(-1);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.ReleaseDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReleaseNotes).HasMaxLength(200);
            entity.Property(e => e.ReleasedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("CloudCampus");
            entity.Property(e => e.Url)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("v 2.0");
        });

        modelBuilder.Entity<OcStaffUrldetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OC_Staff__3214EC07AB6DBDFA");

            entity.ToTable("OC_StaffURLDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("partnerId");
            entity.Property(e => e.Url1)
                .HasMaxLength(500)
                .HasColumnName("URL1");
            entity.Property(e => e.Url2)
                .HasMaxLength(500)
                .HasColumnName("URL2");
            entity.Property(e => e.Url3)
                .HasMaxLength(500)
                .HasColumnName("URL3");
            entity.Property(e => e.Url4)
                .HasMaxLength(500)
                .HasColumnName("URL4");
            entity.Property(e => e.Url5)
                .HasMaxLength(500)
                .HasColumnName("URL5");
            entity.Property(e => e.Url6)
                .HasMaxLength(500)
                .HasColumnName("URL6");
            entity.Property(e => e.UserId).HasMaxLength(200);
        });

        modelBuilder.Entity<OcStaffWiseClassEvent>(entity =>
        {
            entity.HasKey(e => e.ClassEventId).HasName("PK__OC_Staff__A4FD8E74D86D80B7");

            entity.ToTable("OC_StaffWiseClassEvents");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.BatchId).HasDefaultValue(-1L);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventEndDate).HasColumnType("datetime");
            entity.Property(e => e.EventEndTime).HasMaxLength(50);
            entity.Property(e => e.EventStartDate).HasColumnType("datetime");
            entity.Property(e => e.EventStartTime).HasMaxLength(50);
            entity.Property(e => e.EventStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("PENDING");
            entity.Property(e => e.EventTopic)
                .HasMaxLength(500)
                .HasDefaultValue("");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.MonitorStaffId)
                .HasMaxLength(100)
                .HasColumnName("MonitorStaffID");
            entity.Property(e => e.PeriodIdOrders)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.UrlName).HasMaxLength(500);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<OcStudentAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OC_Stude__3214EC07D179B33F");

            entity.ToTable("OC_StudentAttendance");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.EventEndTime).HasMaxLength(50);
            entity.Property(e => e.EventStartTime).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<OcStudentPeriodAttendance>(entity =>
        {
            entity.HasKey(e => e.StudentPeriodAttnId).HasName("PK__OC_Stude__84C8E6D30283BA89");

            entity.ToTable("OC_StudentPeriodAttendance");

            entity.Property(e => e.AttDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProcedureLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProcedureLog");

            entity.HasIndex(e => e.LogDate, "cx_LogDate").IsClustered();

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ProcedureName).HasMaxLength(400);
        });

        modelBuilder.Entity<Rfidprocessedattendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RFIDPROC__3214EC07EA3F58AE");

            entity.ToTable("RFIDPROCESSEDATTENDANCE");

            entity.Property(e => e.AttDate)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AttendanceDate).HasColumnType("datetime");
            entity.Property(e => e.AttendanceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AttendanceID");
            entity.Property(e => e.AttendanceTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClassBatch)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PreviPunch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Timings)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TIMINGS");
        });

        modelBuilder.Entity<SaveQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SaveQuery");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.DisplayName).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.QueryName).HasMaxLength(100);
            entity.Property(e => e.QueryValue).HasMaxLength(1000);
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<StudentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StudentDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdmissionDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BloodGroup).HasMaxLength(100);
            entity.Property(e => e.Board).HasMaxLength(100);
            entity.Property(e => e.Caste).HasMaxLength(20);
            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.IdentificationMarks1).HasMaxLength(200);
            entity.Property(e => e.IdentificationMarks2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Medium)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Nationality).HasMaxLength(100);
            entity.Property(e => e.Percentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PreviousClass).HasMaxLength(50);
            entity.Property(e => e.PreviousSchool).HasMaxLength(200);
            entity.Property(e => e.RegisteredDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RollNo).HasMaxLength(20);
            entity.Property(e => e.StudentType).HasMaxLength(50);
            entity.Property(e => e.TotalMarks).HasColumnType("decimal(6, 2)");
        });

        modelBuilder.Entity<UbaM2mregistrationType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UBA_M2MRegistrationTypes");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.M2mregTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("M2MRegTypeID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<UbaMFinancialyeardetail>(entity =>
        {
            entity.HasKey(e => e.UcbfinancialYearId);

            entity.ToTable("UBA_M_FINANCIALYEARDETAILS");

            entity.Property(e => e.UcbfinancialYearId).HasColumnName("UCBFinancialYearID");
            entity.Property(e => e.AuditBy).HasMaxLength(40);
            entity.Property(e => e.AuditDate).HasColumnType("datetime");
            entity.Property(e => e.AuditStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UCBOOKS");
            entity.Property(e => e.FinancialAccountsStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVE");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.FyaccountClousureDate)
                .HasColumnType("datetime")
                .HasColumnName("FYAccountClousureDate");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UbaMM2mvoucherMaster>(entity =>
        {
            entity.HasKey(e => e.M2mtransId);

            entity.ToTable("UBA_M_M2MVoucherMaster");

            entity.Property(e => e.M2mtransId).HasColumnName("M2MTransId");
            entity.Property(e => e.ActiveStatus).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.M2mnarration)
                .HasMaxLength(400)
                .HasColumnName("M2MNarration");
            entity.Property(e => e.M2mtransRefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("M2MTransRefNo");
            entity.Property(e => e.M2mvoucherAmount)
                .HasColumnType("money")
                .HasColumnName("M2MVoucherAmount");
            entity.Property(e => e.M2mvoucherDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("M2MVoucherDate");
            entity.Property(e => e.M2mvoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("M2MVoucherNo");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SyncStatus)
                .HasDefaultValue((short)-1)
                .HasComment("-2: Failed; -1: Pending; 0 : In Progress; 1: Completed");
            entity.Property(e => e.UcbfinancialYearId)
                .HasDefaultValue(-1L)
                .HasColumnName("UCBFinancialYearID");
        });

        modelBuilder.Entity<UbaOrganizationBankMaster>(entity =>
        {
            entity.ToTable("UBA_OrganizationBankMaster");

            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IFSCCODE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SwiftCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UbaOrganizationMaster>(entity =>
        {
            entity.HasKey(e => e.OrganizationId);

            entity.ToTable("UBA_OrganizationMaster");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactPhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ContactPhoneNO");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CurrencyDecimalNotation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaxNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrgAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OrgBrand).HasMaxLength(100);
            entity.Property(e => e.OrgCategoryOfService)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgCinno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrgCINNo");
            entity.Property(e => e.OrgCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OrgCommissionerate)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgCstno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrgCSTNo");
            entity.Property(e => e.OrgExciseDivision)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgExciseNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgExciseRange)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgGstin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrgGSTIN");
            entity.Property(e => e.OrgHeaderLogo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgLogo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgName).HasMaxLength(200);
            entity.Property(e => e.OrgPanno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrgPANNo");
            entity.Property(e => e.OrgRemarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrgServiceTaxNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrgShortCode).HasMaxLength(50);
            entity.Property(e => e.OrgStatus).HasDefaultValue((byte)1);
            entity.Property(e => e.OrgTinno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OrgTINNo");
            entity.Property(e => e.OrgTitle).HasMaxLength(200);
            entity.Property(e => e.OrgVatNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UbaSsconcessionDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UBA_SSConcessionDetails");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FeeHeadId).HasColumnName("FeeHeadID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.M2mregTypeId).HasColumnName("M2MRegTypeID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SsconcessionAmountLimit)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSConcessionAmountLimit");
            entity.Property(e => e.SsconcessionCountLimit)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSConcessionCountLimit");
            entity.Property(e => e.SsconcessionId).HasColumnName("SSConcessionID");
            entity.Property(e => e.SsconcessionPercentageLimit)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSConcessionPercentageLimit");
            entity.Property(e => e.SsconcessionStatus).HasColumnName("SSConcessionStatus");
            entity.Property(e => e.TotalConsumed).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VaildFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<UbaSsconcessionMaster>(entity =>
        {
            entity.HasKey(e => e.SsconcessionId);

            entity.ToTable("UBA_SSConcessionMaster");

            entity.Property(e => e.SsconcessionId).HasColumnName("SSConcessionID");
            entity.Property(e => e.AppliedBy).HasMaxLength(100);
            entity.Property(e => e.ApprovedBy).HasMaxLength(100);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AutomaticCarryToPu2)
                .HasMaxLength(100)
                .HasDefaultValue("NO")
                .HasColumnName("AutomaticCarryToPU2");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEarlyBird).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScholorshipGroup).HasMaxLength(100);
            entity.Property(e => e.SsconcerssionName)
                .HasMaxLength(150)
                .HasColumnName("SSConcerssionName");
            entity.Property(e => e.SsconcessionAmountLimit)
                .HasDefaultValue(1000m)
                .HasComment("")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSConcessionAmountLimit");
            entity.Property(e => e.SsconcessionCountLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSConcessionCountLimit");
            entity.Property(e => e.SsconcessionPercentageLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSConcessionPercentageLimit");
            entity.Property(e => e.SsconcessionStatus)
                .HasComment("-1: disabled; 0: Inactive; 1: Active")
                .HasColumnName("SSConcessionStatus");
            entity.Property(e => e.SsconcessionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("MCL-Manual Count Limit; MAL-Manual Amount Limit;MPL-Manual Percentage Limit")
                .HasColumnName("SSConcessionType");
            entity.Property(e => e.TotalConsumed).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VaildFrom).HasColumnType("datetime");
            entity.Property(e => e.ValidTo).HasColumnType("datetime");
            entity.Property(e => e.VerifiedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<UbaSsconcessionType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UBA_SSConcessionTypes");

            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Group).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<UbaSsconsessionTransaction>(entity =>
        {
            entity.HasKey(e => e.SstransId);

            entity.ToTable("UBA_SSConsessionTransactions");

            entity.Property(e => e.SstransId).HasColumnName("SSTransId");
            entity.Property(e => e.ApprovedBy).HasMaxLength(100);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ConcessionBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ConcessionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocRefNo).HasMaxLength(200);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(80)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScholorshipGroup).HasMaxLength(100);
            entity.Property(e => e.SsconcessionId).HasColumnName("SSConcessionId");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalConcession).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VerifiedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<UcLmLeaveTransaction>(entity =>
        {
            entity.HasKey(e => e.LeaveId).HasName("PK__UC_LM_Le__796DB9596538CF25");

            entity.ToTable("UC_LM_LeaveTransactions");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveApprovedBy).HasMaxLength(100);
            entity.Property(e => e.LeaveFromDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveFromSession).HasMaxLength(50);
            entity.Property(e => e.LeaveReason).HasMaxLength(100);
            entity.Property(e => e.LeaveSanctionedDates).HasMaxLength(100);
            entity.Property(e => e.LeaveToDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveToSession).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(80);
            entity.Property(e => e.UserId).HasMaxLength(80);

            entity.HasOne(d => d.LeaveType).WithMany(p => p.UcLmLeaveTransactions)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UC_LM_Lea__Leave__464C2E48");
        });

        modelBuilder.Entity<UcLmLeavesEligibilityForUser>(entity =>
        {
            entity.HasKey(e => e.LeaveEligUserId).HasName("PK__UC_LM_Le__9502AEFB2F537DD7");

            entity.ToTable("UC_LM_LeavesEligibilityForUser");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BalanceLeaves).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LeavesTaken).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NoOfLeaves).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(80);

            entity.HasOne(d => d.LeaveEligibility).WithMany(p => p.UcLmLeavesEligibilityForUsers)
                .HasForeignKey(d => d.LeaveEligibilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UC_LM_Lea__Leave__3F9F30B9");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.UcLmLeavesEligibilityForUsers)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UC_LM_Lea__Leave__4187792B");

            entity.HasOne(d => d.Role).WithMany(p => p.UcLmLeavesEligibilityForUsers)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UC_LM_Lea__RoleI__409354F2");
        });

        modelBuilder.Entity<UcLmMLeaveType>(entity =>
        {
            entity.HasKey(e => e.LeaveTypeId).HasName("PK__UC_LM_M___43BE8F1438432016");

            entity.ToTable("UC_LM_M_LeaveType");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveTypeName).HasMaxLength(100);
            entity.Property(e => e.LeaveTypeShortName).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(150);
        });

        modelBuilder.Entity<UcLmMLeavesEligibility>(entity =>
        {
            entity.HasKey(e => e.LeaveEligibilityId).HasName("PK__UC_LM_M___672ED1C9AF7B08D6");

            entity.ToTable("UC_LM_M_LeavesEligibility");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeType)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.NoOfLeaves).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(100);

            entity.HasOne(d => d.LeaveType).WithMany(p => p.UcLmMLeavesEligibilities)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UC_LM_M_L__Leave__3BCE9FD5");

            entity.HasOne(d => d.Role).WithMany(p => p.UcLmMLeavesEligibilities)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UC_LM_M_L__RoleI__3ADA7B9C");
        });

        modelBuilder.Entity<UcLmMLeavesProcessingDetail>(entity =>
        {
            entity.HasKey(e => e.CalculatedLeavesId).HasName("PK__UC_LM_M___3D5F0B5003BF5D46");

            entity.ToTable("UC_LM_M_LeavesProcessingDetails");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LeavesCalculatedForMonth).HasMaxLength(80);
            entity.Property(e => e.LeavesCalculatedForYear).HasMaxLength(80);
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.UserId).HasMaxLength(80);
        });

        modelBuilder.Entity<Ucerrorlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UCERRORL__3214EC27FDEC7CC4");

            entity.ToTable("UCERRORLOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Crateddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("crateddate");
            entity.Property(e => e.ErrorLine)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorNumber)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorProcedure)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorSeverity)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorState)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAdmissionsDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_AdmissionsDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdmissionType).HasMaxLength(50);
            entity.Property(e => e.AdmissionYear).HasMaxLength(50);
            entity.Property(e => e.AppicationStatus).HasMaxLength(20);
            entity.Property(e => e.ApplicationAmount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EnquiryStatus).HasMaxLength(20);
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Medium).HasMaxLength(50);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nationality).HasMaxLength(100);
            entity.Property(e => e.ParentName).HasMaxLength(75);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Relation).HasMaxLength(50);
            entity.Property(e => e.StudentName).HasMaxLength(201);
        });

        modelBuilder.Entity<VwExamPerformance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_ExamPerformance");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdmissionNo).HasMaxLength(100);
            entity.Property(e => e.Cgpa)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("CGPA");
            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.ClassRank).HasMaxLength(100);
            entity.Property(e => e.Examination).HasMaxLength(100);
            entity.Property(e => e.Grade)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.GradePoint).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.MaxMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Name).HasMaxLength(201);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Percentage).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Result)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.RollNo).HasMaxLength(20);
            entity.Property(e => e.SectionName).HasMaxLength(40);
            entity.Property(e => e.SectionRank).HasMaxLength(100);
            entity.Property(e => e.SecuredMarks).HasColumnType("decimal(15, 2)");
        });

        modelBuilder.Entity<VwFeeDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FeeDetails");

            entity.Property(e => e.AdmissionNo).HasMaxLength(100);
            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.AmountPaid).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.AprovedConcAmt).HasColumnType("money");
            entity.Property(e => e.Class).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DateOfPayment)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.DueAmount).HasColumnType("money");
            entity.Property(e => e.Duedate).HasColumnType("datetime");
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.FeeFor).HasMaxLength(50);
            entity.Property(e => e.FineAmount).HasColumnType("money");
            entity.Property(e => e.FriendlyName).HasMaxLength(200);
            entity.Property(e => e.HeadAmount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.HeadId).HasColumnName("HeadID");
            entity.Property(e => e.HeadName).HasMaxLength(150);
            entity.Property(e => e.LastPaidDate).HasColumnType("datetime");
            entity.Property(e => e.ModeOfPayment).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(201);
            entity.Property(e => e.PaidBy).HasMaxLength(150);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.ReceiptNo).HasMaxLength(100);
            entity.Property(e => e.RollNo).HasMaxLength(20);
            entity.Property(e => e.Section).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<VwStaffDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_StaffDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Achievements).HasMaxLength(400);
            entity.Property(e => e.AdharNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Adhar No");
            entity.Property(e => e.AnniversaryDate).HasColumnName("Anniversary Date");
            entity.Property(e => e.BankName).HasColumnName("Bank Name");
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(100)
                .HasColumnName("Blood Group");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Date of Birth");
            entity.Property(e => e.EMailId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E-mail ID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Experience).HasMaxLength(200);
            entity.Property(e => e.FingerPrintId).HasColumnName("Finger Print ID");
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.HeightInFeet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Height in Feet");
            entity.Property(e => e.MaritalStatus).HasColumnName("Marital Status");
            entity.Property(e => e.Mobile)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PanNo).HasColumnName("Pan No");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PermanentAddress).HasMaxLength(500);
            entity.Property(e => e.PermanentCity).HasMaxLength(100);
            entity.Property(e => e.PermanentPostalCode).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(100);
            entity.Property(e => e.PresentAddress).HasMaxLength(500);
            entity.Property(e => e.PresentCity).HasMaxLength(100);
            entity.Property(e => e.PreviosWorkPlace).HasColumnName("Previos Work Place");
            entity.Property(e => e.PreviousCompanyAddress).HasColumnName("Previous Company Address");
            entity.Property(e => e.ReasonForLeave).HasColumnName("Reason for Leave");
            entity.Property(e => e.Role).HasMaxLength(200);
            entity.Property(e => e.SpecificAliments).HasColumnName("Specific Aliments");
            entity.Property(e => e.SpouseName).HasColumnName("Spouse Name");
            entity.Property(e => e.StaffBlock).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(40);
            entity.Property(e => e.VisionLeft)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Vision left");
            entity.Property(e => e.VisionRight)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Vision right");
            entity.Property(e => e.VoterId).HasColumnName("Voter Id");
            entity.Property(e => e.WeightInKg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Weight in kg");
        });

        modelBuilder.Entity<VwStudentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_StudentDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.AdmissionNo).HasMaxLength(100);
            entity.Property(e => e.BloodGroup).HasMaxLength(100);
            entity.Property(e => e.Caste).HasMaxLength(20);
            entity.Property(e => e.Class).HasMaxLength(50);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Elective1).HasMaxLength(100);
            entity.Property(e => e.Elective2).HasMaxLength(100);
            entity.Property(e => e.Elective3).HasMaxLength(100);
            entity.Property(e => e.Elective4).HasMaxLength(100);
            entity.Property(e => e.FatherName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FirstLanguage).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Medium).HasMaxLength(50);
            entity.Property(e => e.MotherName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nationality).HasMaxLength(100);
            entity.Property(e => e.Occupation).HasMaxLength(300);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PresentAddress).HasMaxLength(500);
            entity.Property(e => e.Qualification).HasMaxLength(50);
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.RollNo).HasMaxLength(20);
            entity.Property(e => e.SecondLanguage).HasMaxLength(100);
            entity.Property(e => e.Section).HasMaxLength(40);
            entity.Property(e => e.StudentType).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(40);
        });

        modelBuilder.Entity<VwStudentFeeDueDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_StudentFeeDueDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ActualAmount).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.AdmissionNo)
                .HasMaxLength(100)
                .HasColumnName("Admission no");
            entity.Property(e => e.AfterConcession).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.AmountDue).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.AmountPaid).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Class).HasMaxLength(50);
            entity.Property(e => e.ConcessionAmount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.FatherName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FeeFor).HasMaxLength(50);
            entity.Property(e => e.FeeHeadName).HasMaxLength(150);
            entity.Property(e => e.Mobile)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Mobileno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("mobileno");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RollNo)
                .HasMaxLength(20)
                .HasColumnName("Roll no");
            entity.Property(e => e.Section).HasMaxLength(40);
            entity.Property(e => e.StudentName).HasMaxLength(201);
        });

        modelBuilder.Entity<VwTransportDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_TransportDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ActualAmount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.AdmissionNo).HasMaxLength(100);
            entity.Property(e => e.Class).HasMaxLength(50);
            entity.Property(e => e.Concession).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.DropTime).HasMaxLength(200);
            entity.Property(e => e.DueAmount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Locations).HasMaxLength(100);
            entity.Property(e => e.Mobile)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ParentName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PickupTime).HasMaxLength(200);
            entity.Property(e => e.RouteName).HasMaxLength(100);
            entity.Property(e => e.RouteType).HasMaxLength(50);
            entity.Property(e => e.Section).HasMaxLength(40);
            entity.Property(e => e.StudentName).HasMaxLength(201);
            entity.Property(e => e.TransportStudent)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdITBudgetAc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WdI_T_BudgetAc");

            entity.Property(e => e.TargetId).HasColumnName("TargetID");
        });

        modelBuilder.Entity<WdiMAcademicClassSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_M_Ac__3214EC2712FA96A2");

            entity.ToTable("WDI_M_AcademicClassSections");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Sequencenumber)
                .HasDefaultValue(1)
                .HasColumnName("sequencenumber");
        });

        modelBuilder.Entity<WdiMAcademicYearDetail>(entity =>
        {
            entity.HasKey(e => e.AcademicYearId).HasName("PK_WDI_M_AcademicYear_Details");

            entity.ToTable("WDI_M_AcademicYearDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Branches)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("partnerId");
            entity.Property(e => e.ReOpenDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMAccesspermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_ACCESSPERMISSIONS");

            entity.Property(e => e.AccessId).ValueGeneratedOnAdd();
            entity.Property(e => e.Add).HasColumnName("ADD");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMAccountHeadMaster>(entity =>
        {
            entity.HasKey(e => e.AccHeadId);

            entity.ToTable("WDI_M_AccountHeadMaster");

            entity.Property(e => e.AccHeadId).HasColumnName("Acc_HeadId");
            entity.Property(e => e.AcHeadType)
                .HasMaxLength(50)
                .HasDefaultValue("ACCOUNTS")
                .HasColumnName("Ac_HeadType");
            entity.Property(e => e.AccDescription)
                .HasMaxLength(200)
                .HasColumnName("Acc_Description");
            entity.Property(e => e.AccMainHeadGroup).HasColumnName("Acc_MainHeadGroup");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ObalType)
                .HasMaxLength(20)
                .HasDefaultValue("Dr")
                .HasColumnName("OBalType");
            entity.Property(e => e.OpeningBalance).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TranStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMAccountsMainMaster>(entity =>
        {
            entity.HasKey(e => e.AccMainHeadGroupId);

            entity.ToTable("WDI_M_AccountsMainMaster");

            entity.Property(e => e.AccMainHeadGroupId).HasColumnName("Acc_MainHeadGroupID");
            entity.Property(e => e.AccMainHeadName)
                .HasMaxLength(400)
                .HasColumnName("Acc_MainHeadName");
            entity.Property(e => e.Comments).HasMaxLength(200);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupNature).HasMaxLength(50);
            entity.Property(e => e.IsDefault)
                .HasDefaultValue(true)
                .HasComment("There are 28 pre-defined Groups in cloudcampus, out of which 15 are Primary Groups and 13 are Sub-Groups.");
            entity.Property(e => e.IsPrimary).HasDefaultValue(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<WdiMAchievement>(entity =>
        {
            entity.HasKey(e => e.AchieveId).HasName("PK_WDI_Achievements");

            entity.ToTable("WDI_M_Achievements");

            entity.Property(e => e.AchievedDate).HasColumnType("datetime");
            entity.Property(e => e.AchievementDetails).HasMaxLength(200);
            entity.Property(e => e.EventDate)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMAdminuseraccess>(entity =>
        {
            entity.ToTable("WDI_M_ADMINUSERACCESS");

            entity.Property(e => e.ModuleName).HasMaxLength(100);
            entity.Property(e => e.Usertype).HasColumnName("usertype");
        });

        modelBuilder.Entity<WdiMAdmissionvacancyPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__wdi_m_Ad__3213E83F6C0A4817");

            entity.ToTable("wdi_m_AdmissionvacancyPosition");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("School");
            entity.Property(e => e.Classid).HasColumnName("classid");
            entity.Property(e => e.Createdby).HasMaxLength(400);
            entity.Property(e => e.ForAcyr).HasMaxLength(400);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.Patnerid).HasColumnName("patnerid");
            entity.Property(e => e.SectionId).HasDefaultValue(-1L);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMAllotmentdetail>(entity =>
        {
            entity.HasKey(e => e.AllotmentId);

            entity.ToTable("Wdi_M_Allotmentdetails");

            entity.Property(e => e.AllotmentId).HasColumnName("AllotmentID");
            entity.Property(e => e.AllotedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HostelAllotmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("0000");
            entity.Property(e => e.Status).HasComment("0 -- Active (Present Alloted Seat)  ; 1 -- Inactive (previous Alloted Seat)  ;   -1 --- Seat Waiting for Conformation. ;   2 --- Vacated User Details.");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VacationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMAppnotification>(entity =>
        {
            entity.HasKey(e => e.AppNotificationId);

            entity.ToTable("WDI_M_APPNOTIFICATIONS");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.NotificationAction).HasMaxLength(100);
            entity.Property(e => e.NotificationSyncDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationSyncStatus).HasComment("0 --- Un Read ;  1  --- Read");
            entity.Property(e => e.NotifyOn).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.TemplateParams).HasMaxLength(2000);
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMAssessmentType>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK_WDI_M_AssessmentType");

            entity.ToTable("WDI_M_AssessmentTypes");

            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.Assessment).HasMaxLength(50);
            entity.Property(e => e.ExamName).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMBankDetail>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("PK_WDI_M_BankDetails_1");

            entity.ToTable("WDI_M_BankDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AccBalance)
                .HasColumnType("money")
                .HasColumnName("Acc_Balance");
            entity.Property(e => e.AccNumber).HasColumnName("Acc_Number");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.BankDetails).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Ifsc)
                .HasMaxLength(200)
                .HasColumnName("IFSC");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Printonreports).HasColumnName("printonreports");
        });

        modelBuilder.Entity<WdiMBatchMaster>(entity =>
        {
            entity.ToTable("Wdi_M_BatchMaster");

            entity.Property(e => e.BatchName).HasMaxLength(500);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiMBillingOrder>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK__WDI_M_Bi__11F2FC6AAE423B05");

            entity.ToTable("WDI_M_BillingOrders");

            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillingType).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(150);
            entity.Property(e => e.UserType).HasMaxLength(150);
        });

        modelBuilder.Entity<WdiMBillingOrdersDetail>(entity =>
        {
            entity.HasKey(e => e.BillTranId).HasName("PK__WDI_M_Bi__DA21237FC1B6D4DC");

            entity.ToTable("WDI_M_BillingOrdersDetails");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Units).HasMaxLength(100);

            entity.HasOne(d => d.Bill).WithMany(p => p.WdiMBillingOrdersDetails)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_M_Bil__BillI__061A3895");

            entity.HasOne(d => d.Category).WithMany(p => p.WdiMBillingOrdersDetails)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_M_Bil__Categ__08028107");

            entity.HasOne(d => d.Item).WithMany(p => p.WdiMBillingOrdersDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_M_Bil__ItemI__070E5CCE");
        });

        modelBuilder.Entity<WdiMBlockMaster>(entity =>
        {
            entity.HasKey(e => e.BlockId);

            entity.ToTable("Wdi_M_BlockMaster");

            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.BlockName).HasMaxLength(200);
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.Floor).HasMaxLength(50);
            entity.Property(e => e.HostelId)
                .HasComment("Hostel Id load from Hostel table. etc")
                .HasColumnName("HostelID");
        });

        modelBuilder.Entity<WdiMBookMarksForApp>(entity =>
        {
            entity.ToTable("Wdi_M_BookMarksForApp");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMBudgetHead>(entity =>
        {
            entity.HasKey(e => e.TargetId);

            entity.ToTable("WDI_M_BudgetHeads");

            entity.Property(e => e.TargetId).HasColumnName("TargetID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Name).HasMaxLength(75);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Target).HasColumnType("money");
            entity.Property(e => e.Type).HasMaxLength(20);
        });

        modelBuilder.Entity<WdiMBuildingMaster>(entity =>
        {
            entity.HasKey(e => e.BuildingId);

            entity.ToTable("Wdi_M_BuildingMaster");

            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.BuildingName).HasMaxLength(200);
            entity.Property(e => e.BuildingWarden)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HostelId)
                .HasComment("Hostel Id load from Hostel table. etc")
                .HasColumnName("HostelID");
        });

        modelBuilder.Entity<WdiMBusinessRuleMaster>(entity =>
        {
            entity.HasKey(e => e.BusinessRuleId);

            entity.ToTable("WDI_M_BusinessRuleMaster");

            entity.Property(e => e.BusinessRuleId).HasColumnName("BusinessRuleID");
            entity.Property(e => e.BusinessRuleDataType)
                .HasMaxLength(50)
                .HasDefaultValue("string");
            entity.Property(e => e.BusinessRuleFriendlyName).HasMaxLength(300);
            entity.Property(e => e.BusinessRuleType)
                .HasMaxLength(30)
                .HasDefaultValue("ICOM");
            entity.Property(e => e.BusinessRuleValueType)
                .HasMaxLength(15)
                .HasDefaultValue("S")
                .HasComment("S-Single; R-Range");
            entity.Property(e => e.BusinessRulename).HasMaxLength(400);
            entity.Property(e => e.DefaultRuleValue).HasMaxLength(100);
            entity.Property(e => e.FinancialYearId).HasDefaultValue(-1L);
        });

        modelBuilder.Entity<WdiMBussinessType>(entity =>
        {
            entity.HasKey(e => e.BussinessTypeId);

            entity.ToTable("WDI_M_BussinessType");

            entity.Property(e => e.BussinessType).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiMCaste>(entity =>
        {
            entity.HasKey(e => e.CastId);

            entity.ToTable("WDI_M_Caste");

            entity.Property(e => e.CastId).HasColumnName("CastID");
            entity.Property(e => e.Caste).HasMaxLength(20);
        });

        modelBuilder.Entity<WdiMCategoryMaster>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__WDI_M_Ca__19093A0B671F813E");

            entity.ToTable("WDI_M_CategoryMaster");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(100);
            entity.Property(e => e.CategoryName).HasMaxLength(100);
            entity.Property(e => e.CategoryType)
                .HasMaxLength(20)
                .HasDefaultValue("INVENTORY");
        });

        modelBuilder.Entity<WdiMCcreportTemplate>(entity =>
        {
            entity.HasKey(e => e.CcreportTemplateId).HasName("PK_CCReportTemplates");

            entity.ToTable("WDI_M_CCReportTemplates");

            entity.Property(e => e.CcreportTemplateId).HasColumnName("CCReportTemplateID");
            entity.Property(e => e.CcreportTemplateName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CCReportTemplateName");
            entity.Property(e => e.RelatedTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.XsltemplateText)
                .IsUnicode(false)
                .HasColumnName("XSLTemplateText");
        });

        modelBuilder.Entity<WdiMClass>(entity =>
        {
            entity.HasKey(e => e.ClassId);

            entity.ToTable("WDI_M_Class");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ClassCode).HasMaxLength(50);
            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.ClassType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("REGULAR");
            entity.Property(e => e.CoschalsticMarksByTermorExam)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("t")
                .IsFixedLength();
            entity.Property(e => e.DepartmentId)
                .HasDefaultValue(-1L)
                .HasComment("Here :: -1 no department Exist.");
            entity.Property(e => e.ExaminationPassed)
                .HasDefaultValue(-1L)
                .HasComment("0-- INTER ; 1 -- CBSE ; 2 -- ISC ; 3 -- BA ; 4 -- BSC ; 5 - BCom ; 6 - BMS ; 7- BBA  ; 8 - Othere.");
            entity.Property(e => e.IsAided)
                .HasDefaultValue(false)
                .HasComment("1-- Aided ; 0-- UnAided");
            entity.Property(e => e.IsCce)
                .HasDefaultValue(false)
                .HasColumnName("IsCCE");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.StreamId)
                .HasMaxLength(500)
                .HasDefaultValueSql("((-1))")
                .HasComment("1 -- ARTS/COMMERCE/SCIENCE ; 2 -- MPC ; 3 --MPC/MEC ; 4 -- BPC/MPBC ; 5 -- BPC/MPBC/MPC ; 6 -- B.Sc. Maths-Comp Sc ; 7 -- B.Sc. Life Sciences ; 8 -- B.Sc. Mathematics ; 9 -- B.Sc. Chemistry ; 10 -- BA/BCom/BSc/BBA/BMS  ; 11 - B.Com/BSc(MAT/STA/CSC)/BBA/BMS ;\r\n12 - Othre.")
                .HasColumnName("streamId");
            entity.Property(e => e.TotalSeats).HasDefaultValue(100);
            entity.Property(e => e.W2lClassId)
                .HasComment("0: watch2learn classes; -1: partners CLasses; other numbers : mapped to watch2learn classes ")
                .HasColumnName("w2lClassId");
        });

        modelBuilder.Entity<WdiMClassWiseStypendAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_ClassWiseStypendAmounts");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Createdby).HasMaxLength(400);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Modifiedby).HasMaxLength(400);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
        });

        modelBuilder.Entity<WdiMClub>(entity =>
        {
            entity.HasKey(e => e.ClubId);

            entity.ToTable("WDI_M_Clubs");

            entity.Property(e => e.ClubId).HasColumnName("ClubID");
            entity.Property(e => e.ClubName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<WdiMCoCurricularActivity>(entity =>
        {
            entity.HasKey(e => e.CoCurricularAtivityId);

            entity.ToTable("WDI_M_CoCurricularActivities");

            entity.Property(e => e.CoCurricularAtivityId).HasColumnName("CoCurricularAtivityID");
            entity.Property(e => e.CoCurricularActivtyName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<WdiMCommTemplate>(entity =>
        {
            entity.HasKey(e => e.CommTemplateId).HasName("PK_Templates");

            entity.ToTable("WDI_M_CommTemplates");

            entity.Property(e => e.CommTemplateId).HasColumnName("CommTemplateID");
            entity.Property(e => e.AcadamicYearId).HasColumnName("AcadamicYearID");
            entity.Property(e => e.Action).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Date)
                .HasComment("NULL - Immediately, Date - Consider on which Date Mail,SMS should be send.")
                .HasColumnType("datetime");
            entity.Property(e => e.Days).HasMaxLength(100);
            entity.Property(e => e.IsApproved)
                .HasDefaultValue(false)
                .HasComment("0 - false(Not Active)  1 - True(Active)");
            entity.Property(e => e.IsNoted).HasDefaultValue(false);
            entity.Property(e => e.IsTestTemplateSend).HasDefaultValue(false);
            entity.Property(e => e.PartnerEmailId)
                .HasMaxLength(200)
                .HasColumnName("PartnerEmailID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerTemplateId).HasColumnName("PartnerTemplateID");
            entity.Property(e => e.SenderInfo).HasMaxLength(2000);
            entity.Property(e => e.SendingType).HasMaxLength(100);
            entity.Property(e => e.SmstemplateText).HasColumnName("SMSTemplateText");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .IsFixedLength()
                .HasComment("P - Pending, C - Completed, F - Failed");
            entity.Property(e => e.Subject).HasMaxLength(400);
            entity.Property(e => e.TemplateParams).HasMaxLength(2000);
            entity.Property(e => e.TemplateType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("E - Email , S - SMS");
            entity.Property(e => e.XmlfileName)
                .HasMaxLength(200)
                .HasColumnName("XMLFileName");
        });

        modelBuilder.Entity<WdiMComplaintDetail>(entity =>
        {
            entity.ToTable("Wdi_m_ComplaintDetails");

            entity.Property(e => e.ComplaintDescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasComment("0 ---- Pending ;   1------- Completed ;  2 ---- Rejected  ;   3 --- Progress ; -1 -----In-Active the Message");
            entity.Property(e => e.Subject)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId);

            entity.ToTable("WDI_M_Country");

            entity.Property(e => e.CountryId).ValueGeneratedNever();
            entity.Property(e => e.Citizen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("citizen");
            entity.Property(e => e.CountryCode).HasMaxLength(20);
            entity.Property(e => e.CountryName).HasMaxLength(100);
            entity.Property(e => e.TimeZone).HasMaxLength(20);
        });

        modelBuilder.Entity<WdiMCourseGroupMaster>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_WDI_M_Group Master");

            entity.ToTable("WDI_M_CourseGroupMaster");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiMDailyActivity>(entity =>
        {
            entity.HasKey(e => e.ActivityId);

            entity.ToTable("Wdi_M_DailyActivity");

            entity.Property(e => e.ActivityId).HasColumnName("ActivityID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ActivityName).HasMaxLength(500);
            entity.Property(e => e.CourseNyear)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CourseNYear");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.NoofHours)
                .HasDefaultValueSql("('0.0')")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.SubjectName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.UserId)
                .HasMaxLength(80)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiMDepartmentMaster>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.ToTable("WDI_M_DepartmentMaster");

            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeptName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HoduserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HODUserId");
            entity.Property(e => e.IsDefault)
                .HasDefaultValue(true)
                .HasColumnName("isDefault");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<WdiMDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK_WDI_M_DOCMENTS");

            entity.ToTable("WDI_M_DOCUMENTS");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(40)
                .HasDefaultValue("watch2learn");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DocumentName).HasMaxLength(200);
            entity.Property(e => e.Type).HasComment("0---Student Documents  1--Staff Document");
        });

        modelBuilder.Entity<WdiMEmailtemplateMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WDI_M_EMAILTemplateMaster_1");

            entity.ToTable("WDI_M_EMAILTemplateMaster");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifyBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateFormat).HasColumnType("ntext");
            entity.Property(e => e.TemplateFriendlyName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Templateid)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMEmpLeaveMaster>(entity =>
        {
            entity.HasKey(e => e.LeaveId);

            entity.ToTable("WDI_M_EmpLeaveMaster");

            entity.Property(e => e.LeaveId).HasColumnName("LeaveID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveFrom).HasColumnType("datetime");
            entity.Property(e => e.LeaveSanctionAuth).HasMaxLength(40);
            entity.Property(e => e.LeaveTo).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SanctionDates).HasMaxLength(1000);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiMEmployeeLeaveTypeDatum>(entity =>
        {
            entity.HasKey(e => e.EmployeeLeaveTypeDataId).HasName("PK_WDI_M_LeaveTypeData");

            entity.ToTable("WDI_M_EmployeeLeaveTypeData");

            entity.Property(e => e.EmployeeLeaveTypeDataId).HasColumnName("EmployeeLeaveTypeDataID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CarryForward).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.EmployeeLeaveTypeId).HasColumnName("EmployeeLeaveTypeID");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ForMonth).HasMaxLength(10);
            entity.Property(e => e.TotalDaysEligible).HasColumnType("decimal(18, 1)");
        });

        modelBuilder.Entity<WdiMEnquiry>(entity =>
        {
            entity.HasKey(e => e.EnquiryId);

            entity.ToTable("WDI_M_Enquiry");

            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdmissionClass).HasColumnName("Admission Class");
            entity.Property(e => e.AdmissionNo)
                .HasMaxLength(100)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(40)
                .HasColumnName("Contact Number");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .HasColumnName("Email Id");
            entity.Property(e => e.EncryptedContactNumber).HasMaxLength(256);
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobile).HasMaxLength(256);
            entity.Property(e => e.EnquiryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnquiryPerson).HasMaxLength(100);
            entity.Property(e => e.EnquiryReason)
                .HasMaxLength(400)
                .HasDefaultValue("General");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .HasColumnName("LName");
            entity.Property(e => e.Medium)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Mobile).HasMaxLength(40);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PresentAddress).HasMaxLength(500);
            entity.Property(e => e.PresentCity).HasMaxLength(100);
            entity.Property(e => e.PresentClass).HasColumnName("Present Class");
            entity.Property(e => e.State).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMEpayTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_EpayTransactions");

            entity.Property(e => e.Guid)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Uid)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMEvaluationSubject>(entity =>
        {
            entity.HasKey(e => e.SubjectId);

            entity.ToTable("WDI_M_EvaluationSubjects");

            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.MaxMarks).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MinMarks).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SubjectName).HasMaxLength(75);
        });

        modelBuilder.Entity<WdiMEvent>(entity =>
        {
            entity.HasKey(e => e.EventId);

            entity.ToTable("Wdi_M_Events");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.AcademicYearId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("AcademicYearID");
            entity.Property(e => e.ClubId).HasColumnName("ClubID");
            entity.Property(e => e.EventActivityTypeId).HasColumnName("EventActivityTypeID");
            entity.Property(e => e.EventName).HasMaxLength(50);
            entity.Property(e => e.EventOrganizerUserId)
                .HasMaxLength(50)
                .HasColumnName("EventOrganizerUserID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PeriodIds)
                .HasMaxLength(50)
                .HasColumnName("PeriodIDs");
            entity.Property(e => e.UnitNumber).HasMaxLength(50);
            entity.Property(e => e.Venue).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiMEventActivityType>(entity =>
        {
            entity.HasKey(e => e.EventActivityTypeId);

            entity.ToTable("WDI_M_EventActivityTypes");

            entity.Property(e => e.EventActivityTypeId).HasColumnName("EventActivityTypeID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EventActivityName).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<WdiMExaminationName>(entity =>
        {
            entity.HasKey(e => e.ExaminationId);

            entity.ToTable("WDI_M_ExaminationNames");

            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.AssesmentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExaminationName).HasMaxLength(200);
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ShortName).HasMaxLength(200);
        });

        modelBuilder.Entity<WdiMExpenseType>(entity =>
        {
            entity.HasKey(e => e.ExpenseTypeId).HasName("PK__WDI_M_Ex__E082A36FD302B80F");

            entity.ToTable("WDI_M_ExpenseTypes");

            entity.Property(e => e.ExpenseTypeId).HasColumnName("ExpenseTypeID");
            entity.Property(e => e.Expenses)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiMFacultyMapping>(entity =>
        {
            entity.HasKey(e => e.FacultyMappingId);

            entity.ToTable("WDI_M_FacultyMapping");

            entity.Property(e => e.FacultyMappingId).HasColumnName("FacultyMappingID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId)
                .HasMaxLength(40)
                .HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FacultyId)
                .HasMaxLength(40)
                .HasColumnName("FacultyID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SectionId)
                .HasMaxLength(40)
                .HasColumnName("SectionID");
            entity.Property(e => e.SubjectId)
                .HasMaxLength(40)
                .HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiMFacultyvacancyposition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_M_FA__3213E83F7EF053E6");

            entity.ToTable("WDI_M_FACULTYVACANCYPOSITION");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<WdiMFamilyMember>(entity =>
        {
            entity.HasKey(e => e.FamilyMemberId).HasName("PK_Tbl_M_FamilyMembers");

            entity.ToTable("WDI_M_FamilyMembers");

            entity.Property(e => e.FamilyMemberId).HasColumnName("FamilyMemberID");
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.EmailId)
                .HasMaxLength(200)
                .HasColumnName("EmailID");
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMemberName).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobileNo).HasMaxLength(256);
            entity.Property(e => e.EncryptedPhoneNo).HasMaxLength(256);
            entity.Property(e => e.Extrafields)
                .HasColumnType("xml")
                .HasColumnName("EXTRAFIELDS");
            entity.Property(e => e.FamilyMemberName).HasMaxLength(100);
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(50)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.Mobile).HasMaxLength(40);
            entity.Property(e => e.Occupation).HasMaxLength(300);
            entity.Property(e => e.ParentStatus).HasMaxLength(100);
            entity.Property(e => e.PhoneNo).HasMaxLength(40);
            entity.Property(e => e.ProfileImage)
                .HasMaxLength(80)
                .HasDefaultValue("Parent1.Jpg");
            entity.Property(e => e.Qualification).HasMaxLength(50);
            entity.Property(e => e.RationCardNumber).HasMaxLength(50);
            entity.Property(e => e.Relation).HasMaxLength(100);
            entity.Property(e => e.Sex).HasMaxLength(15);
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiMFeeHeadGroupMaster>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("WDI_M_FeeHeadGroupMaster");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("UniCampus");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GroupName).HasMaxLength(100);
            entity.Property(e => e.GroupType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("FULL PAYMENT")
                .HasComment("FULL PAYMENT OR INSTALLMENTS");
            entity.Property(e => e.PartnerId).HasDefaultValue(1L);
        });

        modelBuilder.Entity<WdiMFeeHeadMaster>(entity =>
        {
            entity.HasKey(e => e.FeeHeadId);

            entity.ToTable("WDI_M_FeeHeadMaster");

            entity.Property(e => e.FeeHeadId).HasColumnName("FeeHeadID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.ConcessionablePercent).HasDefaultValue(0.0);
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FeeHeadName).HasMaxLength(150);
            entity.Property(e => e.FeeReceiptLogo)
                .HasMaxLength(150)
                .HasDefaultValue("FeeHeaderLogo.png");
            entity.Property(e => e.FeeType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("I - Individual, G - Group");
            entity.Property(e => e.FineAmount).HasColumnType("money");
            entity.Property(e => e.FriendlyName).HasMaxLength(200);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.HeadPrefix).HasMaxLength(400);
            entity.Property(e => e.IsConcessionable).HasDefaultValue(false);
            entity.Property(e => e.IsRefundable).HasDefaultValue(false);
            entity.Property(e => e.Iscustomized).HasDefaultValue(false);
            entity.Property(e => e.M2mregTypeId)
                .HasDefaultValue(-1L)
                .HasColumnName("M2MRegTypeID");
            entity.Property(e => e.MappingName).HasMaxLength(400);
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PaymentType).HasMaxLength(60);
            entity.Property(e => e.Pgmid)
                .HasDefaultValue(-1L)
                .HasColumnName("PGMId");
            entity.Property(e => e.ReceiptType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("REGULAR")
                .HasComment("REGULAR, ACKNOWLEDGEMENT");
            entity.Property(e => e.ScholarshipId).HasDefaultValue(-1);
            entity.Property(e => e.SchoolType).HasMaxLength(200);
            entity.Property(e => e.SectionId).HasDefaultValue(-1L);
            entity.Property(e => e.Status).HasDefaultValue(false);
            entity.Property(e => e.TaxConfigMid)
                .HasDefaultValue(-1L)
                .HasColumnName("TaxConfigMID");
            entity.Property(e => e.TaxInclorExcl)
                .HasMaxLength(50)
                .HasDefaultValue("INCLUSIVE")
                .HasColumnName("TaxINCLorEXCL");
            entity.Property(e => e.TypeOfStudent)
                .HasMaxLength(40)
                .HasComment("This has the value 'old' or 'new'");
        });

        modelBuilder.Entity<WdiMFeeHeadsMappingMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_M_Fe__3214EC0702EC869C");

            entity.ToTable("WDI_M_FeeHeadsMappingMaster");
        });

        modelBuilder.Entity<WdiMFinancialYear>(entity =>
        {
            entity.HasKey(e => e.FinancialYearId);

            entity.ToTable("WDI_M_FinancialYears");

            entity.Property(e => e.AuditBy).HasMaxLength(40);
            entity.Property(e => e.AuditDate).HasColumnType("datetime");
            entity.Property(e => e.AuditStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UCBOOKS");
            entity.Property(e => e.FinancialAccountsStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVE");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.FyaccountClousureDate)
                .HasColumnType("datetime")
                .HasColumnName("FYAccountClousureDate");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.UcbfinancialYearId)
                .HasDefaultValue(-1L)
                .HasColumnName("UCBFinancialYearID");
        });

        modelBuilder.Entity<WdiMFpmachine>(entity =>
        {
            entity.ToTable("WDI_M_FPMachines");

            entity.Property(e => e.Installdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MachineDetails).HasMaxLength(200);
            entity.Property(e => e.MachineNo).HasMaxLength(100);
            entity.Property(e => e.MachineType)
                .HasMaxLength(100)
                .HasDefaultValue("FP")
                .HasComment("FP: finger print ; GP : GPS related Device; one partner can have multiple number of devices");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
        });

        modelBuilder.Entity<WdiMGrade>(entity =>
        {
            entity.ToTable("WDI_M_Grades");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ApplicableClassId)
                .HasDefaultValue(0)
                .HasComment("If it is 0 it will be indicated for all classes , other wise it will be class ");
            entity.Property(e => e.Grade).HasMaxLength(8);
            entity.Property(e => e.GradePoint)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<WdiMHostel>(entity =>
        {
            entity.HasKey(e => e.HostelId);

            entity.ToTable("Wdi_M_Hostel");

            entity.Property(e => e.HostelId).HasColumnName("HostelID");
            entity.Property(e => e.HostelName).HasMaxLength(200);
            entity.Property(e => e.HostelType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Boys, Girls, Staff ....  etc");
            entity.Property(e => e.HostelWarden)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMHouseSystem>(entity =>
        {
            entity.HasKey(e => e.HouseId);

            entity.ToTable("WDI_M_HouseSystem");

            entity.Property(e => e.Colour)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Emblem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("default.jpg");
            entity.Property(e => e.House).HasMaxLength(100);
            entity.Property(e => e.Motto).HasMaxLength(200);
        });

        modelBuilder.Entity<WdiMIcsecoCurricularActivity>(entity =>
        {
            entity.HasKey(e => e.CoCurricularAtivityId);

            entity.ToTable("WDI_M_ICSECoCurricularActivities");

            entity.Property(e => e.CoCurricularAtivityId).HasColumnName("CoCurricularAtivityID");
            entity.Property(e => e.CoCurricularActivtyName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<WdiMIcsesubTool>(entity =>
        {
            entity.HasKey(e => e.SubToolId);

            entity.ToTable("WDI_M_ICSESubTools");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SubToolName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMIcsetool>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wdi_M_ICSETools");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ToolId).ValueGeneratedOnAdd();
            entity.Property(e => e.ToolName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMItemDescription>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("WDI_M_ItemDescription");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ContactMobile).HasMaxLength(100);
            entity.Property(e => e.ContactPerson).HasMaxLength(100);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("cloudcampus");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EventStatus)
                .HasMaxLength(100)
                .HasDefaultValue("Active");
            entity.Property(e => e.ExtLinks).HasMaxLength(800);
            entity.Property(e => e.ItemTitle).HasMaxLength(1000);
            entity.Property(e => e.ItemType).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NoticeorRemarks).HasMaxLength(400);
            entity.Property(e => e.Publishdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.WebsiteId).HasColumnName("WebsiteID");
        });

        modelBuilder.Entity<WdiMItemPhoto>(entity =>
        {
            entity.HasKey(e => e.PhotoId);

            entity.ToTable("WDI_M_ItemPhotoes");

            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("unicampus");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsSecondaryDocument).HasColumnName("isSecondaryDocument");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .HasDefaultValue("0000")
                .HasColumnName("title");

            entity.HasOne(d => d.Item).WithMany(p => p.WdiMItemPhotos)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_WDI_M_ItemPhotoes_WDI_M_ItemDescription");
        });

        modelBuilder.Entity<WdiMItemmaster>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_WDI_M_LIBRARYITEMMASTER");

            entity.ToTable("WDI_M_ITEMMASTER");

            entity.Property(e => e.AcHeadId)
                .HasDefaultValue(-1L)
                .HasColumnName("AcHeadID");
            entity.Property(e => e.Academicyearid).HasDefaultValue(-1L);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.ItemName).HasMaxLength(100);
            entity.Property(e => e.ItemType)
                .HasMaxLength(100)
                .HasDefaultValue("LIBRARY")
                .HasComment("this table is serves common item master for unicampus. eventhough it was names as libraryitemmaster we are using it for all");
            entity.Property(e => e.PartnerId).HasColumnName("partnerId");
        });

        modelBuilder.Entity<WdiMLanguage>(entity =>
        {
            entity.HasKey(e => e.LanguageId);

            entity.ToTable("WDI_M_Languages");

            entity.Property(e => e.LanguageId).ValueGeneratedNever();
            entity.Property(e => e.Culture).HasMaxLength(20);
            entity.Property(e => e.LanguageName).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMLeaveMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_LeaveMaster");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.LeaveDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LeaveID");
        });

        modelBuilder.Entity<WdiMLeaveType>(entity =>
        {
            entity.ToTable("WDI_M_LeaveTypes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ApprovedByRole)
                .HasMaxLength(200)
                .HasDefaultValue("USER_PARTNER");
            entity.Property(e => e.AuthorizedByRole).HasMaxLength(200);
            entity.Property(e => e.DaysEligibleMonth).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.DeductionHead).HasDefaultValue(-1);
            entity.Property(e => e.DeductionPercentage).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.EligibleForYear).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.ForwardedByRole).HasMaxLength(200);
            entity.Property(e => e.LeaveType).HasMaxLength(4);
            entity.Property(e => e.LeaveTypeName).HasMaxLength(40);
            entity.Property(e => e.RecommendedByRole)
                .HasMaxLength(200)
                .HasDefaultValue("USER_ADMIN");
        });

        modelBuilder.Entity<WdiMLibraryeligibility>(entity =>
        {
            entity.HasKey(e => e.EligibilityId);

            entity.ToTable("WDI_M_LIBRARYELIGIBILITY");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BookBankFine)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BookBankMaxDays).HasDefaultValue(0);
            entity.Property(e => e.BookBankMaxItems).HasDefaultValue(0);
            entity.Property(e => e.CategoryId).HasDefaultValue(0L);
            entity.Property(e => e.ClassId).HasDefaultValue(-1);
            entity.Property(e => e.Fine).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ItemId).HasDefaultValue(0L);
            entity.Property(e => e.PartnerId).HasColumnName("partnerId");
            entity.Property(e => e.RoleId).HasColumnName("roleId");
        });

        modelBuilder.Entity<WdiMLibraryrack>(entity =>
        {
            entity.HasKey(e => e.RackName).HasName("PK_WDI_M_SCLIBRACKS");

            entity.ToTable("WDI_M_LIBRARYRACKS");

            entity.Property(e => e.RackName).HasMaxLength(100);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.RackId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WdiMLicencing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_LICENCING");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LicenceExpires).HasColumnType("datetime");
            entity.Property(e => e.LicenceId).ValueGeneratedOnAdd();
            entity.Property(e => e.LicenceKey).HasMaxLength(400);
            entity.Property(e => e.LicenceTerm).HasComputedColumnSql("(checksum([LicenceKey],[MacAddress],[PartnerId]))", false);
            entity.Property(e => e.MacAddress).HasMaxLength(100);
            entity.Property(e => e.PreviousChecksum).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMMealMenuConfiguration>(entity =>
        {
            entity.HasKey(e => e.MealiteamId);

            entity.ToTable("Wdi_M_MealMenuConfiguration");

            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.MealitemName).HasMaxLength(500);
            entity.Property(e => e.Mealtype)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalConsumedMealQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMealQtyAllotted).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMealQtyAvailable).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<WdiMMealMenuConfigurationTransactionDetail>(entity =>
        {
            entity.ToTable("Wdi_M_MealMenuConfigurationTransactionDetails");

            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.TotalMealQtyAllotted).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<WdiMMessageFolder>(entity =>
        {
            entity.HasKey(e => new { e.Fname, e.UserId });

            entity.ToTable("WDI_M_MessageFolder");

            entity.Property(e => e.Fname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("FName");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
            entity.Property(e => e.Fid)
                .ValueGeneratedOnAdd()
                .HasColumnName("FID");
        });

        modelBuilder.Entity<WdiMMetricsDetail>(entity =>
        {
            entity.ToTable("WDI_M_MetricsDetails");

            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Smscount).HasColumnName("SMSCount");
        });

        modelBuilder.Entity<WdiMMobileAccessModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId);

            entity.ToTable("WDI_M_MobileAccessModules");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleName).HasMaxLength(500);
            entity.Property(e => e.Partnerid).HasDefaultValue(-1L);
        });

        modelBuilder.Entity<WdiMMtnfeePayRequest>(entity =>
        {
            entity.HasKey(e => e.MtnfeePayRequestId).HasName("wdi_m_MTNFeePayRequest_MTNFeePayRequestId");

            entity.ToTable("wdi_m_MTNFeePayRequest");

            entity.Property(e => e.MtnfeePayRequestId).HasColumnName("MTNFeePayRequestId");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Acno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AdminNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MomTransactionId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PaidBy)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.PptokenId).HasColumnName("PPTokenId");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMMtnfeePayRequestDetail>(entity =>
        {
            entity.HasKey(e => e.MtnfeePayRequestDetailsId).HasName("wdi_m_MTNFeePayRequestDetails_MTNFeePayRequestId");

            entity.ToTable("wdi_m_MTNFeePayRequestDetails");

            entity.Property(e => e.MtnfeePayRequestDetailsId).HasColumnName("MTNFeePayRequestDetailsId");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdminNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.MtnfeePayRequestIdFk).HasColumnName("MTNFeePayRequestId_FK");
        });

        modelBuilder.Entity<WdiMMultiBranchAccess>(entity =>
        {
            entity.HasKey(e => e.AccessId).HasName("PK__WDI_M_Mu__4130D05FEA7AB771");

            entity.ToTable("WDI_M_MultiBranchAccess");

            entity.Property(e => e.Add).HasColumnName("ADD");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(150);
        });

        modelBuilder.Entity<WdiMObjestsmaster>(entity =>
        {
            entity.HasKey(e => e.ObjectId);

            entity.ToTable("WDI_M_OBJESTSMASTER");

            entity.Property(e => e.LvobjectId)
                .HasDefaultValue(-1)
                .HasColumnName("LVObjectId");
            entity.Property(e => e.ObjectDescription).HasMaxLength(200);
            entity.Property(e => e.ObjectModuleId).HasColumnName("ObjectModuleID");
            entity.Property(e => e.ObjectName).HasMaxLength(200);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.SystemVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("V1.0");
        });

        modelBuilder.Entity<WdiMOtpengine>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("WDI_M_OTPENGINE");

            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Otp)
                .HasMaxLength(100)
                .HasColumnName("OTP");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiMPageMaster>(entity =>
        {
            entity.HasKey(e => e.PageId);

            entity.ToTable("WDI_M_PageMaster");

            entity.Property(e => e.PageId)
                .ValueGeneratedNever()
                .HasColumnName("PageID");
            entity.Property(e => e.DisplayPageName)
                .HasMaxLength(100)
                .HasDefaultValue("Home");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.PageName).HasMaxLength(100);
            entity.Property(e => e.PageType).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiMPartner>(entity =>
        {
            entity.HasKey(e => e.PartnerId);

            entity.ToTable("WDI_M_Partners");

            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.AccBalance)
                .HasColumnType("money")
                .HasColumnName("Acc_Balance");
            entity.Property(e => e.ContactMobile).HasMaxLength(50);
            entity.Property(e => e.ContactNo).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(75);
            entity.Property(e => e.ContacteMailAddress).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EncryptedContactNumber).HasMaxLength(256);
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobile).HasMaxLength(256);
            entity.Property(e => e.Guid)
                .HasMaxLength(75)
                .HasColumnName("GUID");
            entity.Property(e => e.LastRenewedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastTransDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PartnerAdress).HasColumnType("ntext");
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.PartnerState).HasComment("2: Reject, 1: Accept, 0: New");
            entity.Property(e => e.PartnerType).HasComment("1:partner; 2:Expert; 3:School;4:Watch2Learn");
            entity.Property(e => e.SenderId)
                .HasMaxLength(500)
                .HasDefaultValue("http://alerts.sinfini.com/api/web2sms.php?username=intense;password=intense5;to=$$mobile$$;sender=SCHOOL;message=$$message$$");
            entity.Property(e => e.SubscriptionDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(40);
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .HasColumnName("website");
        });

        modelBuilder.Entity<WdiMPartnerSiteDetail>(entity =>
        {
            entity.HasKey(e => e.WebsiteId).HasName("PK_WDI_M_PartnerSiteDetails_1");

            entity.ToTable("WDI_M_PartnerSiteDetails");

            entity.Property(e => e.WebsiteId).HasColumnName("WebsiteID");
            entity.Property(e => e.BranchCinno)
                .HasMaxLength(400)
                .HasColumnName("BranchCINNo");
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.BranchGstinno)
                .HasMaxLength(400)
                .HasColumnName("BranchGSTINNo");
            entity.Property(e => e.ContactNumber).HasMaxLength(40);
            entity.Property(e => e.Description)
                .HasMaxLength(600)
                .HasDefaultValue("powered by In10s Technologies")
                .HasColumnName("description");
            entity.Property(e => e.Keywords)
                .HasMaxLength(600)
                .HasDefaultValue("watch2learn.org,watch2learn.in,onlinepatashala.com,epatashala.in,learnsmartskills.com,learnerspot.com")
                .HasColumnName("keywords");
            entity.Property(e => e.ListOfModules).HasMaxLength(1000);
            entity.Property(e => e.Mobile)
                .HasMaxLength(30)
                .HasDefaultValueSql("((123456789))");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SiteUrls)
                .HasMaxLength(600)
                .HasDefaultValue("onlinepatashala.com");
            entity.Property(e => e.Status).HasDefaultValue(false);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasDefaultValue("powered by In10s Technologies")
                .HasColumnName("title");
            entity.Property(e => e.WebSiteHeaderLogo)
                .HasMaxLength(200)
                .HasDefaultValue("HeaderLogo.png");
            entity.Property(e => e.WebsiteAddress)
                .HasMaxLength(200)
                .HasColumnName("Website_Address");
            entity.Property(e => e.WebsiteCaption)
                .HasMaxLength(200)
                .HasColumnName("Website_Caption");
            entity.Property(e => e.WebsiteCss)
                .HasMaxLength(100)
                .HasDefaultValue("abi.css")
                .HasColumnName("Website_Css");
            entity.Property(e => e.WebsiteLogo)
                .HasMaxLength(200)
                .HasColumnName("Website_Logo");
            entity.Property(e => e.WebsiteShortName)
                .HasMaxLength(40)
                .HasColumnName("Website_ShortName");
            entity.Property(e => e.WebsiteTitle)
                .HasMaxLength(200)
                .HasColumnName("Website_Title");
        });

        modelBuilder.Entity<WdiMPaymentExtraDetail>(entity =>
        {
            entity.ToTable("WDI_M_PaymentExtraDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BankNarration).HasMaxLength(150);
            entity.Property(e => e.BankType).HasMaxLength(100);
            entity.Property(e => e.BatchNo)
                .HasMaxLength(100)
                .HasComment("MID Number");
            entity.Property(e => e.CardAndCheckAndDdno)
                .HasMaxLength(50)
                .HasComment("Card and cheque and DD number")
                .HasColumnName("CardAndCheckAndDDNO");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateOfCredit).HasColumnType("datetime");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.ProceedingNumber).HasMaxLength(150);
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .HasComment("RR Number");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValue("Pending");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMPayrollMasterhead>(entity =>
        {
            entity.HasKey(e => e.HeadId).HasName("PK__WDI_M_Pa__EB3F22F0BE885979");

            entity.ToTable("WDI_M_Payroll_Masterheads");

            entity.Property(e => e.HeadId).HasColumnName("HeadID");
            entity.Property(e => e.DeductionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("R")
                .IsFixedLength()
                .HasComment("R - Regular, L - Loan , A - Advance. Default is 'R'.");
            entity.Property(e => e.HeadName).HasMaxLength(200);
            entity.Property(e => e.HeadType).HasMaxLength(20);
        });

        modelBuilder.Entity<WdiMPayrollPartnerHead>(entity =>
        {
            entity.HasKey(e => e.PayRolePartnerHeadId).HasName("PK__WDI_M_Pa__F6897F2A42348715");

            entity.ToTable("WDI_M_Payroll_PartnerHeads");

            entity.Property(e => e.PayRolePartnerHeadId).HasColumnName("PayRolePartnerHeadID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("EDUSYNC");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FormulaMultiplier).HasDefaultValue(1);
            entity.Property(e => e.HeadId).HasColumnName("HeadID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProllTemplateId)
                .HasDefaultValue(-1L)
                .HasColumnName("PRollTemplateId");
            entity.Property(e => e.SalRangeHeads)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.SelectedHeads)
                .HasMaxLength(50)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<WdiMPaytmpgplusrespmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_PAYTMPGPLUSRESPMASTER");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMPeriodMaster>(entity =>
        {
            entity.HasKey(e => e.PeriodMasterIdPk).HasName("WDI_M_PeriodMaster_PeriodID_PKPeriodMasterID_PK");

            entity.ToTable("WDI_M_PeriodMaster");

            entity.Property(e => e.PeriodMasterIdPk).HasColumnName("PeriodMasterID_PK");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PeriodConfigIdFk).HasColumnName("PeriodConfigID_FK");
            entity.Property(e => e.PeriodEndTime).HasMaxLength(50);
            entity.Property(e => e.PeriodId).HasColumnName("PeriodID");
            entity.Property(e => e.PeriodShortName).HasMaxLength(100);
            entity.Property(e => e.PeriodStartTime).HasMaxLength(50);
            entity.Property(e => e.SectionId).HasDefaultValue(-1);

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.WdiMPeriodMasters)
                .HasForeignKey(d => d.AcademicYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WDI_M_PeriodMaster_AcademicYearID");

            entity.HasOne(d => d.Partner).WithMany(p => p.WdiMPeriodMasters)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WDI_M_PeriodMaster_PartnerID");

            entity.HasOne(d => d.PeriodConfigIdFkNavigation).WithMany(p => p.WdiMPeriodMasters)
                .HasForeignKey(d => d.PeriodConfigIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WDI_M_PeriodMaster_PeriodConfigID_FK");
        });

        modelBuilder.Entity<WdiMPgpartnerMerchantDetail>(entity =>
        {
            entity.HasKey(e => e.PartnerMerchantId);

            entity.ToTable("WDI_M_PGPartnerMerchantDetails");

            entity.Property(e => e.PartnerMerchantId).HasColumnName("PartnerMerchantID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LoginId)
                .HasMaxLength(50)
                .HasColumnName("LoginID");
            entity.Property(e => e.MerchantId)
                .HasMaxLength(50)
                .HasColumnName("MerchantID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PaymentGatewayFields).HasColumnType("xml");
            entity.Property(e => e.PaymentGatewayType).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiMPgspecialfeepayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_PGSPECIALFEEPAYMENT");

            entity.Property(e => e.ActualReceiptNoGenerated).HasMaxLength(200);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MerchantTransId)
                .HasMaxLength(200)
                .HasColumnName("MerchantTransID");
            entity.Property(e => e.PaymentRemarks).HasMaxLength(200);
            entity.Property(e => e.PgfeeProcessStatus)
                .HasDefaultValue((byte)0)
                .HasColumnName("PGFeeProcessStatus");
            entity.Property(e => e.PgstatusId).HasColumnName("PGStatusID");
            entity.Property(e => e.ReceiptNo).HasMaxLength(200);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.SpecialFeeReceiptId).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiMPgstatus>(entity =>
        {
            entity.HasKey(e => e.PgstatusId);

            entity.ToTable("WDI_M_PGStatus");

            entity.Property(e => e.PgstatusId).HasColumnName("PGStatusID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentGatewayType).HasMaxLength(50);
            entity.Property(e => e.PgstatusCode)
                .HasMaxLength(50)
                .HasColumnName("PGStatusCode");
            entity.Property(e => e.PgstatusValue)
                .HasMaxLength(50)
                .HasColumnName("PGStatusValue");
        });

        modelBuilder.Entity<WdiMPublisherMaster>(entity =>
        {
            entity.HasKey(e => new { e.Partnerid, e.PublisherName });

            entity.ToTable("WDI_M_PublisherMaster");

            entity.Property(e => e.Partnerid).HasColumnName("PARTNERID");
            entity.Property(e => e.PublisherName).HasMaxLength(100);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address1).HasMaxLength(400);
            entity.Property(e => e.Address2).HasMaxLength(400);
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Fax)
                .HasMaxLength(40)
                .HasColumnName("fax");
            entity.Property(e => e.Mobile).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.Pin)
                .HasMaxLength(40)
                .HasColumnName("pin");
            entity.Property(e => e.PublisherId).ValueGeneratedOnAdd();
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
        });

        modelBuilder.Entity<WdiMQualification>(entity =>
        {
            entity.HasKey(e => e.QualificationId);

            entity.ToTable("WDI_M_Qualification");

            entity.Property(e => e.QualificationId).HasColumnName("QualificationID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Qualification).HasMaxLength(200);
        });

        modelBuilder.Entity<WdiMReligion>(entity =>
        {
            entity.HasKey(e => e.ReligionId);

            entity.ToTable("WDI_M_Religions");

            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.ReligionName).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiMRemark>(entity =>
        {
            entity.HasKey(e => e.RemarkId);

            entity.ToTable("WDI_M_Remarks");

            entity.Property(e => e.RemarkId).HasColumnName("RemarkID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.RemarkCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("1");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<WdiMRolemaster>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_WDI_ROLEMASTER");

            entity.ToTable("WDI_M_ROLEMASTER");

            entity.Property(e => e.RoleDisplayName).HasMaxLength(200);
            entity.Property(e => e.RoleName).HasMaxLength(200);
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<WdiMRoomMaster>(entity =>
        {
            entity.HasKey(e => e.RoomId);

            entity.ToTable("Wdi_M_RoomMaster");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.Assets).HasMaxLength(500);
            entity.Property(e => e.BlockId)
                .HasComment("Block Id load from Block Table")
                .HasColumnName("BlockID");
            entity.Property(e => e.Facilities)
                .HasMaxLength(500)
                .HasComment("Facilities are like wifi,TV,Heat Water... etc");
            entity.Property(e => e.RentAmount).HasColumnType("money");
            entity.Property(e => e.RoomName).HasMaxLength(200);
            entity.Property(e => e.RoomType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Room Type is either normal, delux, AC");
        });

        modelBuilder.Entity<WdiMScholarshipTypeMaster>(entity =>
        {
            entity.HasKey(e => e.ScholarshipId).HasName("PK__WDI_M_Sc__853EC2FCA88A4A60");

            entity.ToTable("WDI_M_ScholarshipTypeMaster");

            entity.Property(e => e.AcademicyearId).HasDefaultValue(-1L);
            entity.Property(e => e.PartnerId).HasDefaultValue(-1L);
            entity.Property(e => e.ScholarshipName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMSchoolLeaveMaster>(entity =>
        {
            entity.HasKey(e => e.LeaveId);

            entity.ToTable("WDI_M_SchoolLeaveMaster");

            entity.Property(e => e.LeaveId).HasColumnName("LeaveID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.LeaveDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveDescription).HasMaxLength(200);
            entity.Property(e => e.LeaveTitle).HasMaxLength(100);
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            entity.Property(e => e.Valid).HasDefaultValue(true);
        });

        modelBuilder.Entity<WdiMSeason>(entity =>
        {
            entity.HasKey(e => e.SeasonId);

            entity.ToTable("WDI_M_Seasons");

            entity.Property(e => e.SeasonId).HasColumnName("SeasonID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("1-True, 0-False");
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("partnerID");
            entity.Property(e => e.SeasonName).HasMaxLength(100);
            entity.Property(e => e.Todate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMSection>(entity =>
        {
            entity.HasKey(e => e.SectionId);

            entity.ToTable("WDI_M_Sections");

            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.OptingSemisters).HasMaxLength(100);
            entity.Property(e => e.SectionCode)
                .HasMaxLength(10)
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SectionName).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiMSemisterMaster>(entity =>
        {
            entity.HasKey(e => e.SemisterId);

            entity.ToTable("Wdi_M_SemisterMaster");

            entity.Property(e => e.SemisterName).HasMaxLength(500);
        });

        modelBuilder.Entity<WdiMSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_Sessions");

            entity.Property(e => e.EndTime).HasMaxLength(20);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LoginUserType)
                .HasMaxLength(100)
                .HasColumnName("loginUserType");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Presenter).HasMaxLength(75);
            entity.Property(e => e.SessionId)
                .HasMaxLength(100)
                .HasColumnName("SessionID");
            entity.Property(e => e.SessionName).HasMaxLength(75);
            entity.Property(e => e.SessionPwd).HasMaxLength(20);
            entity.Property(e => e.StartTime).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<WdiMSkill>(entity =>
        {
            entity.HasKey(e => e.SkillId).HasName("PK_WDI_M_SKILLS1");

            entity.ToTable("WDI_M_SKILLS");

            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SkillName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMSkillschedule>(entity =>
        {
            entity.HasKey(e => e.SkillScheduleId);

            entity.ToTable("WDI_M_SKILLSCHEDULE");

            entity.Property(e => e.SkillScheduleId).HasColumnName("SkillScheduleID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Marks).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiMSmslog>(entity =>
        {
            entity.HasKey(e => e.SmslogId);

            entity.ToTable("WDI_M_SMSLog");

            entity.Property(e => e.SmslogId).HasColumnName("SMSLogID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AttendanceType)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CommTemplateId).HasColumnName("CommTemplateID");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.MobileNo).HasMaxLength(40);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RecipientRelation).HasMaxLength(50);
            entity.Property(e => e.Smstype)
                .HasMaxLength(50)
                .HasColumnName("SMSType");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiMSmstypeMaster>(entity =>
        {
            entity.HasKey(e => e.SmsTypeId);

            entity.ToTable("WDI_M_SMSTypeMaster");

            entity.Property(e => e.SmsTypeId).HasColumnName("SMS_Type_ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.SmsTypeDescription)
                .HasMaxLength(500)
                .HasColumnName("SMS_Type_Description");
            entity.Property(e => e.SmsTypeTitle)
                .HasMaxLength(50)
                .HasColumnName("SMS_Type_Title");
        });

        modelBuilder.Entity<WdiMSpecialEnquiry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_shastrischema.WDI_M_SpecialEnquiries");

            entity.ToTable("WDI_M_SpecialEnquiries");

            entity.Property(e => e.Academicyearid).HasDefaultValue(-1L);
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FeeAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FeePaidDate).HasColumnType("datetime");
            entity.Property(e => e.FeePaidStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Initiated");
            entity.Property(e => e.Feepaidby).HasMaxLength(50);
            entity.Property(e => e.ParticipentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PresentProfession).HasMaxLength(50);
            entity.Property(e => e.ReasonForParticipating).HasMaxLength(200);
            entity.Property(e => e.SourceOfInformation)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SsreceiptNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SSReceiptNo");
            entity.Property(e => e.WhatsAppContact).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiMSpecialfeepayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_SPECIALFEEPAYMENT");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateofDelete).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PaymentRemarks).HasMaxLength(200);
            entity.Property(e => e.ReceiptNo).HasMaxLength(200);
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.SpecialFeeReceiptId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiMSplFeeCategory>(entity =>
        {
            entity.HasKey(e => e.FeeCategoryId);

            entity.ToTable("WDI_M_SplFeeCategories");

            entity.Property(e => e.FeeCategoryId).HasColumnName("FeeCategoryID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FeeCategoryName).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasComment("False - Deleted, True - Active.");
        });

        modelBuilder.Entity<WdiMStreamMaster>(entity =>
        {
            entity.HasKey(e => e.StreamId);

            entity.ToTable("Wdi_M_StreamMaster");

            entity.Property(e => e.StreamId).HasColumnName("streamId");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExaminationPassed)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.StreamDescription)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("streamDescription");
            entity.Property(e => e.StreamName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("streamName");
        });

        modelBuilder.Entity<WdiMStudentFeeDue>(entity =>
        {
            entity.HasKey(e => e.StudentDueNo);

            entity.ToTable("WDI_M_StudentFeeDue");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FeeHeadId).HasColumnName("FeeHeadID");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiMSubTool>(entity =>
        {
            entity.HasKey(e => e.SubToolId);

            entity.ToTable("WDI_M_SubTools");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SubToolName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMSubject>(entity =>
        {
            entity.HasKey(e => e.SubjectId);

            entity.ToTable("WDI_M_Subjects");

            entity.HasIndex(e => e.PartnerId, "Test_Sub");

            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.Elective).HasDefaultValue(false);
            entity.Property(e => e.ElectiveCode).HasMaxLength(10);
            entity.Property(e => e.LanguageType).HasDefaultValue((byte)1);
            entity.Property(e => e.OptingSections).HasMaxLength(1000);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SecondLanguage).HasDefaultValue(false);
            entity.Property(e => e.SubjectName).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiMSubscribeDetail>(entity =>
        {
            entity.ToTable("WDI_M_SubscribeDetails");

            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMSuppliermaster>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__WDI_M_Su__4BE666B40D45F57D");

            entity.ToTable("WDI_M_SUPPLIERMASTER");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address1)
                .HasMaxLength(400)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(400)
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasMaxLength(40)
                .HasColumnName("fax");
            entity.Property(e => e.Mobile)
                .HasMaxLength(30)
                .HasColumnName("mobile");
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnName("phone");
            entity.Property(e => e.Pincode)
                .HasMaxLength(40)
                .HasColumnName("pincode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.SupplierCode).HasMaxLength(100);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.SupplierType)
                .HasMaxLength(20)
                .HasDefaultValue("INVENTORY");
        });

        modelBuilder.Entity<WdiMTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId);

            entity.ToTable("WDI_M_Templates");

            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailTemplateText).HasDefaultValue("");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("0 - General(This should be for entire school), 1 - Staff, 2 - Student,3 - Not Related to Staff or Student");
            entity.Property(e => e.IsGeneral).HasComment("If TRUE then those records will be displayed in Central Location(SendEmailSMS Page).");
            entity.Property(e => e.MessageType).HasComment("0 - General");
            entity.Property(e => e.RelatedTo).HasMaxLength(100);
            entity.Property(e => e.SmstemplateText)
                .HasDefaultValue("")
                .HasColumnName("SMSTemplateText");
            entity.Property(e => e.TemplateColumns).HasMaxLength(2000);
            entity.Property(e => e.TemplateName).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMTenantAdminUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("WDI_M_TenantAdminUsers");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsFirstLogin).HasDefaultValue(true);
            entity.Property(e => e.LastVisit).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Permissions)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Shahs)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHAHS");
            entity.Property(e => e.Sslat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SSLAT");
            entity.Property(e => e.Status)
                .HasDefaultValue(-1)
                .HasComment("-1 : InActive, 0 : Deleted, 1 : Active.");
            entity.Property(e => e.SuserType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SUserType");
            entity.Property(e => e.SusertypeId)
                .HasDefaultValue(-1)
                .HasColumnName("SUsertypeId");
            entity.Property(e => e.SyncStatus).HasComment("Sync Status default it will be False");
            entity.Property(e => e.UserType).HasComment("0-Registered User\r\n1-Partner\r\n2-Admin");
        });

        modelBuilder.Entity<WdiMTenantModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId);

            entity.ToTable("WDI_M_TenantModules");

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModuleName).HasMaxLength(200);
            entity.Property(e => e.ModuleNature).HasMaxLength(50);
            entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(400)
                .HasComment("Description Abou the Module");
            entity.Property(e => e.Status).HasComment("True---1  , false--0");
            entity.Property(e => e.Version).HasDefaultValue(1.0);
        });

        modelBuilder.Entity<WdiMTenantSchema>(entity =>
        {
            entity.HasKey(e => e.TenantSchemaId);

            entity.ToTable("WDI_M_TenantSchemas");

            entity.Property(e => e.TenantSchemaId).HasColumnName("TenantSchemaID");
            entity.Property(e => e.CommunitySchemaDataBase).HasMaxLength(100);
            entity.Property(e => e.CommunitySchemaKey).HasMaxLength(100);
            entity.Property(e => e.CommunitySchemaName).HasMaxLength(100);
            entity.Property(e => e.CommunitySchemaServer).HasMaxLength(100);
            entity.Property(e => e.CommunitySchemaUserId).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SchemaCreatedBy).HasMaxLength(40);
            entity.Property(e => e.SchemaCreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SchemaDataBase).HasMaxLength(100);
            entity.Property(e => e.SchemaKey)
                .HasMaxLength(100)
                .HasComment("Shema Key Means saving the Password of Schema.");
            entity.Property(e => e.SchemaModifiedBy).HasMaxLength(40);
            entity.Property(e => e.SchemaModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemaName).HasMaxLength(100);
            entity.Property(e => e.SchemaServer)
                .HasMaxLength(100)
                .HasDefaultValue("localhost");
            entity.Property(e => e.SchemaStatus)
                .HasMaxLength(20)
                .HasDefaultValue("initiated")
                .HasComment("DefaultValue - Initiated , Created - Created, Updated - Updated, Deleted - Deleted , archived - archived");
            entity.Property(e => e.SchemaUserId).HasMaxLength(100);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiMTenantchanneltemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WDI_M_CPTEXTTEMPLATES_1");

            entity.ToTable("WDI_M_TENANTCHANNELTEMPLATES");

            entity.Property(e => e.Cpmailtemplateformat)
                .HasColumnType("ntext")
                .HasColumnName("CPMAILTEMPLATEFORMAT");
            entity.Property(e => e.Cpnotificationtemplateformat)
                .HasMaxLength(1000)
                .HasColumnName("CPNOTIFICATIONTEMPLATEFORMAT");
            entity.Property(e => e.CptemplateUniqueId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CPTemplateUniqueId");
            entity.Property(e => e.Cptexttemplateformat)
                .HasMaxLength(2000)
                .HasColumnName("CPTEXTTEMPLATEFORMAT");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifyBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateFriendlyName).HasMaxLength(150);
            entity.Property(e => e.TemplateTypeGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMTenantrolemaster>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_WDI_CPROLEMASTER");

            entity.ToTable("WDI_M_TENANTROLEMASTER");

            entity.Property(e => e.RoleDisplayName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<WdiMTenanttemplatetypegroup>(entity =>
        {
            entity.ToTable("WDI_M_TENANTTEMPLATETYPEGROUPS");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateTypeDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TemplateTypeGroup)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMTicket>(entity =>
        {
            entity.HasKey(e => e.IdPk).HasName("PK__WDI_M_Ti__8B63902ECAD4D438");

            entity.ToTable("WDI_M_Ticket");

            entity.Property(e => e.IdPk).HasColumnName("ID_PK");
            entity.Property(e => e.AssignedTo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModuleIdFk).HasColumnName("ModuleID_FK");
            entity.Property(e => e.PartnerIdFk).HasColumnName("PartnerID_FK");
            entity.Property(e => e.PostedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.StatusIdFk).HasColumnName("StatusID_FK");
            entity.Property(e => e.TicketDescription).IsUnicode(false);
            entity.Property(e => e.TicketId)
                .HasMaxLength(200)
                .HasColumnName("TicketID");
            entity.Property(e => e.TicketServerityLevel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TicketTypeIdFk).HasColumnName("TicketTypeID_FK");
            entity.Property(e => e.UpdatedBy).IsUnicode(false);

            entity.HasOne(d => d.ModuleIdFkNavigation).WithMany(p => p.WdiMTickets)
                .HasForeignKey(d => d.ModuleIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_M_Tic__Modul__5F9F5828");

            entity.HasOne(d => d.PartnerIdFkNavigation).WithMany(p => p.WdiMTickets)
                .HasForeignKey(d => d.PartnerIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_M_Tic__Partn__5EAB33EF");

            entity.HasOne(d => d.StatusIdFkNavigation).WithMany(p => p.WdiMTickets)
                .HasForeignKey(d => d.StatusIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_M_Tic__Statu__60937C61");

            entity.HasOne(d => d.TicketTypeIdFkNavigation).WithMany(p => p.WdiMTickets)
                .HasForeignKey(d => d.TicketTypeIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_M_Tic__Ticke__6187A09A");
        });

        modelBuilder.Entity<WdiMTicketStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__WDI_M_Ti__C8EE2043C74A5E10");

            entity.ToTable("WDI_M_TicketStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<WdiMTicketType>(entity =>
        {
            entity.HasKey(e => e.TicketTypeId).HasName("PK__WDI_M_Ti__6CD68451A8C25464");

            entity.ToTable("WDI_M_TicketType");

            entity.Property(e => e.TicketTypeId).HasColumnName("TicketTypeID");
            entity.Property(e => e.TicketTypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<WdiMTodolist>(entity =>
        {
            entity.ToTable("Wdi_M_Todolist");

            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("category either     Personal /  Official")
                .HasColumnName("category");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Item)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Pending  ; Completed ");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMTool>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wdi_M_Tools");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ToolId).ValueGeneratedOnAdd();
            entity.Property(e => e.ToolName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMTraismstemplateMaster>(entity =>
        {
            entity.ToTable("WDI_M_TRAISMSTemplateMaster");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifyBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateFormat).HasMaxLength(1000);
            entity.Property(e => e.TemplateFriendlyName).HasMaxLength(150);
            entity.Property(e => e.TraiTemplateid)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMTransportlocationmaster>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.ToTable("WDI_M_TRANSPORTLOCATIONMASTER");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.DropTime).HasMaxLength(200);
            entity.Property(e => e.LocationLatitude).HasMaxLength(100);
            entity.Property(e => e.LocationLongitude).HasMaxLength(100);
            entity.Property(e => e.LocationOrder).HasColumnName("locationOrder");
            entity.Property(e => e.Locations).HasMaxLength(100);
            entity.Property(e => e.OnewayFare).HasColumnType("money");
            entity.Property(e => e.PickupTime).HasMaxLength(200);
            entity.Property(e => e.TwowayFare).HasColumnType("money");
        });

        modelBuilder.Entity<WdiMTransportroutemaster>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PK_WDI_M_TRANSPORTROUTEMASTER_1");

            entity.ToTable("WDI_M_TRANSPORTROUTEMASTER");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.EndPoint).HasMaxLength(100);
            entity.Property(e => e.EndPointLatitude).HasMaxLength(100);
            entity.Property(e => e.EndPointLongitude).HasMaxLength(100);
            entity.Property(e => e.RouteName).HasMaxLength(100);
            entity.Property(e => e.StartPoint).HasMaxLength(100);
            entity.Property(e => e.StartPointLatitude).HasMaxLength(100);
            entity.Property(e => e.StartPointLongitude).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMTransportvehiclemaster>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK_WDI_M_TRANSPORTVEHICLEMASTER_1");

            entity.ToTable("WDI_M_TRANSPORTVEHICLEMASTER");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Color).HasMaxLength(100);
            entity.Property(e => e.Cost).HasMaxLength(100);
            entity.Property(e => e.DealerAddress).HasMaxLength(400);
            entity.Property(e => e.LicenceRenewalDate).HasColumnType("datetime");
            entity.Property(e => e.LicenseNumber).HasMaxLength(100);
            entity.Property(e => e.Mileage).HasMaxLength(100);
            entity.Property(e => e.Model).HasMaxLength(100);
            entity.Property(e => e.Permit).HasMaxLength(100);
            entity.Property(e => e.PollutionCheckduedate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.RegistrationNumber).HasMaxLength(100);
            entity.Property(e => e.VehicleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vname)
                .HasMaxLength(100)
                .HasColumnName("VName");
            entity.Property(e => e.Vtype)
                .HasMaxLength(100)
                .HasColumnName("VType");
            entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiMUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_OCSP_M_Users");

            entity.ToTable("WDI_M_Users");

            entity.HasIndex(e => e.UserId, "idx_temp_userdetUSERS");

            entity.Property(e => e.UserId).HasMaxLength(40);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsFirstLogin).HasDefaultValue(true);
            entity.Property(e => e.LastVisit).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Permissions).HasMaxLength(40);
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Shahs)
                .HasMaxLength(400)
                .HasColumnName("SHAHS");
            entity.Property(e => e.Sslat)
                .HasMaxLength(100)
                .HasColumnName("SSLAT");
            entity.Property(e => e.Status)
                .HasDefaultValue(-1)
                .HasComment("-1 : InActive, 0 : Deleted, 1 : Active.");
            entity.Property(e => e.SuserType)
                .HasMaxLength(200)
                .HasColumnName("SUserType");
            entity.Property(e => e.SusertypeId)
                .HasDefaultValue(-1)
                .HasColumnName("SUsertypeId");
            entity.Property(e => e.SyncStatus).HasComment("Sync Status default it will be False");
            entity.Property(e => e.UserType).HasComment("0-Registered User\n1-Partner\n2-Admin");
        });

        modelBuilder.Entity<WdiMUseraccesspermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_USERACCESSPERMISSIONS");

            entity.Property(e => e.Add).HasColumnName("ADD");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasMaxLength(100);
            entity.Property(e => e.UserAccessId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiMUseridentity>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__WDI_M_US__1788CC4CE9A16BD7");

            entity.ToTable("WDI_M_USERIDENTITIES");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnrollNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Rfid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RFID");
            entity.Property(e => e.Ssid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SSID");
        });

        modelBuilder.Entity<WdiMUserssecure>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_UCB_M_USERSSECURE");

            entity.ToTable("WDI_M_USERSSECURE");

            entity.Property(e => e.UserId).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UCBOOKS");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sslat)
                .HasMaxLength(100)
                .HasColumnName("SSLAT");
        });

        modelBuilder.Entity<WdiMVechicletype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_Vechicletypes");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.VechicleType).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMVehicleExpense>(entity =>
        {
            entity.HasKey(e => e.ExpensesId).HasName("PK__WDI_M_Ve__DFC8A07CFDA0580E");

            entity.ToTable("WDI_M_VehicleExpenses");

            entity.Property(e => e.ExpensesId).HasColumnName("ExpensesID");
            entity.Property(e => e.Amount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Createdate).HasColumnType("datetime");
            entity.Property(e => e.CurrentReading)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpensesType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasMaxLength(50);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.VehicleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiMView>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_M_Views");

            entity.Property(e => e.Defaulttablename)
                .HasMaxLength(100)
                .HasColumnName("DEFAULTTABLENAME");
            entity.Property(e => e.Displaytablename)
                .HasMaxLength(100)
                .HasColumnName("DISPLAYTABLENAME");
        });

        modelBuilder.Entity<WdiMVisitorLog>(entity =>
        {
            entity.HasKey(e => e.VisitorId);

            entity.ToTable("WDI_M_VisitorLog");

            entity.Property(e => e.VisitorId).HasColumnName("VisitorID");
            entity.Property(e => e.Address).HasMaxLength(400);
            entity.Property(e => e.EmailId)
                .HasMaxLength(200)
                .HasColumnName("EmailID");
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobileNo).HasMaxLength(256);
            entity.Property(e => e.VisitorName).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiMWebsitePage>(entity =>
        {
            entity.HasKey(e => e.WebsitePageId);

            entity.ToTable("WDI_M_WebsitePages");

            entity.Property(e => e.Custompagename)
                .HasMaxLength(50)
                .HasDefaultValue("CUSTOMPAGE")
                .HasColumnName("custompagename");
            entity.Property(e => e.DateCreated).HasMaxLength(100);
            entity.Property(e => e.IsMainPage).HasColumnName("isMainPage");
            entity.Property(e => e.PageId).HasColumnName("PageID");
            entity.Property(e => e.Sequencenumber).HasColumnName("sequencenumber");
            entity.Property(e => e.ShortText).HasMaxLength(500);
            entity.Property(e => e.WebsiteId).HasColumnName("WebsiteID");
        });

        modelBuilder.Entity<WdiTAbsent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_Absent");

            entity.HasIndex(e => new { e.UserId, e.DateOfAbsent, e.Reason, e.AcademicYearId }, "NCI_AB001");

            entity.HasIndex(e => new { e.UserId, e.DateOfAbsent, e.AcademicYearId }, "idx_temp_useriddateABS");

            entity.HasIndex(e => new { e.SchoolId, e.AcademicYearId, e.DateOfAbsent }, "nonclusteredwdi_t_absent").IsDescending(false, true, true);

            entity.Property(e => e.AbsentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AbsentID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UniCampus");
            entity.Property(e => e.DateOfAbsent).HasColumnType("datetime");
            entity.Property(e => e.OtherReason).HasMaxLength(200);
            entity.Property(e => e.Reason).HasMaxLength(200);
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            entity.Property(e => e.UserId)
                .HasMaxLength(80)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTAccountDet>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("WDI_T_AccountDet");

            entity.Property(e => e.UserId).HasMaxLength(40);
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.AdmissionNo).HasMaxLength(100);
            entity.Property(e => e.AdmissionReference).HasMaxLength(50);
            entity.Property(e => e.AppNotificationOnly).HasComment(" 0 --- No Need App Notifications  ;   1 --- Need App Notifications..");
            entity.Property(e => e.BloodGroup).HasMaxLength(100);
            entity.Property(e => e.BoardAdmNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ChildInfoId)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId).HasMaxLength(100);
            entity.Property(e => e.Empid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobileNo).HasMaxLength(256);
            entity.Property(e => e.EnquiryIncharge).HasMaxLength(100);
            entity.Property(e => e.EnrollNo).ValueGeneratedOnAdd();
            entity.Property(e => e.ExtraFields).HasColumnType("xml");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("FName");
            entity.Property(e => e.GoogleAppUserRegId).HasMaxLength(500);
            entity.Property(e => e.IdentificationMarks1).HasMaxLength(200);
            entity.Property(e => e.IdentificationMarks2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Img)
                .HasMaxLength(100)
                .HasDefaultValue("UserImage.jpg");
            entity.Property(e => e.IsEnrolledInApp).HasDefaultValue((byte)0);
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .HasColumnName("LName");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.Mail).HasDefaultValue(false);
            entity.Property(e => e.Medium).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(100);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.MotherTongue).HasMaxLength(50);
            entity.Property(e => e.Nationality).HasMaxLength(100);
            entity.Property(e => e.PermanentAddress).HasMaxLength(500);
            entity.Property(e => e.PermanentCity).HasMaxLength(100);
            entity.Property(e => e.PermanentPostalCode).HasMaxLength(100);
            entity.Property(e => e.PermanentState).HasMaxLength(100);
            entity.Property(e => e.Placeofbirth)
                .HasMaxLength(100)
                .HasColumnName("PLACEOFBIRTH");
            entity.Property(e => e.PostalCode).HasMaxLength(100);
            entity.Property(e => e.PresentAddress).HasMaxLength(500);
            entity.Property(e => e.PresentCity).HasMaxLength(100);
            entity.Property(e => e.PreviousClass).HasMaxLength(50);
            entity.Property(e => e.PreviousClassPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PreviousClassTotalMarks).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.PreviousInstituteDetails).HasColumnType("xml");
            entity.Property(e => e.PreviousSchoolBoard).HasMaxLength(100);
            entity.Property(e => e.PreviousSchoolName).HasMaxLength(200);
            entity.Property(e => e.ProfileImagePath).HasMaxLength(200);
            entity.Property(e => e.RegisteredDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RouteType).HasMaxLength(50);
            entity.Property(e => e.ScholarShipApplied).HasMaxLength(30);
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            entity.Property(e => e.SourceOfEnquiry).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.StudentAdmissionType)
                .HasMaxLength(50)
                .HasDefaultValue("Regular");
            entity.Property(e => e.StudentType)
                .HasMaxLength(50)
                .HasDefaultValue("DAY SCHOLAR")
                .HasComment("'DAY SCHOLAR' OR 'RESIDENTIAL'");
            entity.Property(e => e.SubCaste).HasMaxLength(50);
            entity.Property(e => e.SyncStatus).HasDefaultValue(false);
            entity.Property(e => e.VerificationCode).HasMaxLength(50);
            entity.Property(e => e.Website)
                .HasMaxLength(200)
                .HasColumnName("website");
        });

        modelBuilder.Entity<WdiTAccountTransaction>(entity =>
        {
            entity.HasKey(e => e.TransId);

            entity.ToTable("WDI_T_AccountTransactions");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CrAmount).HasColumnType("money");
            entity.Property(e => e.CrClosingBalance).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.DrAmount).HasColumnType("money");
            entity.Property(e => e.DrClosingBalance).HasColumnType("money");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.Labour).HasColumnType("money");
            entity.Property(e => e.M2mtransId)
                .HasDefaultValue(-1L)
                .HasColumnName("M2MTransId");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Narration).HasMaxLength(600);
            entity.Property(e => e.OrganizationId).HasDefaultValue(-1L);
            entity.Property(e => e.PartnerId).HasDefaultValue(-1L);
            entity.Property(e => e.TranRefNo)
                .HasMaxLength(200)
                .HasColumnName("Tran_RefNo");
            entity.Property(e => e.UcbfinancialYearId)
                .HasDefaultValue(-1L)
                .HasColumnName("UCBFinancialYearID");
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNo).HasMaxLength(100);
            entity.Property(e => e.VoucherType)
                .HasMaxLength(400)
                .HasComment("Payment,Receipt,Contra,Sales,Purchase");
        });

        modelBuilder.Entity<WdiTActionLog>(entity =>
        {
            entity.HasKey(e => e.Logid);

            entity.ToTable("WDI_T_ActionLog");

            entity.Property(e => e.Logid).HasColumnName("logid");
            entity.Property(e => e.Action)
                .HasMaxLength(200)
                .HasColumnName("action");
            entity.Property(e => e.Actionby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("actionby");
            entity.Property(e => e.Actionfor).HasColumnName("actionfor");
            entity.Property(e => e.Actiontype)
                .HasMaxLength(100)
                .HasColumnName("actiontype");
            entity.Property(e => e.Logdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("logdate");
        });

        modelBuilder.Entity<WdiTAdjustFacultyPeriodTimetable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_AdjustFacultyPeriodTimetable");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PeriodId).HasColumnName("PeriodID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SourceUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SourceUserID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pending");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTAdmissionEnquiry>(entity =>
        {
            entity.HasKey(e => e.EnquiryId);

            entity.ToTable("WDI_T_AdmissionEnquiry");

            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EnquiryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Medium).HasMaxLength(4);
            entity.Property(e => e.OtherEnquiryDetails).HasMaxLength(2000);
            entity.Property(e => e.RejectReason).HasMaxLength(1000);
            entity.Property(e => e.StudentName).HasMaxLength(200);
            entity.Property(e => e.VisitorId).HasColumnName("VisitorID");
        });

        modelBuilder.Entity<WdiTApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WDI_T_Applications_1");

            entity.ToTable("WDI_T_Applications");

            entity.HasIndex(e => e.ApplicationNo, "ApplicationNo_Index");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Address)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.AdmissionType).HasMaxLength(50);
            entity.Property(e => e.AdmissionYear).HasMaxLength(50);
            entity.Property(e => e.AppAmountPaidDate).HasColumnType("datetime");
            entity.Property(e => e.AppAmountPaymentReference).HasMaxLength(100);
            entity.Property(e => e.ApplicationAmount).HasColumnType("money");
            entity.Property(e => e.ApplicationReceiptNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CommittedFee).HasMaxLength(50);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("website");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailId).HasMaxLength(100);
            entity.Property(e => e.EncryptedContactNumber).HasMaxLength(256);
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobile).HasMaxLength(256);
            entity.Property(e => e.EncryptedParentEmailId).HasMaxLength(256);
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.EnquiryIncharge).HasMaxLength(100);
            entity.Property(e => e.ExtraActivities).HasColumnType("xml");
            entity.Property(e => e.ExtraFields).HasColumnType("xml");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("FName");
            entity.Property(e => e.FollowupDetails).HasMaxLength(100);
            entity.Property(e => e.HallTicketNumber).HasMaxLength(50);
            entity.Property(e => e.Hobbies).HasMaxLength(150);
            entity.Property(e => e.IdentificationMarks1).HasMaxLength(200);
            entity.Property(e => e.IdentificationMarks2).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .HasColumnName("LName");
            entity.Property(e => e.MedicalComplications).HasMaxLength(100);
            entity.Property(e => e.Medium).HasMaxLength(50);
            entity.Property(e => e.MigratePartnerId).HasColumnName("MigratePartnerID");
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Nationality).HasMaxLength(100);
            entity.Property(e => e.OtherFields).HasColumnType("xml");
            entity.Property(e => e.ParentEmailId)
                .HasMaxLength(100)
                .HasColumnName("ParentEmailID");
            entity.Property(e => e.ParentIncomeRange).HasMaxLength(100);
            entity.Property(e => e.ParentName).HasMaxLength(75);
            entity.Property(e => e.ParentOccupation).HasMaxLength(50);
            entity.Property(e => e.ParentQualification).HasMaxLength(50);
            entity.Property(e => e.ParentRelation).HasMaxLength(50);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(30)
                .HasDefaultValue("Offline");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PreviousClass).HasMaxLength(50);
            entity.Property(e => e.PreviousClassPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PreviousClassTotalMarks).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.PreviousGrade).HasMaxLength(20);
            entity.Property(e => e.PreviousSchoolBoard).HasMaxLength(100);
            entity.Property(e => e.PreviousSchoolName).HasMaxLength(200);
            entity.Property(e => e.ReasonForLeave).HasMaxLength(100);
            entity.Property(e => e.RegAmountPaidDate).HasColumnType("datetime");
            entity.Property(e => e.RegAmountPaymentReference).HasMaxLength(100);
            entity.Property(e => e.RegistrationAmount).HasColumnType("money");
            entity.Property(e => e.Result)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ScholarShipType).HasMaxLength(200);
            entity.Property(e => e.SourceOfEnquiry).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasComment("Received\r\nRejected\r\nShortlisted\r\nConfirmed");
            entity.Property(e => e.StudentQualification).HasMaxLength(50);
            entity.Property(e => e.UserIdAllotted)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.XeroxCopies).HasDefaultValue(0);
            entity.Property(e => e.XmlData).HasColumnType("xml");
        });

        modelBuilder.Entity<WdiTApplicationFollowup>(entity =>
        {
            entity.HasKey(e => e.FollowupId);

            entity.ToTable("WDI_T_ApplicationFollowup");

            entity.Property(e => e.FollowupId).HasColumnName("FollowupID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.FollowupDetails).HasMaxLength(500);
            entity.Property(e => e.FollowupType).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<WdiTAssessmentTransction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_AssessmentTransction");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AssessId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AssessID");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTAttendancelog>(entity =>
        {
            entity.ToTable("WDI_T_ATTENDANCELOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EnrollNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecordTime)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTBankTransaction>(entity =>
        {
            entity.HasKey(e => e.Sno);

            entity.ToTable("WDI_T_BankTransactions");

            entity.Property(e => e.Sno).HasColumnName("SNO");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AccNumber).HasColumnName("Acc_Number");
            entity.Property(e => e.Amount)
                .HasDefaultValue(0.00m)
                .HasColumnType("money");
            entity.Property(e => e.DateOfTrans).HasColumnType("datetime");
            entity.Property(e => e.RefDetails)
                .HasMaxLength(100)
                .HasColumnName("Ref_Details");
            entity.Property(e => e.TransSource)
                .HasMaxLength(100)
                .HasColumnName("Trans_Source");
            entity.Property(e => e.TransType)
                .HasMaxLength(2)
                .HasColumnName("Trans_Type");
        });

        modelBuilder.Entity<WdiTBatchAttendance>(entity =>
        {
            entity.HasKey(e => e.BatchAttendaceId).HasName("WDI_T_BatchAttendance_Id");

            entity.ToTable("WDI_T_BatchAttendance");

            entity.Property(e => e.AbsentDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTBatchAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.BatchAttDetailsId);

            entity.ToTable("WDI_T_BatchAttendanceDetails");

            entity.Property(e => e.BatchAttDetailsId).HasColumnName("BatchAttDetailsID");
            entity.Property(e => e.AttDate).HasColumnType("datetime");
            entity.Property(e => e.BatchId).HasColumnName("BatchID");
            entity.Property(e => e.FacultyUserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FacultyUserID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTBatchPeriodAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.PeriodAttDetailsId);

            entity.ToTable("WDI_T_BatchPeriodAttendanceDetails");

            entity.Property(e => e.PeriodAttDetailsId).HasColumnName("PeriodAttDetailsID");
            entity.Property(e => e.AttDate).HasColumnType("datetime");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.FacultyUserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FacultyUserID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTBranchRegister>(entity =>
        {
            entity.HasKey(e => e.BranchRegisterId).HasName("PK_Table_2");

            entity.ToTable("WDI_T_BranchRegister");

            entity.Property(e => e.AdditionalInfo).HasMaxLength(1500);
            entity.Property(e => e.AllotedAdmissionNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AllotedUserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AllotedUserID");
            entity.Property(e => e.InwardOrOutward).HasComment("1 means Inward , 2 means Outward");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.RegisterCode).HasMaxLength(50);
            entity.Property(e => e.RequestApprovedBy).HasMaxLength(50);
            entity.Property(e => e.RequestApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RequestFromBranchTitle).HasMaxLength(100);
            entity.Property(e => e.RequestFromUser).HasMaxLength(50);
            entity.Property(e => e.RequestMode).HasMaxLength(50);
            entity.Property(e => e.RequestRaisedBy).HasMaxLength(50);
            entity.Property(e => e.RequestStatus)
                .HasMaxLength(50)
                .HasDefaultValue("INITIATED");
            entity.Property(e => e.RequestToBranchTitle).HasMaxLength(100);
            entity.Property(e => e.RequestToUser).HasMaxLength(50);
            entity.Property(e => e.RequestType)
                .HasMaxLength(80)
                .HasDefaultValue("BranchTransfer");
        });

        modelBuilder.Entity<WdiTBranchWiseStudentDue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_BranchWiseStudentDues");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.ActualFee).HasColumnType("money");
            entity.Property(e => e.AdmissionNo).HasMaxLength(100);
            entity.Property(e => e.AfterConcession).HasColumnType("money");
            entity.Property(e => e.Class).HasMaxLength(100);
            entity.Property(e => e.ConcessionAmount).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DueAmount).HasColumnType("money");
            entity.Property(e => e.FatherName).HasMaxLength(100);
            entity.Property(e => e.FeeHeadName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MobileNo).HasMaxLength(20);
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTBranchwisefeeCollection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_BranchwisefeeCollection");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.Balance).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.BankDeposit).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CashBalance).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ClosingBalance).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Expenditure).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InternalTransfer).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NetCash).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.OnlineCollection).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TechnoCash).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TotalCollection).HasColumnType("decimal(15, 2)");
        });

        modelBuilder.Entity<WdiTBreak>(entity =>
        {
            entity.HasKey(e => e.BreakIdPk).HasName("WDI_T_Breaks_BreakID_PK");

            entity.ToTable("WDI_T_Breaks");

            entity.Property(e => e.BreakIdPk).HasColumnName("BreakID_PK");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.BreakAfterPeriodId).HasColumnName("BreakAfterPeriodID");
            entity.Property(e => e.BreakTitle).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedById)
                .HasMaxLength(40)
                .HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedById)
                .HasMaxLength(40)
                .HasColumnName("ModifiedByID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PeriodConfigIdFk).HasColumnName("PeriodConfigID_FK");
            entity.Property(e => e.SectionId).HasDefaultValue(-1);

            entity.HasOne(d => d.PeriodConfigIdFkNavigation).WithMany(p => p.WdiTBreaks)
                .HasForeignKey(d => d.PeriodConfigIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WDI_T_Breaks_PeriodConfigID_FK");
        });

        modelBuilder.Entity<WdiTBudgetAccount>(entity =>
        {
            entity.HasKey(e => e.TargetTranId);

            entity.ToTable("WDI_T_BudgetAccounts");

            entity.Property(e => e.TargetTranId).HasColumnName("TargetTranID");
            entity.Property(e => e.AccHeadItems).HasMaxLength(1000);
            entity.Property(e => e.TargetId).HasColumnName("TargetID");
        });

        modelBuilder.Entity<WdiTCalendarEvent>(entity =>
        {
            entity.HasKey(e => e.CalendarEventId);

            entity.ToTable("WDI_T_CalendarEvents");

            entity.Property(e => e.CalendarEventId).HasColumnName("CalendarEventID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Color).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RemainderTime).HasMaxLength(20);
            entity.Property(e => e.Status).HasComment("0-Pending, 1-Completed, 2 - Cancelled");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<WdiTCallBackDetail>(entity =>
        {
            entity.HasKey(e => e.CallBackId);

            entity.ToTable("WDI_T_CallBackDetails");

            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExtraFields).HasColumnType("xml");
            entity.Property(e => e.RequestUrl).HasColumnName("RequestURL");
            entity.Property(e => e.ResPonseUrl).HasColumnName("ResPonseURL");
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTCceareaMaster>(entity =>
        {
            entity.HasKey(e => e.AreaId).HasName("WDI_T_CCEAreaMaster_AreaId");

            entity.ToTable("WDI_T_CCEAreaMaster");

            entity.Property(e => e.AreaName).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTCceclassmappingdetail>(entity =>
        {
            entity.HasKey(e => e.MappedClassId);

            entity.ToTable("WDI_T_CCECLASSMAPPINGDETAILS");

            entity.Property(e => e.MappedClassId).HasColumnName("MappedClassID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PromotedClass).HasDefaultValue(-1);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTCceexamsMapping>(entity =>
        {
            entity.HasKey(e => e.MappedExamId);

            entity.ToTable("WDI_T_CCEExamsMapping");

            entity.Property(e => e.MappedExamId).HasColumnName("MappedExamID");
            entity.Property(e => e.AssesmentType).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExamName).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTCcefieldMaster>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("WDI_T_CCEFieldMaster_FieldId");

            entity.ToTable("WDI_T_CCEFieldMaster");

            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.ShortCode).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTCcemasterTemplate>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("WDI_T_CCEMasterTemplate_ExamId");

            entity.ToTable("WDI_T_CCEMasterTemplate");

            entity.Property(e => e.AssesmentType).HasMaxLength(40);
            entity.Property(e => e.Cgpa).HasColumnName("CGPA");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExamName).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTCcetermMaster>(entity =>
        {
            entity.HasKey(e => e.TermMasterId).HasName("WDI_M_TermMaster_TermMasterId");

            entity.ToTable("WDI_T_CCETermMaster");

            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.TermName).HasMaxLength(100);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTCcpartnerReportTemplate>(entity =>
        {
            entity.HasKey(e => e.CcpartnerReportTemplateId).HasName("PK_CCPartnerReportTemplates");

            entity.ToTable("WDI_T_CCPartnerReportTemplates");

            entity.Property(e => e.CcpartnerReportTemplateId).HasColumnName("CCPartnerReportTemplateID");
            entity.Property(e => e.CcreportTemplateId).HasColumnName("CCReportTemplateID");
            entity.Property(e => e.Defaultxml).HasColumnName("defaultxml");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RelatedTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.XsltemplateText).HasColumnName("XSLTemplateText");
        });

        modelBuilder.Entity<WdiTCertificateTypesDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_CertificateTypesData");

            entity.Property(e => e.CertificateType).HasMaxLength(50);
            entity.Property(e => e.ConcessionAvailed).HasMaxLength(50);
            entity.Property(e => e.Conductness).HasMaxLength(50);
            entity.Property(e => e.Createdby).HasMaxLength(50);
            entity.Property(e => e.Createddate).HasColumnType("datetime");
            entity.Property(e => e.Ctid)
                .HasMaxLength(50)
                .HasColumnName("CTId");
            entity.Property(e => e.DateofApp).HasMaxLength(50);
            entity.Property(e => e.DateofIssue).HasMaxLength(50);
            entity.Property(e => e.Duestatus).HasMaxLength(50);
            entity.Property(e => e.Extrafields)
                .HasColumnType("xml")
                .HasColumnName("EXTRAFIELDS");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Ncccadet)
                .HasMaxLength(50)
                .HasColumnName("NCCCadet");
            entity.Property(e => e.Profilestatus).HasMaxLength(50);
            entity.Property(e => e.Reason).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.SerialNo).HasMaxLength(50);
            entity.Property(e => e.Studentfailed).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTCheckClasswiseAttendance>(entity =>
        {
            entity.HasKey(e => e.CheckSid).HasName("PK__WDI_T_Ch__7F723CD236FD2892");

            entity.ToTable("WDI_T_CheckClasswiseAttendance");

            entity.Property(e => e.CheckSid).HasColumnName("CheckSID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy).HasMaxLength(200);
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.StatusClass).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiTClassTermMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_T_Cl__3214EC078B6252CC");

            entity.ToTable("WDI_T_ClassTermMappings");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifyBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTClassWiseExaminationMapping>(entity =>
        {
            entity.HasKey(e => e.ClassWiseExaminationMappingId).HasName("ClassWiseExaminationMappingId_PK");

            entity.ToTable("WDI_T_ClassWiseExaminationMapping");

            entity.Property(e => e.MasterExamName)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTCoCurricularActivitiyGrade>(entity =>
        {
            entity.HasKey(e => e.CoCurricularActivitiyGradeId).HasName("wdi_t_CoCurricularActivitiyGrades_CoCurricularActivitiyGradeId");

            entity.ToTable("wdi_t_CoCurricularActivitiyGrades");

            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTCoScholasticGrade>(entity =>
        {
            entity.HasKey(e => e.CoScholasticGradeId).HasName("WDI_T_CoScholasticGrades_CoScholasticGradeId");

            entity.ToTable("WDI_T_CoScholasticGrades");

            entity.Property(e => e.Grade).HasMaxLength(4);
            entity.Property(e => e.MaxGradePoint).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.MinGradePoint).HasColumnType("decimal(18, 1)");
        });

        modelBuilder.Entity<WdiTConcessionDetail>(entity =>
        {
            entity.HasKey(e => e.ConcessionDetailsId);

            entity.ToTable("WDI_T_ConcessionDetails");

            entity.Property(e => e.ConcessionDetailsId).HasColumnName("ConcessionDetailsID");
            entity.Property(e => e.ActionBy).HasMaxLength(100);
            entity.Property(e => e.ActionDate).HasComment("Action may be Approved or rejected");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.ConcessionAmount)
                .HasComment("This is the concession amount given,This amount will be Added to 'ConcessionAmt' col in StudentFeeDueDetails table, If the concession is 'Rejected' then this Amount will be deducted from the 'ConcessionAmt' col in StudentFeeDueDetails table.")
                .HasColumnType("money");
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.RecommendedBy).HasMaxLength(200);
            entity.Property(e => e.RejectedReason).HasMaxLength(400);
            entity.Property(e => e.SsconcessionDetailsId)
                .HasDefaultValue(-1L)
                .HasColumnName("SSConcessionDetailsId");
            entity.Property(e => e.SsconcessionId)
                .HasDefaultValue(-1)
                .HasColumnName("SSConcessionId");
            entity.Property(e => e.SstransId)
                .HasDefaultValue(-1L)
                .HasColumnName("SSTransID");
            entity.Property(e => e.Status)
                .HasMaxLength(40)
                .HasComment("Pending, Approved, Rejected");
        });

        modelBuilder.Entity<WdiTContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK_WDI_M_Contact");

            entity.ToTable("WDI_T_Contact");

            entity.Property(e => e.ContactName).HasMaxLength(100);
            entity.Property(e => e.DateOfContact)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateOfReply).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobile).HasMaxLength(256);
            entity.Property(e => e.Occupation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("occupation");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Question).HasMaxLength(1000);
            entity.Property(e => e.Response).HasMaxLength(1000);
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)1)
                .HasComment("1 - Pending, 2 - Process, 3 -  Complete, 4 - Rejected.");
            entity.Property(e => e.TypeofContact)
                .HasMaxLength(2)
                .HasDefaultValue("Q");
        });

        modelBuilder.Entity<WdiTDashboardView>(entity =>
        {
            entity.ToTable("WDI_T_DashboardView");

            entity.Property(e => e.DataViewName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DataViewText).HasColumnType("ntext");
            entity.Property(e => e.LastSyncDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTDeActivatedStudent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_DeActivatedStudents");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AdmissionNo).HasMaxLength(40);
            entity.Property(e => e.Branches)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DueAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ElectiveSubjects).HasMaxLength(100);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Reason)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ReportingDate).HasColumnType("datetime");
            entity.Property(e => e.RollNo).HasMaxLength(20);
            entity.Property(e => e.Scholarshipid).HasColumnName("scholarshipid");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("DEACTIVATED");
            entity.Property(e => e.Stream)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stream");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTDeleteLog>(entity =>
        {
            entity.HasKey(e => e.TransId);

            entity.ToTable("WDI_T_DeleteLog");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.DateOfOperation).HasColumnType("datetime");
            entity.Property(e => e.ObjectName).HasMaxLength(60);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTDescriptorIndicator>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PartnerDescriptorId, e.GradeId });

            entity.ToTable("WDI_T_DescriptorIndicators");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.GradeId).HasColumnName("GradeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTDisciplineDetail>(entity =>
        {
            entity.HasKey(e => e.StudentDisciplineId);

            entity.ToTable("WDI_T_DisciplineDetails");

            entity.Property(e => e.StudentDisciplineId).HasColumnName("StudentDisciplineID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ActionTaken).HasMaxLength(200);
            entity.Property(e => e.DisciplineDescription).HasMaxLength(500);
            entity.Property(e => e.DisciplineIssue).HasMaxLength(200);
            entity.Property(e => e.ReportedBy).HasMaxLength(100);
            entity.Property(e => e.ReportedDate).HasColumnType("datetime");
            entity.Property(e => e.StudentUserId)
                .HasMaxLength(40)
                .HasColumnName("StudentUserID");
        });

        modelBuilder.Entity<WdiTEmailReceipentsTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_EmailReceipentsTable");

            entity.Property(e => e.EmailId).HasMaxLength(100);
            entity.Property(e => e.ReceipentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ReceipentID");
            entity.Property(e => e.SchedulerId).HasColumnName("SchedulerID");
        });

        modelBuilder.Entity<WdiTEmpCompleteLeaveTrasaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_EmpCompleteLeaveTrasactions");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DaySegment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Full Day");
            entity.Property(e => e.EmpLeaveTransId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EmpLeaveTransID");
            entity.Property(e => e.EmployeeLeaveId).HasColumnName("EmployeeLeaveID");
            entity.Property(e => e.LeaveDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Pending");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTEmpDeductionLeaveTrasaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_EmpDeductionLeaveTrasactions");

            entity.Property(e => e.ActualNoofDays).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeductionDays).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.DeductionHeadId).HasColumnName("DeductionHeadID");
            entity.Property(e => e.EmployeeLeaveId).HasColumnName("EmployeeLeaveID");
            entity.Property(e => e.EmployeeLeaveTypeId).HasColumnName("EmployeeLeaveTypeID");
            entity.Property(e => e.LeaveTransId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LeaveTransID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTEmpLeaveEligibilityTracker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_EmpLeaveEligibilityTracker");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Authorisedby).HasMaxLength(80);
            entity.Property(e => e.CarryForward).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ExistingDaysEligible).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.ForwardedBy).HasMaxLength(80);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDays).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ProcessedBy).HasMaxLength(80);
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.RecommendedBy).HasMaxLength(80);
            entity.Property(e => e.RefDocument).HasMaxLength(500);
            entity.Property(e => e.TotalLeaves).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.UserId)
                .HasMaxLength(60)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTEmployeeCompensatoryLeaf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_EmployeeCompensatoryLeaves");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.ApprovedBy).HasMaxLength(100);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateofWork).HasColumnType("datetime");
            entity.Property(e => e.DaySegment)
                .HasMaxLength(30)
                .HasDefaultValue("Full Day");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.RequestedBy).HasMaxLength(100);
            entity.Property(e => e.RequestedDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValue("PENDING");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTEmployeeLeaf>(entity =>
        {
            entity.HasKey(e => e.EmpLeaveId).HasName("PK__WDI_T_Em__ED09215F7B866C9E");

            entity.ToTable("WDI_T_EmployeeLeaves");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Leaves).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Month).HasMaxLength(20);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTEmployeeLeaveEligibility>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_EmployeeLeaveEligibility");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CarryForward).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.DaysEligible).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.EmployeeLeaveTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EmployeeLeaveTypeID");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveBalance).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.LeaveTypeId).HasColumnName("LeaveTypeID");
            entity.Property(e => e.TotalLeaves).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.UserId)
                .HasMaxLength(60)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTEmployeeLeaveTrasaction>(entity =>
        {
            entity.HasKey(e => e.EmployeLeaveId);

            entity.ToTable("WDI_T_EmployeeLeaveTrasactions");

            entity.HasIndex(e => new { e.UserId, e.AcademicYearId }, "NonClusteredIndex-20191219-124431").IsDescending(false, true);

            entity.Property(e => e.EmployeLeaveId).HasColumnName("EmployeLeaveID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Authorisedby)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.DateOfApply).HasColumnType("datetime");
            entity.Property(e => e.DateOfProcessed).HasColumnType("datetime");
            entity.Property(e => e.EmployeeLeaveTypeId).HasColumnName("EmployeeLeaveTypeID");
            entity.Property(e => e.EmployesToBeNotified).HasMaxLength(800);
            entity.Property(e => e.ForwardedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FromDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.InchargeOrReplacement).HasMaxLength(1000);
            entity.Property(e => e.LeaveDates).HasMaxLength(4000);
            entity.Property(e => e.LeaveDays).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.LeaveLocationType).HasMaxLength(100);
            entity.Property(e => e.LeaveLocationTypeAddress).HasMaxLength(500);
            entity.Property(e => e.LeaveSanctionedDates).HasMaxLength(4000);
            entity.Property(e => e.LeaveSanctionedDays).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ProcessedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reason).HasColumnType("ntext");
            entity.Property(e => e.RecommendedBy).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasDefaultValue("Pending");
            entity.Property(e => e.SupportDocuments).HasMaxLength(400);
            entity.Property(e => e.ToDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTEnquire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WDI_T_Enquiry");

            entity.ToTable("WDI_T_Enquires");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Address)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.AdmissionType).HasMaxLength(50);
            entity.Property(e => e.AdmissionYear).HasMaxLength(50);
            entity.Property(e => e.BusFacility).HasMaxLength(500);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.Counseledby)
                .HasMaxLength(50)
                .HasColumnName("COUNSELEDBY");
            entity.Property(e => e.Counseledby2)
                .HasMaxLength(50)
                .HasColumnName("COUNSELEDBY2");
            entity.Property(e => e.Counseledby3)
                .HasMaxLength(50)
                .HasColumnName("COUNSELEDBY3");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Eamcetrank)
                .HasMaxLength(50)
                .HasColumnName("EAMCETRANK");
            entity.Property(e => e.EmailId).HasMaxLength(100);
            entity.Property(e => e.EncryptedContactNumber).HasMaxLength(256);
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobile).HasMaxLength(256);
            entity.Property(e => e.EncryptedParentEmailId).HasMaxLength(256);
            entity.Property(e => e.Enqremarks)
                .HasMaxLength(250)
                .HasColumnName("ENQREMARKS");
            entity.Property(e => e.Enqremarks2)
                .HasMaxLength(250)
                .HasColumnName("ENQREMARKS2");
            entity.Property(e => e.Enqremarks3)
                .HasMaxLength(250)
                .HasColumnName("ENQREMARKS3");
            entity.Property(e => e.Enqreturndate).HasColumnName("ENQRETURNDATE");
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.EnquiryIncharge).HasMaxLength(100);
            entity.Property(e => e.EnquiryMode).HasMaxLength(10);
            entity.Property(e => e.ExtraFields).HasColumnType("xml");
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("FName");
            entity.Property(e => e.FollowupDetails).HasMaxLength(100);
            entity.Property(e => e.IdentificationMarks1).HasMaxLength(200);
            entity.Property(e => e.IdentificationMarks2).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Isdefence)
                .HasMaxLength(10)
                .HasColumnName("ISDEFENCE");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .HasColumnName("LName");
            entity.Property(e => e.Medium).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Modeofenq)
                .HasMaxLength(50)
                .HasColumnName("MODEOFENQ");
            entity.Property(e => e.Nationality).HasMaxLength(100);
            entity.Property(e => e.ParentEmailId)
                .HasMaxLength(100)
                .HasColumnName("ParentEmailID");
            entity.Property(e => e.ParentIncomeRange).HasMaxLength(100);
            entity.Property(e => e.ParentName).HasMaxLength(75);
            entity.Property(e => e.ParentOccupation).HasMaxLength(50);
            entity.Property(e => e.ParentQualification).HasMaxLength(50);
            entity.Property(e => e.ParentRelation).HasMaxLength(50);
            entity.Property(e => e.PreviousClass).HasMaxLength(50);
            entity.Property(e => e.PreviousClassPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PreviousClassTotalMarks).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.PreviousGrade).HasMaxLength(20);
            entity.Property(e => e.PreviousSchoolBoard).HasMaxLength(100);
            entity.Property(e => e.PreviousSchoolName).HasMaxLength(100);
            entity.Property(e => e.ReasonForLeave).HasMaxLength(100);
            entity.Property(e => e.ScholarShipType).HasMaxLength(5);
            entity.Property(e => e.SourceOfEnquiry).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<WdiTEnquiryFollowup>(entity =>
        {
            entity.HasKey(e => e.FollowupId);

            entity.ToTable("WDI_T_EnquiryFollowup");

            entity.Property(e => e.FollowupId).HasColumnName("FollowupID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.FollowupDetails).HasMaxLength(500);
            entity.Property(e => e.FollowupType).HasMaxLength(50);
            entity.Property(e => e.Fupby)
                .HasMaxLength(100)
                .HasColumnName("FUPBY");
            entity.Property(e => e.Fupemailid)
                .HasMaxLength(100)
                .HasColumnName("FUPEMAILID");
            entity.Property(e => e.Fupmobileno)
                .HasMaxLength(15)
                .HasColumnName("FUPMOBILENO");
            entity.Property(e => e.Fupmode)
                .HasMaxLength(20)
                .HasColumnName("FUPMODE");
            entity.Property(e => e.Fupremarks)
                .HasMaxLength(500)
                .HasColumnName("FUPREMARKS");
            entity.Property(e => e.Fupretdate).HasColumnName("FUPRETDATE");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<WdiTEvaluationMark>(entity =>
        {
            entity.HasKey(e => e.MarksId);

            entity.ToTable("WDI_T_EvaluationMarks");

            entity.Property(e => e.MarksId).HasColumnName("MarksID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ActualMarks).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTEventAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.PeriodAttDetailsId);

            entity.ToTable("WDI_T_EventAttendanceDetails");

            entity.Property(e => e.PeriodAttDetailsId).HasColumnName("PeriodAttDetailsID");
            entity.Property(e => e.AttDate).HasColumnType("datetime");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.FacultyUserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FacultyUserID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTExamMark>(entity =>
        {
            entity.HasKey(e => e.MarksId).HasName("PK_WDI_T_EXAMMARKS");

            entity.ToTable("WDI_T_ExamMarks");

            entity.HasIndex(e => new { e.ScheduleId, e.UserId }, "INX_ramaschema_WDI_T_ExamMarks_ScheduleId_UserId");

            entity.HasIndex(e => new { e.UserId, e.ScheduleId }, "IX_WDI_T_EXAMMARKS05SEP2018").IsDescending(false, true);

            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Grade).HasMaxLength(5);
            entity.Property(e => e.GradePoint).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.InternalMarks)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsAbsent).HasDefaultValue(false);
            entity.Property(e => e.Remarks).HasMaxLength(400);
            entity.Property(e => e.SecuredMarks)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Tgp)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("TGP");
            entity.Property(e => e.Tsgrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TSGrade");
            entity.Property(e => e.Tsscore)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("TSScore");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTExamSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK_WDI_T_ExamSchedule_1");

            entity.ToTable("WDI_T_ExamSchedule");

            entity.HasIndex(e => e.ExaminationId, "IX_WDI_T_ExamSchedule");

            entity.HasIndex(e => e.ClassId, "IX_WDI_T_ExamSchedule_1");

            entity.HasIndex(e => e.Section, "IX_WDI_T_ExamSchedule_2");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExamDate).HasColumnType("datetime");
            entity.Property(e => e.ExamType).HasMaxLength(40);
            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.ExternalMarks).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ExternalTitle).HasMaxLength(100);
            entity.Property(e => e.FromTime).HasMaxLength(50);
            entity.Property(e => e.InternalExamDate).HasColumnType("datetime");
            entity.Property(e => e.InternalFromTime).HasMaxLength(40);
            entity.Property(e => e.InternalMarks).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.InternalTitle).HasMaxLength(100);
            entity.Property(e => e.InternalToTime).HasMaxLength(40);
            entity.Property(e => e.IsCce)
                .HasDefaultValue(false)
                .HasColumnName("IsCCE");
            entity.Property(e => e.IsProcessed).HasDefaultValue(false);
            entity.Property(e => e.Marks)
                .HasDefaultValue(100m)
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PassPercentageExt).HasDefaultValue(0);
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.ToTime).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiTExamTimeTable>(entity =>
        {
            entity.HasKey(e => e.ExaminationId).HasName("PK_WDI_T_ExamTimeTable_1");

            entity.ToTable("WDI_T_ExamTimeTable");

            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CceexamId).HasColumnName("CCEExamID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Examination).HasMaxLength(100);
            entity.Property(e => e.IsCce)
                .HasDefaultValue(false)
                .HasColumnName("IsCCE");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
        });

        modelBuilder.Entity<WdiTFacultyDetail>(entity =>
        {
            entity.ToTable("WDI_T_FacultyDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Achievements).HasMaxLength(400);
            entity.Property(e => e.BasicSalary)
                .HasDefaultValue(5340m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Classes).HasMaxLength(150);
            entity.Property(e => e.DateOfConfirmation).HasColumnType("datetime");
            entity.Property(e => e.DateOfJoin).HasColumnType("datetime");
            entity.Property(e => e.DateOfRelieving).HasColumnType("datetime");
            entity.Property(e => e.DateOfResignation).HasColumnType("datetime");
            entity.Property(e => e.DateOfRetirement).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(400)
                .HasDefaultValue("-1");
            entity.Property(e => e.Designation).HasMaxLength(100);
            entity.Property(e => e.EmployeeType)
                .HasMaxLength(50)
                .HasDefaultValue("Probation");
            entity.Property(e => e.Esicno).HasColumnName("ESICNo");
            entity.Property(e => e.Experience).HasMaxLength(200);
            entity.Property(e => e.ExtraFields).HasColumnType("xml");
            entity.Property(e => e.FacultyType)
                .HasMaxLength(50)
                .HasDefaultValue("Teaching");
            entity.Property(e => e.PfaccountNo)
                .HasMaxLength(400)
                .HasColumnName("PFAccountNo");
            entity.Property(e => e.ProfessionalDetails).HasColumnType("xml");
            entity.Property(e => e.ProllTemplateId)
                .HasDefaultValue(-1L)
                .HasColumnName("PRollTemplateId");
            entity.Property(e => e.Qualification).HasMaxLength(400);
            entity.Property(e => e.ReportingBlock).HasMaxLength(50);
            entity.Property(e => e.ReportingHead).HasMaxLength(50);
            entity.Property(e => e.Sequenceorder)
                .HasDefaultValue(1L)
                .HasColumnName("sequenceorder");
            entity.Property(e => e.SpouseDetails).HasColumnType("xml");
            entity.Property(e => e.StaffBlock).HasMaxLength(100);
            entity.Property(e => e.Subjects).HasMaxLength(150);
            entity.Property(e => e.TeachingSections)
                .HasMaxLength(2000)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.Uanno).HasColumnName("UANNo");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTFeeAccountMapping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_FeeAccountMapping");

            entity.Property(e => e.CrHeadId).HasColumnName("CrHeadID");
            entity.Property(e => e.DrHeadId).HasColumnName("DrHeadID");
            entity.Property(e => e.FeeAccountId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FeeAccountID");
            entity.Property(e => e.MappingName).HasMaxLength(400);
            entity.Property(e => e.OrganizationId).HasDefaultValue(-1L);
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPercentage)
                .HasDefaultValue(100m)
                .HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<WdiTFeeDueMonth>(entity =>
        {
            entity.HasKey(e => e.FeeHeadMonthsId);

            entity.ToTable("WDI_T_FeeDueMonths");

            entity.Property(e => e.FeeHeadMonthsId).HasColumnName("FeeHeadMonthsID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FeeDueMonth).HasMaxLength(50);
            entity.Property(e => e.FeeHeadId).HasColumnName("FeeHeadID");
            entity.Property(e => e.Sections)
                .HasMaxLength(800)
                .HasDefaultValue("-1");
        });

        modelBuilder.Entity<WdiTFeePayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK_WDI_T_FeePaymentDetails");

            entity.ToTable("WDI_T_FeePayments");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AccountNo).HasMaxLength(200);
            entity.Property(e => e.AckReceiptNo).HasMaxLength(400);
            entity.Property(e => e.Acknowledge).HasDefaultValue(-1);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.ChQstatus)
                .HasMaxLength(100)
                .HasDefaultValue("pending")
                .HasColumnName("ChQStatus");
            entity.Property(e => e.ChequeBounce)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CollectedBranchId).HasDefaultValue(-1L);
            entity.Property(e => e.CollectedBranchUser).HasMaxLength(100);
            entity.Property(e => e.CollectedBranchname).HasMaxLength(1000);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateOfDelete).HasColumnType("datetime");
            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.FeeCancelledBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Feemappingstatus).HasDefaultValue(false);
            entity.Property(e => e.MerchantTransId)
                .HasMaxLength(400)
                .HasColumnName("MerchantTransID");
            entity.Property(e => e.ModeOfPayment).HasMaxLength(50);
            entity.Property(e => e.Msisdnnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MSISDNNumber");
            entity.Property(e => e.PaidBy).HasMaxLength(150);
            entity.Property(e => e.PgstatusId)
                .HasDefaultValue(0)
                .HasColumnName("PGStatusID");
            entity.Property(e => e.RecStatus).HasDefaultValue(true);
            entity.Property(e => e.ReceiptNo).HasMaxLength(100);
            entity.Property(e => e.ReceiptNumberType).HasMaxLength(150);
            entity.Property(e => e.SenderName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Skippedmappingstatus).HasColumnName("skippedmappingstatus");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Transcharges)
                .HasDefaultValue(0m)
                .HasColumnType("money");
        });

        modelBuilder.Entity<WdiTFeePaymentDetail>(entity =>
        {
            entity.HasKey(e => e.PaymentDetailsId).HasName("PK_WDI_T_FeePaymentDetails_1");

            entity.ToTable("WDI_T_FeePaymentDetails");

            entity.HasIndex(e => new { e.FeeDueId, e.AcademicYearId }, "IX_FeePaymentDetails_FeeDueId_ACADEMICYEARID");

            entity.Property(e => e.PaymentDetailsId).HasColumnName("PaymentDetailsID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CollectedBranchname).HasMaxLength(1000);
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.LastPaidDate).HasColumnType("datetime");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Skippedmappingstatus)
                .HasDefaultValue(true)
                .HasColumnName("skippedmappingstatus");
        });

        modelBuilder.Entity<WdiTFeepaymentsCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_FEEPAYMENTS_Copy");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AccountNo).HasMaxLength(200);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CollectedBranchUser).HasMaxLength(100);
            entity.Property(e => e.CollectedBranchname).HasMaxLength(1000);
            entity.Property(e => e.DateOfDelete).HasColumnType("datetime");
            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.ModeOfPayment).HasMaxLength(50);
            entity.Property(e => e.Msisdnnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MSISDNNumber");
            entity.Property(e => e.PaidBy).HasMaxLength(150);
            entity.Property(e => e.PaymentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PaymentID");
            entity.Property(e => e.PgstatusId).HasColumnName("PGStatusID");
            entity.Property(e => e.ReceiptNo).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.SenderName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Skippedmappingstatus).HasColumnName("skippedmappingstatus");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Transcharges).HasColumnType("money");
        });

        modelBuilder.Entity<WdiTFinalExamWeightage>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PartnerId, e.AcademicYearId, e.ClassId }).IsClustered(false);

            entity.ToTable("WDI_T_FinalExamWeightage");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExamId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExamID");
            entity.Property(e => e.ExamName).HasMaxLength(100);
            entity.Property(e => e.TermId)
                .HasMaxLength(50)
                .HasColumnName("TermID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTFineAmountDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_FineAmountDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.FineAmount).HasColumnType("money");
            entity.Property(e => e.FineConcesion).HasColumnType("money");
            entity.Property(e => e.FineId).ValueGeneratedOnAdd();
            entity.Property(e => e.FinePaid).HasColumnType("money");
            entity.Property(e => e.Finereceiptno).HasMaxLength(100);
            entity.Property(e => e.Mappingstatus)
                .HasDefaultValue(false)
                .HasColumnName("mappingstatus");
            entity.Property(e => e.Paidby).HasMaxLength(100);
            entity.Property(e => e.Paiddate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.UserId).HasMaxLength(150);
        });

        modelBuilder.Entity<WdiTGrouplevelrb>(entity =>
        {
            entity.HasKey(e => e.AccessId);

            entity.ToTable("WDI_T_GROUPLEVELRBS");

            entity.Property(e => e.Add)
                .HasDefaultValue(true)
                .HasColumnName("ADD");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Delete).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasMaxLength(100);
            entity.Property(e => e.Modify).HasDefaultValue(true);
            entity.Property(e => e.View).HasDefaultValue(true);
        });

        modelBuilder.Entity<WdiTHalfDayAttendance>(entity =>
        {
            entity.HasKey(e => e.HalfDayAttendanceId).HasName("wdi_t_HalfDayAttendance_HalfDayAttendanceId");

            entity.ToTable("wdi_t_HalfDayAttendance");

            entity.Property(e => e.AttendanceType).HasComment("1--Morning Abscent ;  2 ---- AfterNoon Abscent");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTHeadwiseFeeCollection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_HeadwiseFeeCollection");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.FeeHeadName).HasMaxLength(100);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModeofPayment).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTHomeworkfile>(entity =>
        {
            entity.ToTable("WDI_T_HOMEWORKFILES");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.HomeworkTaskId).HasColumnName("HomeworkTaskID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTHostelAttendanceRawDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_HostelAttendanceRawData");

            entity.Property(e => e.AttendanceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AttendanceID");
            entity.Property(e => e.AttnDetails).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MachineNo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Remarks).HasMaxLength(250);
        });

        modelBuilder.Entity<WdiTHourlyAttendance>(entity =>
        {
            entity.HasKey(e => e.HourlyAttendaceId).HasName("WDI_T_HourlyAttendace_Id");

            entity.ToTable("WDI_T_HourlyAttendance");

            entity.Property(e => e.AbsentDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTHourlyEventAttendance>(entity =>
        {
            entity.HasKey(e => e.HourlyAttendaceId).HasName("WDI_T_HourlyEventAttendance_HourlyEventAttendaceId");

            entity.ToTable("WDI_T_HourlyEventAttendance");

            entity.Property(e => e.AbsentDate).HasColumnType("datetime");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTIcseclassWiseExaminationMapping>(entity =>
        {
            entity.HasKey(e => e.ClassWiseExaminationMappingId).HasName("ICSEClassWiseExaminationMappingId_PK");

            entity.ToTable("WDI_T_ICSEClassWiseExaminationMapping");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MasterExamName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTIcseclassWisePercentage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_ICSEClassWisePercentage");

            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.Grade)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaximumMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Percentage).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.SecuredMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.SubjectName).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTIcseclassmappingdetail>(entity =>
        {
            entity.HasKey(e => e.MappedClassId);

            entity.ToTable("WDI_T_ICSECLASSMAPPINGDETAILS");

            entity.Property(e => e.MappedClassId).HasColumnName("MappedClassID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PromotedClass).HasDefaultValue(-1);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTIcsecoCurricularActivitiyGrade>(entity =>
        {
            entity.HasKey(e => e.CoCurricularActivitiyGradeId).HasName("wdi_t_ICSECoCurricularActivitiyGrades_CoCurricularActivitiyGradeId");

            entity.ToTable("wdi_t_ICSECoCurricularActivitiyGrades");

            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTIcsecoScholasticGrade>(entity =>
        {
            entity.HasKey(e => e.CoScholasticGradeId).HasName("WDI_T_ICSECoScholasticGrades_CoScholasticGradeId");

            entity.ToTable("WDI_T_ICSECoScholasticGrades");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Grade).HasMaxLength(4);
            entity.Property(e => e.MaxGradePoint).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.MinGradePoint).HasColumnType("decimal(18, 1)");
        });

        modelBuilder.Entity<WdiTIcsedescriptorIndicator>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PartnerDescriptorId, e.GradeId });

            entity.ToTable("WDI_T_ICSEDescriptorIndicators");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.GradeId).HasColumnName("GradeID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Grade)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTIcseexamMark>(entity =>
        {
            entity.HasKey(e => e.MarksId).HasName("PK_WDI_T_ICSEEXAMMARKS");

            entity.ToTable("WDI_T_ICSEExamMarks");

            entity.Property(e => e.AbsentType).HasMaxLength(50);
            entity.Property(e => e.ClassRank).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Grade).HasMaxLength(5);
            entity.Property(e => e.GradePoint).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.InternalMarks)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(400);
            entity.Property(e => e.SectionRank).HasDefaultValue(0);
            entity.Property(e => e.SecuredMarks)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Tgp)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("TGP");
            entity.Property(e => e.Tsgrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TSGrade");
            entity.Property(e => e.Tsscore)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("TSScore");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTIcseexamSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK_WDI_T_ICSEExamSchedule_1");

            entity.ToTable("WDI_T_ICSEExamSchedule");

            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExamBoardType).HasMaxLength(15);
            entity.Property(e => e.ExamDate).HasColumnType("datetime");
            entity.Property(e => e.ExamType).HasMaxLength(40);
            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.ExternalMarks).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ExternalTitle).HasMaxLength(100);
            entity.Property(e => e.FromTime).HasMaxLength(50);
            entity.Property(e => e.InternalExamDate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.InternalFromTime).HasMaxLength(40);
            entity.Property(e => e.InternalMarks).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.InternalTitle).HasMaxLength(100);
            entity.Property(e => e.InternalToTime).HasMaxLength(40);
            entity.Property(e => e.IsProcessed).HasDefaultValue(false);
            entity.Property(e => e.LanguageType).HasComment("If language type is 1 it is first laguage 2 means second language 3 means third language.if it is 0 it is not language");
            entity.Property(e => e.Marks)
                .HasDefaultValue(100m)
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PassPercentageExt).HasDefaultValue(0);
            entity.Property(e => e.Status).HasDefaultValue((short)0);
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.ToTime).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiTIcseexamTimeTable>(entity =>
        {
            entity.HasKey(e => e.ExaminationId).HasName("PK_WDI_T_ICSEExamTimeTable_ExaminationID");

            entity.ToTable("WDI_T_ICSEExamTimeTable");

            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.AcademicYearId)
                .HasDefaultValue(0L)
                .HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExamBoardType).HasMaxLength(15);
            entity.Property(e => e.Examination).HasMaxLength(100);
            entity.Property(e => e.IcseexamId).HasColumnName("ICSEExamID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
        });

        modelBuilder.Entity<WdiTIcseexamsMapping>(entity =>
        {
            entity.HasKey(e => e.MappedExamId);

            entity.ToTable("WDI_T_ICSEExamsMapping");

            entity.Property(e => e.MappedExamId).HasColumnName("MappedExamID");
            entity.Property(e => e.AssesmentType).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExamName).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTIcsefieldMaster>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("WDI_T_ICSEFieldMaster_FieldId");

            entity.ToTable("WDI_T_ICSEFieldMaster");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FieldName).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ShortCode).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTIcsemasterTemplate>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("WDI_T_ICSEMasterTemplate_ExamId");

            entity.ToTable("WDI_T_ICSEMasterTemplate");

            entity.Property(e => e.AssesmentType).HasMaxLength(40);
            entity.Property(e => e.Cgpa).HasColumnName("CGPA");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExamName).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTIcsepartnerDescriptorsMaster>(entity =>
        {
            entity.HasKey(e => e.PartnerDescriptorId).HasName("WDI_T_ICSEPartnerDescriptorsMaster_PartnerDescriptorId");

            entity.ToTable("WDI_T_ICSEPartnerDescriptorsMaster");

            entity.Property(e => e.ClassId).HasDefaultValue(0);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DescriptorName).HasMaxLength(100);
            entity.Property(e => e.Details).HasMaxLength(1000);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SectionId).HasDefaultValue(0);
            entity.Property(e => e.SubjectId)
                .HasDefaultValue(-1)
                .HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTIcsescholasticGrade>(entity =>
        {
            entity.HasKey(e => e.ScholasticGradeId).HasName("WDI_T_ICSEScholasticGrades_ScholasticGradeId");

            entity.ToTable("WDI_T_ICSEScholasticGrades");

            entity.Property(e => e.ClassId)
                .HasDefaultValue(0)
                .HasComment("If Select All Classes default class id will be 0 . Otherwise whatever client selected class id will be saved.");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Grade).HasMaxLength(250);
            entity.Property(e => e.MaxMarksPercentage).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.MinMarksPercentage).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTIcsestudentCoScholasticMark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("WDI_T_ICSEStudentCoScholasticMarks_Id");

            entity.ToTable("WDI_T_ICSEStudentCoScholasticMarks");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Grade).HasMaxLength(2);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SecuredMarks).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TermorExamId).HasDefaultValue(-1L);
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTIcsestudentConsolidatedExamResult>(entity =>
        {
            entity.ToTable("WDI_T_ICSEStudentConsolidatedExamResults");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("edusync");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Percentage).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.TotalMaxMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TotalSecMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.UserId).IsUnicode(false);
        });

        modelBuilder.Entity<WdiTIcsetermMaster>(entity =>
        {
            entity.HasKey(e => e.TermMasterId).HasName("WDI_M_ICSETermMaster_TermMasterId");

            entity.ToTable("WDI_T_ICSETermMaster");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExamBoardType).HasMaxLength(15);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TermName).HasMaxLength(100);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTIcsetermWiseRemark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("WDI_T_ICSETermWiseRemarks_Id");

            entity.ToTable("WDI_T_ICSETermWiseRemarks");

            entity.Property(e => e.CoScholasticT1remarks)
                .HasMaxLength(1000)
                .HasColumnName("CoScholasticT1Remarks");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScholasticT1remarks)
                .HasMaxLength(1000)
                .HasColumnName("ScholasticT1Remarks");
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTIcsetermWiseReportDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_ICSETermWiseReportDates");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ReportDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTIcsetoolMapping>(entity =>
        {
            entity.HasKey(e => e.ToolMappingId).HasName("wdi_t_ICSEToolMappings_ToolMappingId");

            entity.ToTable("wdi_t_ICSEToolMappings");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsSubTool).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScheduleId).HasDefaultValue(-1L);
            entity.Property(e => e.SectionId).HasDefaultValue(-1);
            entity.Property(e => e.SubjectId)
                .HasDefaultValue(-1)
                .HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTIcsetoolMark>(entity =>
        {
            entity.HasKey(e => e.ToolMarksId).HasName("wdi_t_ICSEToolMarks_ToolMarksId");

            entity.ToTable("wdi_t_ICSEToolMarks");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Marks).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTInWard>(entity =>
        {
            entity.HasKey(e => e.InWardId);

            entity.ToTable("WDI_T_InWard");

            entity.Property(e => e.InWardId).HasColumnName("InWardID");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.FileFrom).HasMaxLength(200);
            entity.Property(e => e.FileNumber).HasMaxLength(200);
            entity.Property(e => e.InwardNumber).HasMaxLength(100);
            entity.Property(e => e.OtherDetails).HasMaxLength(1000);
            entity.Property(e => e.SubmissionDept).HasMaxLength(100);
            entity.Property(e => e.VisitorId).HasColumnName("VisitorID");
            entity.Property(e => e.WhomToSubmit).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTIncomTaxRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_IncomTaxRecords");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FeeHeadId).HasColumnName("FeeHeadID");
            entity.Property(e => e.FeeHeadName)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ReceiptNo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TaxId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TaxID");
            entity.Property(e => e.TaxNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTInvIssuedStock>(entity =>
        {
            entity.HasKey(e => e.IssueStockId).HasName("PK__WDI_T_In__3214EC07793E3179");

            entity.ToTable("WDI_T_InvIssuedStock");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BillNo).HasMaxLength(100);
            entity.Property(e => e.DeliveryNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.DemandNote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.IssuedBy)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(100)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .HasColumnName("Item_Name");
            entity.Property(e => e.PartnerId).HasColumnName("partnerId");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceiptNo).HasMaxLength(400);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.StockIssueDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Units).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(100);
            entity.Property(e => e.Value)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("value");
        });

        modelBuilder.Entity<WdiTInvIssuedStockPartner>(entity =>
        {
            entity.HasKey(e => e.IssueStockId).HasName("PK__WDI_T_InvIssuedStockPartners__3214EC07793E3179");

            entity.ToTable("WDI_T_InvIssuedStockPartners");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BillNo).HasMaxLength(100);
            entity.Property(e => e.DeliveryNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.DemandNote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.IssuedBy)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(100)
                .HasColumnName("Item_Code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .HasColumnName("Item_Name");
            entity.Property(e => e.PartnerId).HasColumnName("partnerId");
            entity.Property(e => e.StockIssueDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Units).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTInvRecStock>(entity =>
        {
            entity.HasKey(e => e.RecStockId).HasName("PK_WDI_T_InvRecStock_1");

            entity.ToTable("WDI_T_InvRecStock");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BillDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.BillNo).HasMaxLength(100);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(100)
                .HasColumnName("Item_code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .HasColumnName("Item_name");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.TotalRcptAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Total_rcptAmount");
            entity.Property(e => e.Unitrate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Units).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTInvStock>(entity =>
        {
            entity.HasKey(e => e.StockId).HasName("PK__WDI_T_In__3214EC0773855823");

            entity.ToTable("WDI_T_InvStock");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(100)
                .HasColumnName("Item_code");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .HasColumnName("Item_name");
            entity.Property(e => e.OldQty).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Units).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTInventoryLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_InventoryLog");

            entity.Property(e => e.Action)
                .HasMaxLength(200)
                .HasColumnName("action");
            entity.Property(e => e.Actionby)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("actionby");
            entity.Property(e => e.Actionfor).HasColumnName("actionfor");
            entity.Property(e => e.Actiontype)
                .HasMaxLength(100)
                .HasColumnName("actiontype");
            entity.Property(e => e.Logdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("logdate");
            entity.Property(e => e.Logid)
                .ValueGeneratedOnAdd()
                .HasColumnName("logid");
        });

        modelBuilder.Entity<WdiTInventoryWorkflow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_T_In__3213E83F705D90A1");

            entity.ToTable("WDI_T_InventoryWorkflows");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("NA");
        });

        modelBuilder.Entity<WdiTIssuesFeedback>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__WDI_T_Is__712CC627D724AC88");

            entity.ToTable("WDI_T_IssuesFeedback");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.DateofPosted)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Emailid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Postedby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTLateAttendanceCounting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_T_La__3214EC2720142827");

            entity.ToTable("WDI_T_LateAttendanceCountings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConfirmedBy).HasMaxLength(150);
            entity.Property(e => e.ConfirmedDate).HasColumnType("datetime");
            entity.Property(e => e.ConfirmedLopdays)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("ConfirmedLOPDays");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Lopdays)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("LOPDays");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("PENDING");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTLeaveTransaction>(entity =>
        {
            entity.HasKey(e => e.LeaveId);

            entity.ToTable("WDI_T_LeaveTransaction");

            entity.Property(e => e.LeaveId).HasColumnName("LeaveID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.LeaveAppliedDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveFrom).HasColumnType("smalldatetime");
            entity.Property(e => e.LeaveTo).HasColumnType("smalldatetime");
            entity.Property(e => e.Status).HasDefaultValue(0);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
            entity.Property(e => e.VerifiedBy).HasMaxLength(50);
            entity.Property(e => e.VerifiedDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<WdiTLeaveTransactionDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_LeaveTransactionDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.LeaveDate).HasMaxLength(50);
            entity.Property(e => e.LeaveId).HasColumnName("LeaveID");
        });

        modelBuilder.Entity<WdiTLessonPlanner>(entity =>
        {
            entity.HasKey(e => e.LessonId);

            entity.ToTable("WDI_T_Lesson_Planner");

            entity.Property(e => e.LessonId).HasColumnName("LessonID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FacultyId)
                .HasMaxLength(40)
                .HasColumnName("FacultyID");
            entity.Property(e => e.LessonTitle).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Percentage).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.PeriodFrom).HasColumnType("datetime");
            entity.Property(e => e.PeriodTo).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.Status).HasComment("0 - Pending, 1 - Progress, 2 - Completed");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.Topics).HasMaxLength(1000);
        });

        modelBuilder.Entity<WdiTLibraryaccession>(entity =>
        {
            entity.HasKey(e => e.AccessionId).HasName("PK_WDI_M_ACCESSIONMASTER");

            entity.ToTable("WDI_T_LIBRARYACCESSION");

            entity.Property(e => e.AccessionNo).HasMaxLength(500);
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasComment("Here By default 1 -- means Book Added. ;  0- Means Deleted Book.");
            entity.Property(e => e.Author).HasMaxLength(500);
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillNum).HasMaxLength(100);
            entity.Property(e => e.BookCode).HasMaxLength(60);
            entity.Property(e => e.BookEdition).HasMaxLength(500);
            entity.Property(e => e.ClassId).HasDefaultValue(-1);
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Isbnnum)
                .HasMaxLength(100)
                .HasColumnName("ISBNNum");
            entity.Property(e => e.Remarks).HasMaxLength(600);
            entity.Property(e => e.Slot).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.SubjectId).HasDefaultValue(-1);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.YearOfPub).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTLibraryissuereturn>(entity =>
        {
            entity.HasKey(e => e.Lirid);

            entity.ToTable("WDI_T_LIBRARYISSUERETURNS");

            entity.Property(e => e.Lirid).HasColumnName("LIRId");
            entity.Property(e => e.BookType)
                .HasDefaultValue(1)
                .HasComment("If Book Type is ::  1 -- Normal Book ; 0 -- BookBank Book");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IssueDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTLibrarypenalty>(entity =>
        {
            entity.HasKey(e => e.PenaltyId);

            entity.ToTable("WDI_T_LIBRARYPENALTIES");

            entity.Property(e => e.Active)
                .HasMaxLength(100)
                .HasComment("WHEN 0 THEN 'PAID' ELSE 'PENDING'");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Concession).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaidDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTLoginJsession>(entity =>
        {
            entity.ToTable("Wdi_T_LoginJSessions");

            entity.Property(e => e.Createddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createddate");
            entity.Property(e => e.JsessioId).HasMaxLength(150);
            entity.Property(e => e.Logoutdate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTM2mStudentExitDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wdi_T_m2__3214EC2721AC4EC1");

            entity.ToTable("Wdi_T_m2mStudentExitDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AppliedBy).HasMaxLength(80);
            entity.Property(e => e.AppliedDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy).HasMaxLength(100);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ExitreferenceNo)
                .HasMaxLength(50)
                .HasColumnName("ExitreferenceNO");
            entity.Property(e => e.ForfeitedAmount).HasColumnType("money");
            entity.Property(e => e.HstlFeeExist).HasDefaultValue(false);
            entity.Property(e => e.HstlForfeitedAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.HstlPaidAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.HstlProposedForfeitedAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.HstlProposedRefundAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.HstlRefundAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.ParentRequestedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ProposedForfeitedAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.ProposedRefundAmt)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.RefundedAmount).HasColumnType("money");
            entity.Property(e => e.RequestApprovaldate).HasColumnType("datetime");
            entity.Property(e => e.Requeststatus).HasMaxLength(50);
            entity.Property(e => e.StudentUserId)
                .HasMaxLength(150)
                .HasColumnName("StudentUserID");
            entity.Property(e => e.VerifiedBy).HasMaxLength(100);
            entity.Property(e => e.VerifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTM2mmoneyDeposit>(entity =>
        {
            entity.HasKey(e => e.DepositId);

            entity.ToTable("WDI_T_M2MMoneyDeposit");

            entity.Property(e => e.AcadamicYearId).HasColumnName("AcadamicYearID");
            entity.Property(e => e.Billinggroup).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DepositType).HasMaxLength(100);
            entity.Property(e => e.DepositedAmount).HasColumnType("money");
            entity.Property(e => e.DepositedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PreviousCollections).HasColumnType("money");
            entity.Property(e => e.TotalPdc).HasColumnName("TotalPDC");
        });

        modelBuilder.Entity<WdiTMealMenuConsumedDetail>(entity =>
        {
            entity.ToTable("Wdi_T_MealMenuConsumedDetails");

            entity.Property(e => e.ConsumedMealQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Consumeddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTMedium>(entity =>
        {
            entity.HasKey(e => e.MediumId);

            entity.ToTable("wdi_t_Mediums");

            entity.Property(e => e.CeatedDate).HasColumnType("datetime");
            entity.Property(e => e.Medium).HasMaxLength(50);
            entity.Property(e => e.MediumCode).HasMaxLength(20);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_Messages");

            entity.Property(e => e.Body).HasColumnType("text");
            entity.Property(e => e.FromId).HasMaxLength(50);
            entity.Property(e => e.MsgDate).HasColumnType("datetime");
            entity.Property(e => e.MsgId).ValueGeneratedOnAdd();
            entity.Property(e => e.MsgStat)
                .HasDefaultValue((byte)0)
                .HasComment("1 - UN READ, 2 - READ, 3 - TRASH, 4 - MOVE TO PARTICULAR FOLDER, 5 - DELETE(RECORD EXISTS BUT WON'T BE SEEN IN TRASH).");
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.ToId).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiTMessageFolder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_MessageFolder");

            entity.Property(e => e.Fid).HasColumnName("FID");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTMetricsTransactionDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WDI_M_MetricsTransactionDetails");

            entity.ToTable("WDI_T_MetricsTransactionDetails");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Smscount).HasColumnName("SMSCount");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasComment(" -1 ---Wrong Metrics Inserted");
        });

        modelBuilder.Entity<WdiTMobilereglog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__wdi_t_mo__3213E83FBEACBAC0");

            entity.ToTable("wdi_t_mobilereglog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appledeviceid)
                .HasMaxLength(2000)
                .HasColumnName("appledeviceid");
            entity.Property(e => e.Deviceid)
                .HasMaxLength(2000)
                .HasColumnName("deviceid");
            entity.Property(e => e.Registereddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("registereddate");
            entity.Property(e => e.Userid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<WdiTMonthwisestudentattendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wdi_t_Mo__CBA1B2574A3D9122");

            entity.ToTable("WDI_T_MONTHWISESTUDENTATTENDANCE");

            entity.Property(e => e.AttMonth).HasDefaultValueSql("(datepart(month,getdate()))");
            entity.Property(e => e.AttYear).HasDefaultValueSql("(datepart(year,getdate()))");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Termid)
                .HasDefaultValue(-1)
                .HasColumnName("TERMID");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTNewLetterSubscription>(entity =>
        {
            entity.HasKey(e => e.SubscriptionId);

            entity.ToTable("WDI_T_NewLetterSubscriptions");

            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(150)
                .HasColumnName("EmailID");
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.LastNotified).HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValue(false);
            entity.Property(e => e.SubsDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTNonbranchfeepaydetail>(entity =>
        {
            entity.HasKey(e => e.NonBranchTransId);

            entity.ToTable("WDI_T_NONBRANCHFEEPAYDETAILS");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FeeCollectedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FeeCollectedForBranchDetails).HasMaxLength(100);
            entity.Property(e => e.FeeCollectedForStudentAdmNo).HasMaxLength(50);
            entity.Property(e => e.FeeCollectedForStudentId).HasMaxLength(50);
            entity.Property(e => e.FeeDetails).HasMaxLength(2000);
            entity.Property(e => e.FeeTotalCollected).HasColumnType("money");
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("Cash");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StudnetDetails).HasMaxLength(1000);
        });

        modelBuilder.Entity<WdiTOnBoardApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_OnBoardApplications");

            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollNo).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsFirstLogin).HasDefaultValue(true);
            entity.Property(e => e.LastVisit).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Permissions).HasMaxLength(40);
            entity.Property(e => e.Shahs)
                .HasMaxLength(400)
                .HasColumnName("SHAHS");
            entity.Property(e => e.Sslat)
                .HasMaxLength(100)
                .HasColumnName("SSLAT");
            entity.Property(e => e.SuserType)
                .HasMaxLength(200)
                .HasColumnName("SUserType");
            entity.Property(e => e.SusertypeId).HasColumnName("SUsertypeId");
        });

        modelBuilder.Entity<WdiTOnboardAndExcessPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_OnboardAndExcessPayments");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(80);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateOfPayment)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MappedStatus).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaidBy).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ReceiptNo).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(60);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Onboard");
            entity.Property(e => e.UserId)
                .HasMaxLength(80)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTOutPassDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_T_Ou__3214EC27D8145B49");

            entity.ToTable("WDI_T_OutPassDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdmissionNo).HasMaxLength(150);
            entity.Property(e => e.Class).HasMaxLength(80);
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.InDateTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.OutDateTime).HasColumnType("datetime");
            entity.Property(e => e.OutRequestBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.OutRequestDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OutRequestFromDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OutRequestToDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OutingPersonImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("default.jpg");
            entity.Property(e => e.OutingRequestStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Initiated");
            entity.Property(e => e.ParentName).HasMaxLength(100);
            entity.Property(e => e.ParentType).HasMaxLength(50);
            entity.Property(e => e.PermissionGivenBy).HasMaxLength(150);
            entity.Property(e => e.PermissionId).HasMaxLength(200);
            entity.Property(e => e.Reason).HasMaxLength(250);
            entity.Property(e => e.Section).HasMaxLength(80);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Out");
            entity.Property(e => e.UserId).HasMaxLength(150);
        });

        modelBuilder.Entity<WdiTPartnerBusinessRule>(entity =>
        {
            entity.HasKey(e => e.PartnerBruleId);

            entity.ToTable("WDI_T_PartnerBusinessRules");

            entity.Property(e => e.PartnerBruleId).HasColumnName("PartnerBRuleID");
            entity.Property(e => e.BusinessRuleId).HasColumnName("BusinessRuleID");
            entity.Property(e => e.ValueFrom).HasMaxLength(200);
            entity.Property(e => e.ValueTo).HasMaxLength(200);
        });

        modelBuilder.Entity<WdiTPartnerDescriptorsMaster>(entity =>
        {
            entity.HasKey(e => e.PartnerDescriptorId).HasName("WDI_T_PartnerDescriptorsMaster_PartnerDescriptorId");

            entity.ToTable("WDI_T_PartnerDescriptorsMaster");

            entity.Property(e => e.DescriptorName).HasMaxLength(100);
            entity.Property(e => e.Details).HasMaxLength(1000);
            entity.Property(e => e.SubjectId)
                .HasDefaultValue(-1)
                .HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTPartnerProfile>(entity =>
        {
            entity.HasKey(e => e.PartnerId);

            entity.ToTable("WDI_T_PartnerProfile");

            entity.Property(e => e.PartnerId).ValueGeneratedNever();
            entity.Property(e => e.Affiliationno)
                .HasMaxLength(200)
                .HasDefaultValue("000000")
                .HasColumnName("AFFILIATIONNO");
            entity.Property(e => e.BackgroundColor).HasMaxLength(20);
            entity.Property(e => e.BackgroundImage).HasMaxLength(200);
            entity.Property(e => e.BankDetails).HasMaxLength(500);
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .HasDefaultValue("Principal");
            entity.Property(e => e.ExperienceDetails).HasColumnType("ntext");
            entity.Property(e => e.FontColor).HasMaxLength(20);
            entity.Property(e => e.FontType).HasMaxLength(100);
            entity.Property(e => e.FormationDate).HasColumnType("datetime");
            entity.Property(e => e.MembersofHonor).HasMaxLength(500);
            entity.Property(e => e.PartnerDesc).HasMaxLength(2000);
            entity.Property(e => e.PartnerImage).HasMaxLength(200);
            entity.Property(e => e.PartnerTitle).HasMaxLength(150);
            entity.Property(e => e.Qualification).HasMaxLength(200);
            entity.Property(e => e.SchoolCategories).HasMaxLength(400);
            entity.Property(e => e.Schoolcode)
                .HasMaxLength(200)
                .HasDefaultValue("000000")
                .HasColumnName("SCHOOLCODE");
            entity.Property(e => e.Schooludisecode)
                .HasMaxLength(200)
                .HasDefaultValue("000000")
                .HasColumnName("SCHOOLUDISECODE");
            entity.Property(e => e.Subjects).HasColumnType("ntext");
            entity.Property(e => e.TotalExperience).HasMaxLength(200);
        });

        modelBuilder.Entity<WdiTPartnerScheduler>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_Partner_Scheduler");

            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SchedulerFor).HasMaxLength(40);
            entity.Property(e => e.SchedulerId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SchedulerID");
            entity.Property(e => e.SchedulerType).HasMaxLength(40);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTPartnerTemplate>(entity =>
        {
            entity.HasKey(e => e.PartnerTemplateId);

            entity.ToTable("WDI_T_PartnerTemplates");

            entity.Property(e => e.PartnerTemplateId).HasColumnName("PartnerTemplateID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.EmailTemplateText).HasDefaultValue("");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RelatedTo).HasMaxLength(100);
            entity.Property(e => e.SmstemplateText)
                .HasDefaultValue("")
                .HasColumnName("SMSTemplateText");
            entity.Property(e => e.TemplateColumns).HasMaxLength(2000);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.TemplateName).HasMaxLength(200);
            entity.Property(e => e.TraiTemplateid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("1507161710172185588");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTPartnerTemplatesNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_PartnerTemplates_New");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.EmailTemplateText).IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PartnerTemplateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PartnerTemplateID");
            entity.Property(e => e.RelatedTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SmstemplateText)
                .IsUnicode(false)
                .HasColumnName("SMSTemplateText");
            entity.Property(e => e.TemplateColumns)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.TemplateName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTPayRollAccountTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_PayRollAccountTransactions");

            entity.Property(e => e.AcTransRefNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Bank)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Month)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PayRollHeadId).HasColumnName("PayRollHeadID");
            entity.Property(e => e.PayTranId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PayTranID");
        });

        modelBuilder.Entity<WdiTPayRollSalaryRangeTransaction>(entity =>
        {
            entity.ToTable("Wdi_T_PayRollSalaryRangeTransactions");

            entity.Property(e => e.ProllTemplateId)
                .HasDefaultValue(-1L)
                .HasColumnName("PRollTemplateId");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<WdiTPayTransaction>(entity =>
        {
            entity.HasKey(e => e.Ptid).HasName("PK__WDI_T_Pa__BCC07F6F71FD0264");

            entity.ToTable("WDI_T_PayTransactions");

            entity.Property(e => e.Ptid).HasColumnName("PTId");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HeadId).HasColumnName("HeadID");
            entity.Property(e => e.Installment).HasMaxLength(50);
            entity.Property(e => e.InstallmentStartMonth).HasMaxLength(50);
            entity.Property(e => e.Month).HasMaxLength(20);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTPayTransactionRemark>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wdi_t_PayTransactionRemarks");

            entity.Property(e => e.Month).HasMaxLength(40);
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.RemarksId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiTPayrollLoanAdvancesPaymentSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__WDI_T_Pa__9C8A5B691ADF4F1A");

            entity.ToTable("WDI_T_PayrollLoanAdvancesPaymentSchedules");

            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.AmountPaid)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BalanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("EDUSYNC");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InstallmentMonth).HasMaxLength(20);
            entity.Property(e => e.InterestComponent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LoanId).HasColumnName("LoanID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(20)
                .HasDefaultValue("Pending");
            entity.Property(e => e.PrincipalComponent).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<WdiTPayrollLoansAdvance>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PK__WDI_T_Pa__4F5AD437459283CD");

            entity.ToTable("WDI_T_PayrollLoansAdvances");

            entity.Property(e => e.LoanId).HasColumnName("LoanID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("EDUSYNC");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InterestAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InterestRate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.LoanStatus)
                .HasMaxLength(20)
                .HasDefaultValue("Active");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasDefaultValue(-1L);
            entity.Property(e => e.PrincipalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTPaytmpgplusresponse>(entity =>
        {
            entity.ToTable("WDI_T_PAYTMPGPLUSRESPONSE");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnrollNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ItemId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaytmInfo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PaytmLog)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTPeriodAttendanceDetail>(entity =>
        {
            entity.HasKey(e => e.PeriodAttDetailsId);

            entity.ToTable("WDI_T_PeriodAttendanceDetails");

            entity.Property(e => e.PeriodAttDetailsId).HasColumnName("PeriodAttDetailsID");
            entity.Property(e => e.AttDate).HasColumnType("datetime");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.FacultyUserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FacultyUserID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTPeriodConfig>(entity =>
        {
            entity.HasKey(e => e.PeriodConfigIdPk).HasName("WDI_T_PeriodConfig_PeriodConfigID_PK");

            entity.ToTable("WDI_T_PeriodConfig");

            entity.Property(e => e.PeriodConfigIdPk).HasColumnName("PeriodConfigID_PK");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedById)
                .HasMaxLength(40)
                .HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FromDay).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LunchAfterPeriodId).HasColumnName("LunchAfterPeriodID");
            entity.Property(e => e.LunchDuration).HasMaxLength(50);
            entity.Property(e => e.ModifiedById)
                .HasMaxLength(40)
                .HasColumnName("ModifiedByID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SchoolEndTime).HasMaxLength(50);
            entity.Property(e => e.SchoolStartTime).HasMaxLength(50);
            entity.Property(e => e.TimeTableConfigIdFk).HasColumnName("TimeTableConfigID_FK");
            entity.Property(e => e.ToDay).HasMaxLength(50);

            entity.HasOne(d => d.TimeTableConfigIdFkNavigation).WithMany(p => p.WdiTPeriodConfigs)
                .HasForeignKey(d => d.TimeTableConfigIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WDI_T_PeriodConfig_TimeTableConfigID_FK");
        });

        modelBuilder.Entity<WdiTPeriodSmsDetail>(entity =>
        {
            entity.HasKey(e => e.PeriodSmsDetailsId).HasName("PK__WDI_T_Pe__0A3C2AE9475463EC");

            entity.ToTable("WDI_T_PeriodSmsDetails");

            entity.Property(e => e.PeriodSmsDetailsId).HasColumnName("PeriodSmsDetailsID");
            entity.Property(e => e.AbsentUserIds)
                .IsUnicode(false)
                .HasColumnName("AbsentUserIDs");
            entity.Property(e => e.AttDate).HasColumnType("datetime");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.FacultyUserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FacultyUserID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTPgatomCallBackDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_T_PG__3214EC2701E7A7AA");

            entity.ToTable("WDI_T_PGAtomCallBackDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amt)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("AMT");
            entity.Property(e => e.AtomTxnId).HasMaxLength(100);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.BankRefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bank_ref_no");
            entity.Property(e => e.Bid)
                .HasMaxLength(100)
                .HasColumnName("BID");
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("billing_address");
            entity.Property(e => e.BillingCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("billing_city");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("billing_country");
            entity.Property(e => e.BillingEmail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("billing_email");
            entity.Property(e => e.BillingName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("billing_name");
            entity.Property(e => e.BillingState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("billing_state");
            entity.Property(e => e.BillingTel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("billing_tel");
            entity.Property(e => e.BillingZip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("billing_zip");
            entity.Property(e => e.CardName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("card_name");
            entity.Property(e => e.CardNumber).HasMaxLength(100);
            entity.Property(e => e.Clientcode).HasMaxLength(100);
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.CustomerAccNo).HasMaxLength(100);
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("delivery_address");
            entity.Property(e => e.DeliveryCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("delivery_city");
            entity.Property(e => e.DeliveryCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("delivery_country");
            entity.Property(e => e.DeliveryName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("delivery_name");
            entity.Property(e => e.DeliveryState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("delivery_state");
            entity.Property(e => e.DeliveryTel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("delivery_tel");
            entity.Property(e => e.DeliveryZip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("delivery_zip");
            entity.Property(e => e.Discriminator).HasMaxLength(100);
            entity.Property(e => e.FailureMessage)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("failure_message");
            entity.Property(e => e.MerchantId)
                .HasMaxLength(100)
                .HasColumnName("merchantID");
            entity.Property(e => e.MerchantParam1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("merchant_param1");
            entity.Property(e => e.MerchantParam2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("merchant_param2");
            entity.Property(e => e.MerchantParam3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("merchant_param3");
            entity.Property(e => e.MerchantParam4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("merchant_param4");
            entity.Property(e => e.MerchantParam5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("merchant_param5");
            entity.Property(e => e.MerchantTxnId)
                .HasMaxLength(100)
                .HasColumnName("MerchantTxnID");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("order_id");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("order_status");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payment_mode");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status_code");
            entity.Property(e => e.StatusMessage)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("status_message");
            entity.Property(e => e.Surcharge).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TrackingId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tracking_id");
            entity.Property(e => e.TxnDate).HasMaxLength(100);
            entity.Property(e => e.Verified)
                .HasMaxLength(100)
                .HasColumnName("VERIFIED");
        });

        modelBuilder.Entity<WdiTPgfeePayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("WDI_T_PGFeePayments");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AccountNo).HasMaxLength(200);
            entity.Property(e => e.AckReceiptNo).HasMaxLength(400);
            entity.Property(e => e.Acknowledge).HasDefaultValue(-1);
            entity.Property(e => e.ActualReceiptNoGenerated)
                .HasMaxLength(200)
                .HasDefaultValueSql("((-1))");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.CollectedBranchUser).HasMaxLength(100);
            entity.Property(e => e.CollectedBranchname).HasMaxLength(1000);
            entity.Property(e => e.DateOfDelete).HasColumnType("datetime");
            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.MerchantTransId)
                .HasMaxLength(400)
                .HasColumnName("MerchantTransID");
            entity.Property(e => e.ModeOfPayment).HasMaxLength(50);
            entity.Property(e => e.PaidBy).HasMaxLength(150);
            entity.Property(e => e.PgfeeProcessStatus).HasColumnName("PGFeeProcessStatus");
            entity.Property(e => e.PgstatusId)
                .HasDefaultValue(0)
                .HasColumnName("PGStatusID");
            entity.Property(e => e.RecStatus).HasDefaultValue(true);
            entity.Property(e => e.ReceiptNo).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.Transcharges)
                .HasDefaultValue(0m)
                .HasColumnType("money");
        });

        modelBuilder.Entity<WdiTPgfeePaymentDetail>(entity =>
        {
            entity.HasKey(e => e.PaymentDetailsId).HasName("PK_WDI_T_PGFeePaymentDetails_1");

            entity.ToTable("WDI_T_PGFeePaymentDetails");

            entity.Property(e => e.PaymentDetailsId).HasColumnName("PaymentDetailsID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.LastPaidDate).HasColumnType("datetime");
            entity.Property(e => e.PaidAmount)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
        });

        modelBuilder.Entity<WdiTPgfineAmountDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_PGFineAmountDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.FineAmount).HasColumnType("money");
            entity.Property(e => e.FineConcesion).HasColumnType("money");
            entity.Property(e => e.FineId).ValueGeneratedOnAdd();
            entity.Property(e => e.FinePaid).HasColumnType("money");
            entity.Property(e => e.Finereceiptno).HasMaxLength(100);
            entity.Property(e => e.Mappingstatus)
                .HasDefaultValue(false)
                .HasColumnName("mappingstatus");
            entity.Property(e => e.Paidby).HasMaxLength(100);
            entity.Property(e => e.Paiddate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.UserId).HasMaxLength(150);
        });

        modelBuilder.Entity<WdiTPgrequest>(entity =>
        {
            entity.HasKey(e => e.PgrequestId);

            entity.ToTable("WDI_T_PGRequest");

            entity.Property(e => e.PgrequestId).HasColumnName("PGRequestID");
            entity.Property(e => e.Amt).HasColumnType("money");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyCode).HasMaxLength(10);
            entity.Property(e => e.ExtraFields).HasColumnType("xml");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PgtransactionId).HasColumnName("PGTransactionID");
            entity.Property(e => e.RequestType).HasMaxLength(50);
            entity.Property(e => e.RequestUrl)
                .HasMaxLength(1024)
                .HasColumnName("RequestURL");
            entity.Property(e => e.ReturnUrl)
                .HasMaxLength(1024)
                .HasColumnName("ReturnURL");
        });

        modelBuilder.Entity<WdiTPgresponse>(entity =>
        {
            entity.HasKey(e => e.PgresponseId);

            entity.ToTable("WDI_T_PGResponse");

            entity.Property(e => e.PgresponseId).HasColumnName("PGResponseID");
            entity.Property(e => e.Amt).HasColumnType("numeric(15, 2)");
            entity.Property(e => e.BankTxnRefNo).HasMaxLength(100);
            entity.Property(e => e.ClientRefNo).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExtraFields).HasColumnType("xml");
            entity.Property(e => e.PgrequestId).HasColumnName("PGRequestID");
            entity.Property(e => e.PgtxnErrMsg)
                .HasMaxLength(100)
                .HasColumnName("PGTxnErrMsg");
            entity.Property(e => e.PgtxnMsg)
                .HasMaxLength(20)
                .HasColumnName("PGTxnMsg");
            entity.Property(e => e.PgtxnRefNo)
                .HasMaxLength(100)
                .HasColumnName("PGTxnRefNo");
            entity.Property(e => e.PgtxnStatusCode)
                .HasMaxLength(20)
                .HasColumnName("PGTxnStatusCode");
            entity.Property(e => e.RequestToken).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTPgsplFeeTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_PGSplFeeTransactions");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FeeId).HasColumnName("FeeID");
            entity.Property(e => e.ModeOfPayment).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Receipt).HasMaxLength(100);
            entity.Property(e => e.TransactionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TransactionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTPgtransaction>(entity =>
        {
            entity.HasKey(e => e.PgtransactionId);

            entity.ToTable("WDI_T_PGTransactions");

            entity.Property(e => e.PgtransactionId).HasColumnName("PGTransactionID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ApplicationNo).HasDefaultValue(-1);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MerchantSurchargeAmount).HasColumnType("money");
            entity.Property(e => e.MerchantTransactionId)
                .HasMaxLength(50)
                .HasColumnName("MerchantTransactionID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerMerchantId).HasColumnName("PartnerMerchantID");
            entity.Property(e => e.PgstatusId).HasColumnName("PGStatusID");
            entity.Property(e => e.TransactionAmount).HasColumnType("money");
            entity.Property(e => e.TransactionTimestamp).HasColumnType("datetime");
            entity.Property(e => e.Transsource)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UCWEB")
                .HasColumnName("TRANSSOURCE");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTPocketAndMedicalBalance>(entity =>
        {
            entity.HasKey(e => e.PaymentId);

            entity.ToTable("WDI_T_PocketAndMedicalBalance");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(50)
                .HasDefaultValue("0");
            entity.Property(e => e.PaymentType).HasMaxLength(400);
            entity.Property(e => e.ServiceType).HasMaxLength(400);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Not Processed");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.UseId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTPocketAndMedicalService>(entity =>
        {
            entity.HasKey(e => e.TransId);

            entity.ToTable("WDI_T_PocketAndMedicalServices");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BankCharges).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreditDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(50)
                .HasDefaultValue("0");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PaymentType).HasMaxLength(400);
            entity.Property(e => e.ProceedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProceedNumber)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Recstatus).HasDefaultValue(true);
            entity.Property(e => e.Remarks).HasMaxLength(600);
            entity.Property(e => e.ServiceType).HasMaxLength(400);
            entity.Property(e => e.TranRefNo)
                .HasMaxLength(200)
                .HasColumnName("Tran_RefNo");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.UseId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTPrePostProcessLog>(entity =>
        {
            entity.HasKey(e => e.PrePostId);

            entity.ToTable("WDI_T_PrePostProcessLog");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.PostProcessDate).HasColumnType("datetime");
            entity.Property(e => e.PostProcessDoneBy).HasMaxLength(100);
            entity.Property(e => e.PreProcessDate).HasColumnType("datetime");
            entity.Property(e => e.PreProcessDoneBy).HasMaxLength(100);
            entity.Property(e => e.SourceMonth).HasMaxLength(20);
            entity.Property(e => e.TargetMonth).HasMaxLength(20);
        });

        modelBuilder.Entity<WdiTPublishDateofBirthStatus>(entity =>
        {
            entity.ToTable("WDI_T_PublishDateofBirthStatus");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SendTo).HasMaxLength(100);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTPurchaseOrderDetail>(entity =>
        {
            entity.ToTable("WDI_T_PurchaseOrderDetails");

            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Supplierid).HasColumnName("supplierid");
            entity.Property(e => e.VoucherNo).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTQuickConnectSm>(entity =>
        {
            entity.HasKey(e => e.QuickConnectSmsid);

            entity.ToTable("WDI_T_QuickConnectSMS");

            entity.Property(e => e.QuickConnectSmsid).HasColumnName("QuickConnectSMSID");
            entity.Property(e => e.SendOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Smsstatus)
                .HasComment("0 - SMS Send Failed , 1 - SMS Send Successfull.")
                .HasColumnName("SMSStatus");
        });

        modelBuilder.Entity<WdiTRefundDetail>(entity =>
        {
            entity.HasKey(e => e.RefundId);

            entity.ToTable("WDI_T_RefundDetails");

            entity.Property(e => e.RefundId).HasColumnName("RefundID");
            entity.Property(e => e.AccNumber).HasColumnName("Acc_Number");
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.FeeHeadId).HasColumnName("FeeHeadID");
            entity.Property(e => e.ModeOfRefund).HasMaxLength(40);
            entity.Property(e => e.ReceiptNo).HasMaxLength(100);
            entity.Property(e => e.RefundAmount).HasColumnType("money");
            entity.Property(e => e.RefundedBy).HasMaxLength(100);
            entity.Property(e => e.RefundedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(200);
        });

        modelBuilder.Entity<WdiTRegularAttendanceRawDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_RegularAttendanceRawData");

            entity.Property(e => e.AttendanceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AttendanceID");
            entity.Property(e => e.AttnDetails).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MachineNo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Remarks).HasMaxLength(250);
        });

        modelBuilder.Entity<WdiTReportTemplate>(entity =>
        {
            entity.HasKey(e => e.ReportTemplateId).HasName("PK_ramaschema.WDI_T_ReportTemplates");

            entity.ToTable("WDI_T_ReportTemplates");

            entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RelatedTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReportTemplateName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.XsltemplateText)
                .IsUnicode(false)
                .HasColumnName("XSLTemplateText");
        });

        modelBuilder.Entity<WdiTRoleSpecificHoliday>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_RoleSpecificHolidays");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.HolidayDate).HasColumnType("datetime");
            entity.Property(e => e.HolidayTitle).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RoleHolidayId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RoleHolidayID");
            entity.Property(e => e.RoleId)
                .HasDefaultValue(-1L)
                .HasColumnName("RoleID");
            entity.Property(e => e.SchoolLeaveId)
                .HasDefaultValue(-1L)
                .HasColumnName("SchoolLeaveID");
        });

        modelBuilder.Entity<WdiTSchedulerDataFilter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_Scheduler_DataFilter");

            entity.Property(e => e.FilterCondition).HasMaxLength(2000);
            entity.Property(e => e.SchedulerDataId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SchedulerDataID");
            entity.Property(e => e.SchedulerId).HasColumnName("SchedulerID");
            entity.Property(e => e.ToAddressCondition).HasMaxLength(2000);
        });

        modelBuilder.Entity<WdiTSchedulerDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_Scheduler_Details");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ScheduleDetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ScheduleDetID");
            entity.Property(e => e.SchedulerId).HasColumnName("SchedulerID");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTScholasticGrade>(entity =>
        {
            entity.HasKey(e => e.ScholasticGradeId).HasName("WDI_T_ScholasticGrades_ScholasticGradeId");

            entity.ToTable("WDI_T_ScholasticGrades");

            entity.Property(e => e.ClassId).HasComment("If Select All Classes default class id will be 0 . Otherwise whatever client selected class id will be saved.");
            entity.Property(e => e.Grade).HasMaxLength(5);
        });

        modelBuilder.Entity<WdiTSchoolTimeTable>(entity =>
        {
            entity.ToTable("WDI_T_SchoolTimeTable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.FromTime)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PeriodId).HasColumnName("PeriodID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            entity.Property(e => e.SeasonId).HasColumnName("SeasonID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.ToTime)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTSchoolTimeTableOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_SchoolTimeTable_Old");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.FromTime).HasMaxLength(20);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PeriodId).HasColumnName("PeriodID");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.ToTime).HasMaxLength(20);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTSessionAttendee>(entity =>
        {
            entity.HasKey(e => e.AttendeeId);

            entity.ToTable("WDI_T_SessionAttendees");

            entity.Property(e => e.AttendeeId).HasColumnName("AttendeeID");
            entity.Property(e => e.SessionId)
                .HasMaxLength(100)
                .HasColumnName("SessionID");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTSkillMapping>(entity =>
        {
            entity.HasKey(e => e.SkillMappingId).HasName("PK_SkillMappings");

            entity.ToTable("WDI_T_SkillMappings");

            entity.Property(e => e.SkillMappingId).HasColumnName("SkillMappingID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
        });

        modelBuilder.Entity<WdiTSkillmark>(entity =>
        {
            entity.HasKey(e => e.SkillMarksId);

            entity.ToTable("WDI_T_SKILLMARKS");

            entity.HasIndex(e => e.UserId, "SKillMarks_UserID");

            entity.Property(e => e.SkillMarksId).HasColumnName("SkillMarksID");
            entity.Property(e => e.EnteredBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EnteredDate).HasColumnType("datetime");
            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.Marks).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(400);
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTSmsdetail>(entity =>
        {
            entity.ToTable("WDI_T_SMSDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SmsPriority)
                .HasDefaultValue((short)1)
                .HasComment("0: Low; 1: medium; 2-highest")
                .HasColumnName("SMS_PRIORITY");
            entity.Property(e => e.SmsStatus)
                .HasDefaultValue((short)0)
                .HasColumnName("SMS_Status");
            entity.Property(e => e.SmsTypeId).HasColumnName("SMS_Type_ID");
            entity.Property(e => e.SmsdateandTime)
                .HasColumnType("datetime")
                .HasColumnName("SMSDateandTime");
            entity.Property(e => e.SmssentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SMSSentDate");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTSplFeeParticular>(entity =>
        {
            entity.HasKey(e => e.FeeId);

            entity.ToTable("WDI_T_SplFeeParticulars");

            entity.Property(e => e.FeeId).HasColumnName("FeeID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FeeName).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.TaxConfigMid)
                .HasDefaultValue(-1L)
                .HasColumnName("TaxConfigMID");
            entity.Property(e => e.TaxInclorExcl)
                .HasMaxLength(50)
                .HasDefaultValue("INCLUSIVE")
                .HasColumnName("TaxINCLorEXCL");
        });

        modelBuilder.Entity<WdiTSplFeeTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.ToTable("WDI_T_SplFeeTransactions");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FeeId).HasColumnName("FeeID");
            entity.Property(e => e.ModeOfPayment).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Receipt).HasMaxLength(100);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStagingAccountTransaction>(entity =>
        {
            entity.HasKey(e => e.TransId);

            entity.ToTable("WDI_T_StagingAccountTransactions");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CrAmount).HasColumnType("money");
            entity.Property(e => e.CrClosingBalance).HasColumnType("money");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.DrAmount).HasColumnType("money");
            entity.Property(e => e.DrClosingBalance).HasColumnType("money");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.Labour).HasColumnType("money");
            entity.Property(e => e.M2mtransId)
                .HasDefaultValue(-1L)
                .HasColumnName("M2MTransId");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Narration).HasMaxLength(600);
            entity.Property(e => e.OrganizationId).HasDefaultValue(-1L);
            entity.Property(e => e.PartnerId).HasDefaultValue(-1L);
            entity.Property(e => e.Status).HasComment("0 means Pending..1 means Approved..-1 means Rejected");
            entity.Property(e => e.TranRefNo)
                .HasMaxLength(200)
                .HasColumnName("Tran_RefNo");
            entity.Property(e => e.UcbfinancialYearId)
                .HasDefaultValue(-1L)
                .HasColumnName("UCBFinancialYearID");
            entity.Property(e => e.VoucherDate).HasColumnType("datetime");
            entity.Property(e => e.VoucherNo).HasMaxLength(100);
            entity.Property(e => e.VoucherType)
                .HasMaxLength(400)
                .HasComment("Payment,Receipt,Contra,Sales,Purchase");
        });

        modelBuilder.Entity<WdiTStudentAcademicDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WDI_T_Student_Academic_Details");

            entity.ToTable("WDI_T_StudentAcademicDetails");

            entity.HasIndex(e => new { e.AcademicYearId, e.ProfileStatus }, "IX_StudentAcademicDetails_ACADEMICYEARID_ProfileStatus");

            entity.HasIndex(e => e.UserId, "IX_WDI_T_StudentAcademicDetails");

            entity.HasIndex(e => e.ProfileStatus, "IX_WDI_T_StudentAcademicDetails_1");

            entity.HasIndex(e => new { e.UserId, e.ClassId, e.AcademicYearId }, "NCI_SAD001");

            entity.HasIndex(e => e.UserId, "NonClusterdIndex_UserID_WDI_T_StudentAcademicDetails");

            entity.HasIndex(e => new { e.AcademicYearId, e.ClassId, e.Section, e.ProfileStatus }, "WDI_T_StudentAcademicDetails_AcademicYearId");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicRemarks).HasMaxLength(500);
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Branches)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UniCampus");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ElectiveSubjects).HasMaxLength(100);
            entity.Property(e => e.FeeGroupId).HasDefaultValue((short)-1);
            entity.Property(e => e.FeeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PayType)
                .HasMaxLength(20)
                .HasDefaultValue("FULL PAYMENT");
            entity.Property(e => e.ProfileStatus)
                .HasMaxLength(100)
                .HasDefaultValue("ACTIVE");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReportingDate).HasColumnType("datetime");
            entity.Property(e => e.RollNo).HasMaxLength(20);
            entity.Property(e => e.Scholarshipid)
                .HasDefaultValue(-1)
                .HasColumnName("scholarshipid");
            entity.Property(e => e.Secondlanguage).HasDefaultValue(-1L);
            entity.Property(e => e.Stream)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stream");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.WdiTStudentAcademicDetails)
                .HasForeignKey(d => d.AcademicYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WDI_T_Student_Academic_Details_WDI_M_AcademicYear_Details");
        });

        modelBuilder.Entity<WdiTStudentAcademicProfile>(entity =>
        {
            entity.ToTable("WDI_T_StudentAcademicProfile");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FirstLanguage).HasDefaultValue(-1L);
            entity.Property(e => e.SecondLanguage).HasDefaultValue(-1L);
            entity.Property(e => e.ThirdLanguage).HasDefaultValue(-1L);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTStudentActivity>(entity =>
        {
            entity.ToTable("WDI_T_StudentActivities");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStudentBatchDetail>(entity =>
        {
            entity.ToTable("WDI_T_StudentBatchDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.BatchId).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStudentCoScholasticMark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("WDI_T_StudentCoScholasticMarks_Id");

            entity.ToTable("WDI_T_StudentCoScholasticMarks");

            entity.Property(e => e.Grade).HasMaxLength(2);
            entity.Property(e => e.SecuredMarks).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TermorExamId).HasDefaultValue(-1L);
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTStudentConsolidatedExamResult>(entity =>
        {
            entity.HasKey(e => new { e.PartnerId, e.AcademicYearId, e.ClassId, e.SectionId, e.UserId, e.ExaminationId });

            entity.ToTable("WDI_T_StudentConsolidatedExamResults");

            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");
            entity.Property(e => e.Cgpa)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("CGPA");
            entity.Property(e => e.Grade)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.GradePoint).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Percentage)
                .HasComputedColumnSql("(CONVERT([decimal](15,2),([TotalSecuredMarks]/[TotalMaxMarks])*(100),(0)))", false)
                .HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Tgp)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("TGP");
            entity.Property(e => e.TotalMaxMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TotalSecuredMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Tsgrade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TSGrade");
            entity.Property(e => e.Tsscore)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("TSScore");
        });

        modelBuilder.Entity<WdiTStudentExamDetail>(entity =>
        {
            entity.ToTable("WDI_T_StudentExamDetails");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTStudentExamRemark>(entity =>
        {
            entity.ToTable("WDI_T_StudentExamRemarks");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.RemarkId).HasColumnName("RemarkID");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStudentFeeDetail>(entity =>
        {
            entity.HasKey(e => e.StudentFeeId).HasName("PK_WDI_T_StudentFeeDetails_1");

            entity.ToTable("WDI_T_StudentFeeDetails");

            entity.HasIndex(e => e.UserId, "NonClusterdIndex_UserID_WDI_T_StudentFeeDetails");

            entity.Property(e => e.StudentFeeId).HasColumnName("StudentFeeID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.LastPaidDate).HasColumnType("datetime");
            entity.Property(e => e.OldDues)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.TotalAmountToBePaid).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStudentFeeDueDetail>(entity =>
        {
            entity.HasKey(e => e.FeeDueId);

            entity.ToTable("WDI_T_StudentFeeDueDetails");

            entity.HasIndex(e => e.FeeHeadId, "NonClusterdIndex_FeeHeadID_WDI_T_StudentFeeDetails");

            entity.HasIndex(e => e.UserId, "NonClusterdIndex_UserID_WDI_T_StudentFeeDueDetails");

            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ConcessionAmt)
                .HasDefaultValue(0.0m)
                .HasColumnType("money");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UC");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FeeFor)
                .HasMaxLength(50)
                .HasComment("If Fee Due for Month,Quarter,Half Yearly or Year then specify in this Column as Jan-13,Quarter-1,HYear-1, Yearly-1");
            entity.Property(e => e.FeeHeadId).HasColumnName("FeeHeadID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UC");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.RecStatus)
                .HasDefaultValue(true)
                .HasComment("0 - Record Deleted, 1 - Record Active");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.Status)
                .HasDefaultValue(false)
                .HasComment("0 - If Student Payment is DUE.  1 - If Student Has Paid the DUE Amount.");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStudentHealthDetail>(entity =>
        {
            entity.HasKey(e => e.HealthDetailsId);

            entity.ToTable("WDI_T_StudentHealthDetails");

            entity.Property(e => e.HealthDetailsId).HasColumnName("HealthDetailsID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.UserId)
                .HasMaxLength(150)
                .HasColumnName("UserID");
            entity.Property(e => e.Weightinkg).HasColumnType("decimal(15, 2)");
        });

        modelBuilder.Entity<WdiTStudentHealthIssue>(entity =>
        {
            entity.HasKey(e => e.HealthIssueId);

            entity.ToTable("WDI_T_StudentHealthIssues");

            entity.Property(e => e.AcademicYearId)
                .HasDefaultValue(70L)
                .HasColumnName("AcademicYearID");
            entity.Property(e => e.BalanceAmount).HasColumnType("money");
            entity.Property(e => e.DietSuggested).HasMaxLength(500);
            entity.Property(e => e.HealthActiontaken).HasMaxLength(200);
            entity.Property(e => e.HealthIssueDate).HasColumnType("datetime");
            entity.Property(e => e.HealthIssueDescription).HasMaxLength(500);
            entity.Property(e => e.HealthIssueTitle).HasMaxLength(200);
            entity.Property(e => e.MedicineCharges).HasColumnType("money");
            entity.Property(e => e.OtherCharges).HasColumnType("money");
            entity.Property(e => e.SickFromDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SickToDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TranRefNo)
                .HasMaxLength(200)
                .HasColumnName("Tran_RefNo");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTStudentHistoricalDet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WDI_T_StudentHistoricalDet_2");

            entity.ToTable("WDI_T_StudentHistoricalDet");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.PageType).HasComment("Here PageType=0  --> Equiry Data\r\n         PageType=1  -->Application Data\r\n         PageType=0  --> Admission Data");
            entity.Property(e => e.PreviousInstituteDetails).HasColumnType("xml");
            entity.Property(e => e.SchoolAddress).HasMaxLength(500);
            entity.Property(e => e.SchoolId).HasColumnName("SchoolID");
            entity.Property(e => e.StudentAddress).HasColumnType("xml");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiTStudentLeaveTransaction>(entity =>
        {
            entity.HasKey(e => e.StudentLeaveId);

            entity.ToTable("WDI_T_StudentLeaveTransactions");

            entity.Property(e => e.StudentLeaveId).HasColumnName("StudentLeaveID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.DateOfApply).HasColumnType("datetime");
            entity.Property(e => e.DateOfProcessed).HasColumnType("datetime");
            entity.Property(e => e.LeaveDays).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.LeaveFromDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveFromValue).HasMaxLength(100);
            entity.Property(e => e.LeaveSanctionedDays).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.LeaveSanctionedFromDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveSanctionedFromValue).HasMaxLength(100);
            entity.Property(e => e.LeaveSanctionedToDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveSanctionedToValue).HasMaxLength(100);
            entity.Property(e => e.LeaveToDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveToValue).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ProcessedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessedReason).HasMaxLength(100);
            entity.Property(e => e.Reason).HasColumnType("ntext");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasDefaultValue("Pending");
            entity.Property(e => e.SupportDocuments).HasMaxLength(400);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStudentLookup>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__WDI_T_St__1788CC4C63DBE026");

            entity.ToTable("WDI_T_StudentLookup");

            entity.Property(e => e.UserId).HasMaxLength(40);
            entity.Property(e => e.AdmissionNo).HasMaxLength(100);
            entity.Property(e => e.Fname)
                .HasMaxLength(100)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(100)
                .HasColumnName("LName");
            entity.Property(e => e.ParentTeacher)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SiblingAdmissionNo).HasMaxLength(400);
            entity.Property(e => e.SiblingName).HasMaxLength(400);
            entity.Property(e => e.SiblingUserId).HasMaxLength(400);
            entity.Property(e => e.StudentType).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiTStudentMigrationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wdi_T_St__3214EC27864B146C");

            entity.ToTable("Wdi_T_StudentMigrationLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApprovedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Requeststatus).HasMaxLength(50);
            entity.Property(e => e.SourceAcademicYearId).HasColumnName("SourceAcademicYearID");
            entity.Property(e => e.SourcePartnerId).HasColumnName("SourcePartnerID");
            entity.Property(e => e.StudentUserId).HasMaxLength(150);
            entity.Property(e => e.TargetAcademicyearId).HasColumnName("TargetAcademicyearID");
            entity.Property(e => e.TargetpartnerId).HasColumnName("TargetpartnerID");
            entity.Property(e => e.TransferdType).HasMaxLength(80);
            entity.Property(e => e.TransferrefNo).HasMaxLength(50);
            entity.Property(e => e.VerifiedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTStudentSecurityDepositDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_StudentSecurityDepositDetails");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ApplicationNo).HasDefaultValueSql("('-1')");
            entity.Property(e => e.CollectedBy)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DepositId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DepositID");
            entity.Property(e => e.DepositType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("DD");
            entity.Property(e => e.DepositedBy)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.FeeDueId).HasColumnName("FeeDueID");
            entity.Property(e => e.FeeHeadId).HasColumnName("FeeHeadID");
            entity.Property(e => e.FeeReceiptNo).HasMaxLength(150);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RefernceNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RefundableAmount).HasColumnType("money");
            entity.Property(e => e.RefundableDate).HasColumnType("datetime");
            entity.Property(e => e.RefundedAmtGivenBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RefundedAmtGivenTo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RefundedToAccount)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("OPEN");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStudentSemisterDetail>(entity =>
        {
            entity.ToTable("WDI_T_StudentSemisterDetails");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.BatchId).HasMaxLength(50);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.SectionId).HasDefaultValue(-1L);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTStudentStypendAmountDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_StudentStypendAmountDetails");

            entity.Property(e => e.AcademicyearId).HasColumnName("AcademicyearID");
            entity.Property(e => e.AdmissionNo).HasMaxLength(100);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.Createdby).HasMaxLength(400);
            entity.Property(e => e.FeeFor).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Modifiedby).HasMaxLength(400);
            entity.Property(e => e.Modifieddate).HasColumnType("datetime");
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTSupportQuery>(entity =>
        {
            entity.ToTable("WDI_T_SupportQueries");

            entity.Property(e => e.Addquery)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfContact)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateOfReply).HasColumnType("datetime");
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobileNo).HasMaxLength(256);
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.Query).HasMaxLength(2000);
            entity.Property(e => e.Response).HasMaxLength(1000);
            entity.Property(e => e.Status)
                .HasDefaultValue((byte)1)
                .HasComment("1 - Pending, 2 - Process, 3 -  Complete, 4 - Rejected.");
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.SupportId)
                .HasMaxLength(100)
                .HasDefaultValue("INT");
            entity.Property(e => e.TypeofContact)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Q");
        });

        modelBuilder.Entity<WdiTTask>(entity =>
        {
            entity.HasKey(e => e.HomeworkTaskId);

            entity.ToTable("WDI_T_Tasks");

            entity.Property(e => e.HomeworkTaskId).HasColumnName("HomeworkTaskID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AttachmentId)
                .HasMaxLength(20)
                .HasColumnName("AttachmentID");
            entity.Property(e => e.AttachmentName).HasMaxLength(100);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.Color).HasMaxLength(100);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(40)
                .HasComment("Who created task or home work");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RemainderTime).HasMaxLength(20);
            entity.Property(e => e.SectionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SectionID");
            entity.Property(e => e.Smsrequired).HasColumnName("SMSRequired");
            entity.Property(e => e.Status).HasComment("0-Pending, 1-Completed, 2 - Cancelled");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.Title).HasMaxLength(150);
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("H = Home work, N-Notice");
        });

        modelBuilder.Entity<WdiTTaskSmsemailstatus>(entity =>
        {
            entity.HasKey(e => e.TaskStatusId);

            entity.ToTable("WDI_T_TaskSMSEMAILStatus");

            entity.Property(e => e.TaskStatusId).HasColumnName("TaskStatusID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HomeworkTaskId).HasColumnName("HomeworkTaskID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SendDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Smsstatus).HasColumnName("SMSStatus");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SubmissionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TaskStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("PENDING");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTTemplateExamMark>(entity =>
        {
            entity.HasKey(e => e.TemplateExamMarksId).HasName("PK__WDI_T_Te__D814E358176F27A5");

            entity.ToTable("WDI_T_TemplateExamMarks");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Marks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.MarksFormatted)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTTemplateMark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_T_Te__3214EC0766481B48");

            entity.ToTable("WDI_T_TemplateMarks");

            entity.Property(e => e.AssignmentMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.AssignmentmarksFormatted)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExamTemplateId).HasDefaultValue(-1L);
            entity.Property(e => e.ExternalMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ExternalmarksFormatted)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InternalMarks).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.InternalMarksFormatted)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Languagetype).HasColumnName("languagetype");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            entity.Property(e => e.Subresult)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("P")
                .HasColumnName("subresult");
            entity.Property(e => e.Total).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTTenantuserProfile>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("WDI_T_TENANTUserProfile");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PermanentCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentState)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresentAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PresentCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PresentState)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProfileImagePath)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RegisteredDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VerificationCode).HasMaxLength(50);
        });

        modelBuilder.Entity<WdiTTenantusertemplateaccess>(entity =>
        {
            entity.ToTable("WDI_T_TENANTUSERTEMPLATEACCESS");

            entity.Property(e => e.Channelemailpermitted).HasColumnName("CHANNELEMAILPERMITTED");
            entity.Property(e => e.Channelnotificationpermitted).HasColumnName("CHANNELNOTIFICATIONPERMITTED");
            entity.Property(e => e.Channeltextpermitted).HasColumnName("CHANNELTEXTPERMITTED");
            entity.Property(e => e.Channelvoicepermitted).HasColumnName("CHANNELVOICEPERMITTED");
            entity.Property(e => e.Channelwhatsapppermitted).HasColumnName("CHANNELWHATSAPPPERMITTED");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Templategroup)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TEMPLATEGROUP");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTTermWiseRemark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WDI_T_Te__3214EC07A7FDEC9A");

            entity.ToTable("WDI_T_TermWiseRemarks");

            entity.Property(e => e.CoScholasticT1remarks)
                .HasMaxLength(500)
                .HasColumnName("CoScholasticT1Remarks");
            entity.Property(e => e.CoScholasticT2remarks)
                .HasMaxLength(500)
                .HasColumnName("CoScholasticT2Remarks");
            entity.Property(e => e.ScholasticT1remarks)
                .HasMaxLength(500)
                .HasColumnName("ScholasticT1Remarks");
            entity.Property(e => e.ScholasticT2remarks)
                .HasMaxLength(500)
                .HasColumnName("ScholasticT2Remarks");
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<WdiTTicketlog>(entity =>
        {
            entity.HasKey(e => e.LogIdPk).HasName("PK__WDI_T_Ti__341A13D2583F744A");

            entity.ToTable("WDI_T_Ticketlog");

            entity.Property(e => e.LogIdPk).HasColumnName("LogID_PK");
            entity.Property(e => e.ActionBy).HasMaxLength(100);
            entity.Property(e => e.ActionComments).HasMaxLength(2000);
            entity.Property(e => e.ActionType).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.IdFk).HasColumnName("ID_FK");
            entity.Property(e => e.PartnerIdFk).HasColumnName("PartnerID_FK");

            entity.HasOne(d => d.IdFkNavigation).WithMany(p => p.WdiTTicketlogs)
                .HasForeignKey(d => d.IdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_T_Tic__ID_FK__664C55B7");

            entity.HasOne(d => d.PartnerIdFkNavigation).WithMany(p => p.WdiTTicketlogs)
                .HasForeignKey(d => d.PartnerIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__WDI_T_Tic__Partn__6558317E");
        });

        modelBuilder.Entity<WdiTTimeTableConfig>(entity =>
        {
            entity.HasKey(e => e.TimeTableConfigIdPk).HasName("WDI_T_TimeTableConfig_TimeTableConfigID_PK");

            entity.ToTable("WDI_T_TimeTableConfig");

            entity.Property(e => e.TimeTableConfigIdPk).HasColumnName("TimeTableConfigID_PK");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedById)
                .HasMaxLength(40)
                .HasColumnName("CreatedByID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedById)
                .HasMaxLength(40)
                .HasColumnName("ModifiedByID");
            entity.Property(e => e.MoidifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SeasonIdFk).HasColumnName("SeasonID_FK");

            entity.HasOne(d => d.SeasonIdFkNavigation).WithMany(p => p.WdiTTimeTableConfigs)
                .HasForeignKey(d => d.SeasonIdFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WDI_T_TimeTableConfig_SeasonID_FK");
        });

        modelBuilder.Entity<WdiTToolMapping>(entity =>
        {
            entity.HasKey(e => e.ToolMappingId).HasName("wdi_t_ToolMappings_ToolMappingId");

            entity.ToTable("wdi_t_ToolMappings");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ScheduleId).HasDefaultValue(-1L);
            entity.Property(e => e.SectionId).HasDefaultValue(-1);
            entity.Property(e => e.SubjectId)
                .HasDefaultValue(-1)
                .HasColumnName("SubjectID");
        });

        modelBuilder.Entity<WdiTToolMark>(entity =>
        {
            entity.HasKey(e => e.ToolMarksId).HasName("wdi_t_ToolMarks_ToolMarksId");

            entity.ToTable("wdi_t_ToolMarks");

            entity.Property(e => e.EnteredBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EnteredDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Marks).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTTopStudent>(entity =>
        {
            entity.ToTable("WDI_T_TopStudents");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Class)
                .HasMaxLength(100)
                .HasDefaultValue("class");
            entity.Property(e => e.Examname).HasMaxLength(50);
            entity.Property(e => e.Marks).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PhotoPath).HasMaxLength(200);
            entity.Property(e => e.Rank).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTTransactionLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("WDI_T_TransactionLog");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.LogoutTime).HasColumnType("datetime");
            entity.Property(e => e.SessionId)
                .HasMaxLength(60)
                .HasColumnName("SessionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(40)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTTransportLocationTracking>(entity =>
        {
            entity.ToTable("Wdi_T_TransportLocationTracking");

            entity.HasIndex(e => new { e.VehicleId, e.RouteId }, "INDEX_Transport");

            entity.Property(e => e.CurrentLatitude).HasMaxLength(500);
            entity.Property(e => e.CurrentLongitude).HasMaxLength(500);
            entity.Property(e => e.Lastupdated)
                .HasColumnType("datetime")
                .HasColumnName("lastupdated");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("updatedby");
        });

        modelBuilder.Entity<WdiTTransportdirvermapping>(entity =>
        {
            entity.HasKey(e => new { e.VehicleId, e.UserId });

            entity.ToTable("WDI_T_TRANSPORTDIRVERMAPPING");

            entity.Property(e => e.UserId).HasMaxLength(40);
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DriverMappingId).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTTransportroutetran>(entity =>
        {
            entity.HasKey(e => e.RouteTransId);

            entity.ToTable("WDI_T_TRANSPORTROUTETRANS");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OnewayFee).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TwoWayFee).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<WdiTTransportroutevehicle>(entity =>
        {
            entity.HasKey(e => e.RvehicleId);

            entity.ToTable("WDI_T_TRANSPORTROUTEVEHICLES");

            entity.Property(e => e.RvehicleId).HasColumnName("RVehicleId");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasComment("1 - for Active ; 0 - for In-active");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(40);
            entity.Property(e => e.ModifiedBy).HasMaxLength(40);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<WdiTUserAttendanceLookUp>(entity =>
        {
            entity.HasKey(e => e.UserAttendanceLookUpId);

            entity.ToTable("WDI_T_UserAttendanceLookUp");

            entity.Property(e => e.UserAttendanceLookUpId).HasColumnName("UserAttendanceLookUpID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.AttendanceType).HasMaxLength(50);
            entity.Property(e => e.Attendancedate).HasColumnType("datetime");
            entity.Property(e => e.DutyOff)
                .HasMaxLength(80)
                .HasColumnName("Duty_Off");
            entity.Property(e => e.DutyOn)
                .HasMaxLength(80)
                .HasColumnName("Duty_On");
            entity.Property(e => e.TotalHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTUserCumulativeAttendance>(entity =>
        {
            entity.ToTable("WDI_T_UserCumulativeAttendance");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AbsentDays).HasColumnType("decimal(15, 0)");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NameOfUnit).HasMaxLength(50);
            entity.Property(e => e.Percentage).HasColumnType("decimal(15, 0)");
            entity.Property(e => e.PresentDays).HasColumnType("decimal(15, 0)");
            entity.Property(e => e.TypeOfUnit)
                .HasMaxLength(50)
                .HasDefaultValue("M");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTUserPayRollTransMaster>(entity =>
        {
            entity.ToTable("WDI_T_UserPayRollTransMaster");

            entity.Property(e => e.AcadamicYearId).HasColumnName("AcadamicYearID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GrossSalary).HasColumnType("money");
            entity.Property(e => e.LateDeductionAmt).HasColumnType("money");
            entity.Property(e => e.Lopamount)
                .HasColumnType("money")
                .HasColumnName("LOPAmount");
            entity.Property(e => e.Lopdays)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("LOPDays");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Month).HasMaxLength(50);
            entity.Property(e => e.NetSalary).HasColumnType("money");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WdiTUserQuery>(entity =>
        {
            entity.HasKey(e => e.QueryId).HasName("PK_WDI_T_User");

            entity.ToTable("WDI_T_UserQueries");

            entity.Property(e => e.QueryId).HasColumnName("QueryID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(75)
                .HasColumnName("EmailID");
            entity.Property(e => e.EncryptedEmailId).HasMaxLength(256);
            entity.Property(e => e.EncryptedMobileNo).HasMaxLength(256);
            entity.Property(e => e.ModifiedBy).HasMaxLength(80);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.QueryDetails).HasColumnType("ntext");
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.Type)
                .HasMaxLength(200)
                .HasDefaultValue("REQUEST");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTUserSpecificHoliday>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WDI_T_UserSpecificHolidays");

            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.HolidayDate).HasColumnType("datetime");
            entity.Property(e => e.HolidayTitle).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(100);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RoleHolidayId)
                .HasDefaultValue(-1L)
                .HasColumnName("RoleHolidayID");
            entity.Property(e => e.UserHolidayId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserHolidayID");
            entity.Property(e => e.UserId)
                .HasMaxLength(800)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<WdiTUserdoc>(entity =>
        {
            entity.HasKey(e => e.UserDocId);

            entity.ToTable("WDI_T_USERDOCS");

            entity.Property(e => e.CreatedBy).HasMaxLength(40);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocumentRefNo).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Remarks).HasMaxLength(100);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(40);
        });

        modelBuilder.Entity<WdiTVisitorDetail>(entity =>
        {
            entity.HasKey(e => e.VisitorDetailsId);

            entity.ToTable("WDI_T_VisitorDetails");

            entity.Property(e => e.VisitorDetailsId).HasColumnName("VisitorDetailsID");
            entity.Property(e => e.AcademicYearId).HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassandSection)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FurtherActions).HasMaxLength(1000);
            entity.Property(e => e.OutingValidTill).HasColumnType("datetime");
            entity.Property(e => e.Purpose).HasMaxLength(2000);
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentUserid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VehicleDetails).HasMaxLength(100);
            entity.Property(e => e.VisitPurpose).HasMaxLength(100);
            entity.Property(e => e.VisitedDate).HasColumnType("datetime");
            entity.Property(e => e.VisitorId).HasColumnName("VisitorID");
        });

        modelBuilder.Entity<WdiTXmlpartnerTemplate>(entity =>
        {
            entity.HasKey(e => e.XmltemplateId);

            entity.ToTable("WDI_T_XMLPartnerTemplates");

            entity.Property(e => e.XmltemplateId).HasColumnName("XMLTemplateID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsApproved).HasComment(" 0 - Not Approved, 1 - Approved");
            entity.Property(e => e.PartnerTemplateId).HasColumnName("PartnerTemplateID");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasComment("0 - false(Not Active)  1 - True(Active)");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.XmltemplateName)
                .HasMaxLength(100)
                .HasColumnName("XMLTemplateName");
        });
        modelBuilder.HasSequence("accountdetSeq")
            .HasMin(1L)
            .HasMax(9L)
            .IsCyclic();
        modelBuilder.HasSequence("SEQ_APPLICATION_NUMBER").StartsAt(160000L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
