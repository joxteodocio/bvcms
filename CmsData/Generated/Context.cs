using System; 
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;

namespace CmsData
{
	[DatabaseAttribute(Name="CMS")]
	public partial class CMSDataContext : DataContext
	{
		private static MappingSource mappingSource = new AttributeMappingSource();
		
#region Extensibility Method Definitions
        partial void OnCreated();
		
        partial void InsertActivityLog(ActivityLog instance);
        partial void UpdateActivityLog(ActivityLog instance);
        partial void DeleteActivityLog(ActivityLog instance);
        
        partial void InsertAddress(Address instance);
        partial void UpdateAddress(Address instance);
        partial void DeleteAddress(Address instance);
        
        partial void InsertAddressType(AddressType instance);
        partial void UpdateAddressType(AddressType instance);
        partial void DeleteAddressType(AddressType instance);
        
        partial void InsertAddToOrgFromTagRun(AddToOrgFromTagRun instance);
        partial void UpdateAddToOrgFromTagRun(AddToOrgFromTagRun instance);
        partial void DeleteAddToOrgFromTagRun(AddToOrgFromTagRun instance);
        
        partial void InsertAttend(Attend instance);
        partial void UpdateAttend(Attend instance);
        partial void DeleteAttend(Attend instance);
        
        partial void InsertAttendCredit(AttendCredit instance);
        partial void UpdateAttendCredit(AttendCredit instance);
        partial void DeleteAttendCredit(AttendCredit instance);
        
        partial void InsertAttendType(AttendType instance);
        partial void UpdateAttendType(AttendType instance);
        partial void DeleteAttendType(AttendType instance);
        
        partial void InsertAudit(Audit instance);
        partial void UpdateAudit(Audit instance);
        partial void DeleteAudit(Audit instance);
        
        partial void InsertAuditValue(AuditValue instance);
        partial void UpdateAuditValue(AuditValue instance);
        partial void DeleteAuditValue(AuditValue instance);
        
        partial void InsertBackgroundCheckLabel(BackgroundCheckLabel instance);
        partial void UpdateBackgroundCheckLabel(BackgroundCheckLabel instance);
        partial void DeleteBackgroundCheckLabel(BackgroundCheckLabel instance);
        
        partial void InsertBackgroundCheckMVRCode(BackgroundCheckMVRCode instance);
        partial void UpdateBackgroundCheckMVRCode(BackgroundCheckMVRCode instance);
        partial void DeleteBackgroundCheckMVRCode(BackgroundCheckMVRCode instance);
        
        partial void InsertBackgroundCheck(BackgroundCheck instance);
        partial void UpdateBackgroundCheck(BackgroundCheck instance);
        partial void DeleteBackgroundCheck(BackgroundCheck instance);
        
        partial void InsertBaptismStatus(BaptismStatus instance);
        partial void UpdateBaptismStatus(BaptismStatus instance);
        partial void DeleteBaptismStatus(BaptismStatus instance);
        
        partial void InsertBaptismType(BaptismType instance);
        partial void UpdateBaptismType(BaptismType instance);
        partial void DeleteBaptismType(BaptismType instance);
        
        partial void InsertBuildingAccessType(BuildingAccessType instance);
        partial void UpdateBuildingAccessType(BuildingAccessType instance);
        partial void DeleteBuildingAccessType(BuildingAccessType instance);
        
        partial void InsertBundleDetail(BundleDetail instance);
        partial void UpdateBundleDetail(BundleDetail instance);
        partial void DeleteBundleDetail(BundleDetail instance);
        
        partial void InsertBundleHeader(BundleHeader instance);
        partial void UpdateBundleHeader(BundleHeader instance);
        partial void DeleteBundleHeader(BundleHeader instance);
        
        partial void InsertBundleHeaderType(BundleHeaderType instance);
        partial void UpdateBundleHeaderType(BundleHeaderType instance);
        partial void DeleteBundleHeaderType(BundleHeaderType instance);
        
        partial void InsertBundleStatusType(BundleStatusType instance);
        partial void UpdateBundleStatusType(BundleStatusType instance);
        partial void DeleteBundleStatusType(BundleStatusType instance);
        
        partial void InsertCampu(Campu instance);
        partial void UpdateCampu(Campu instance);
        partial void DeleteCampu(Campu instance);
        
        partial void InsertCardIdentifier(CardIdentifier instance);
        partial void UpdateCardIdentifier(CardIdentifier instance);
        partial void DeleteCardIdentifier(CardIdentifier instance);
        
        partial void InsertChangeDetail(ChangeDetail instance);
        partial void UpdateChangeDetail(ChangeDetail instance);
        partial void DeleteChangeDetail(ChangeDetail instance);
        
        partial void InsertChangeLog(ChangeLog instance);
        partial void UpdateChangeLog(ChangeLog instance);
        partial void DeleteChangeLog(ChangeLog instance);
        
        partial void InsertCheckedBatch(CheckedBatch instance);
        partial void UpdateCheckedBatch(CheckedBatch instance);
        partial void DeleteCheckedBatch(CheckedBatch instance);
        
        partial void InsertCheckInActivity(CheckInActivity instance);
        partial void UpdateCheckInActivity(CheckInActivity instance);
        partial void DeleteCheckInActivity(CheckInActivity instance);
        
        partial void InsertCheckInTime(CheckInTime instance);
        partial void UpdateCheckInTime(CheckInTime instance);
        partial void DeleteCheckInTime(CheckInTime instance);
        
        partial void InsertChurchAttReportId(ChurchAttReportId instance);
        partial void UpdateChurchAttReportId(ChurchAttReportId instance);
        partial void DeleteChurchAttReportId(ChurchAttReportId instance);
        
        partial void InsertContact(Contact instance);
        partial void UpdateContact(Contact instance);
        partial void DeleteContact(Contact instance);
        
        partial void InsertContactee(Contactee instance);
        partial void UpdateContactee(Contactee instance);
        partial void DeleteContactee(Contactee instance);
        
        partial void InsertContactor(Contactor instance);
        partial void UpdateContactor(Contactor instance);
        partial void DeleteContactor(Contactor instance);
        
        partial void InsertContactPreference(ContactPreference instance);
        partial void UpdateContactPreference(ContactPreference instance);
        partial void DeleteContactPreference(ContactPreference instance);
        
        partial void InsertContactReason(ContactReason instance);
        partial void UpdateContactReason(ContactReason instance);
        partial void DeleteContactReason(ContactReason instance);
        
        partial void InsertContactType(ContactType instance);
        partial void UpdateContactType(ContactType instance);
        partial void DeleteContactType(ContactType instance);
        
        partial void InsertContent(Content instance);
        partial void UpdateContent(Content instance);
        partial void DeleteContent(Content instance);
        
        partial void InsertContentKeyWord(ContentKeyWord instance);
        partial void UpdateContentKeyWord(ContentKeyWord instance);
        partial void DeleteContentKeyWord(ContentKeyWord instance);
        
        partial void InsertContribution(Contribution instance);
        partial void UpdateContribution(Contribution instance);
        partial void DeleteContribution(Contribution instance);
        
        partial void InsertContributionFund(ContributionFund instance);
        partial void UpdateContributionFund(ContributionFund instance);
        partial void DeleteContributionFund(ContributionFund instance);
        
        partial void InsertContributionsRun(ContributionsRun instance);
        partial void UpdateContributionsRun(ContributionsRun instance);
        partial void DeleteContributionsRun(ContributionsRun instance);
        
        partial void InsertContributionStatus(ContributionStatus instance);
        partial void UpdateContributionStatus(ContributionStatus instance);
        partial void DeleteContributionStatus(ContributionStatus instance);
        
        partial void InsertContributionType(ContributionType instance);
        partial void UpdateContributionType(ContributionType instance);
        partial void DeleteContributionType(ContributionType instance);
        
        partial void InsertCountry(Country instance);
        partial void UpdateCountry(Country instance);
        partial void DeleteCountry(Country instance);
        
        partial void InsertCoupon(Coupon instance);
        partial void UpdateCoupon(Coupon instance);
        partial void DeleteCoupon(Coupon instance);
        
        partial void InsertDecisionType(DecisionType instance);
        partial void UpdateDecisionType(DecisionType instance);
        partial void DeleteDecisionType(DecisionType instance);
        
        partial void InsertDeleteMeetingRun(DeleteMeetingRun instance);
        partial void UpdateDeleteMeetingRun(DeleteMeetingRun instance);
        partial void DeleteDeleteMeetingRun(DeleteMeetingRun instance);
        
        partial void InsertDivision(Division instance);
        partial void UpdateDivision(Division instance);
        partial void DeleteDivision(Division instance);
        
        partial void InsertDivOrg(DivOrg instance);
        partial void UpdateDivOrg(DivOrg instance);
        partial void DeleteDivOrg(DivOrg instance);
        
        partial void InsertDropType(DropType instance);
        partial void UpdateDropType(DropType instance);
        partial void DeleteDropType(DropType instance);
        
        partial void InsertDuplicate(Duplicate instance);
        partial void UpdateDuplicate(Duplicate instance);
        partial void DeleteDuplicate(Duplicate instance);
        
        partial void InsertDuplicatesRun(DuplicatesRun instance);
        partial void UpdateDuplicatesRun(DuplicatesRun instance);
        partial void DeleteDuplicatesRun(DuplicatesRun instance);
        
        partial void InsertEmailLink(EmailLink instance);
        partial void UpdateEmailLink(EmailLink instance);
        partial void DeleteEmailLink(EmailLink instance);
        
        partial void InsertEmailLog(EmailLog instance);
        partial void UpdateEmailLog(EmailLog instance);
        partial void DeleteEmailLog(EmailLog instance);
        
        partial void InsertEmailOptOut(EmailOptOut instance);
        partial void UpdateEmailOptOut(EmailOptOut instance);
        partial void DeleteEmailOptOut(EmailOptOut instance);
        
        partial void InsertEmailQueue(EmailQueue instance);
        partial void UpdateEmailQueue(EmailQueue instance);
        partial void DeleteEmailQueue(EmailQueue instance);
        
        partial void InsertEmailQueueTo(EmailQueueTo instance);
        partial void UpdateEmailQueueTo(EmailQueueTo instance);
        partial void DeleteEmailQueueTo(EmailQueueTo instance);
        
        partial void InsertEmailQueueToFail(EmailQueueToFail instance);
        partial void UpdateEmailQueueToFail(EmailQueueToFail instance);
        partial void DeleteEmailQueueToFail(EmailQueueToFail instance);
        
        partial void InsertEmailResponse(EmailResponse instance);
        partial void UpdateEmailResponse(EmailResponse instance);
        partial void DeleteEmailResponse(EmailResponse instance);
        
        partial void InsertEmailToText(EmailToText instance);
        partial void UpdateEmailToText(EmailToText instance);
        partial void DeleteEmailToText(EmailToText instance);
        
        partial void InsertEnrollmentTransaction(EnrollmentTransaction instance);
        partial void UpdateEnrollmentTransaction(EnrollmentTransaction instance);
        partial void DeleteEnrollmentTransaction(EnrollmentTransaction instance);
        
        partial void InsertEntryPoint(EntryPoint instance);
        partial void UpdateEntryPoint(EntryPoint instance);
        partial void DeleteEntryPoint(EntryPoint instance);
        
        partial void InsertEnvelopeOption(EnvelopeOption instance);
        partial void UpdateEnvelopeOption(EnvelopeOption instance);
        partial void DeleteEnvelopeOption(EnvelopeOption instance);
        
        partial void InsertExtraDatum(ExtraDatum instance);
        partial void UpdateExtraDatum(ExtraDatum instance);
        partial void DeleteExtraDatum(ExtraDatum instance);
        
        partial void InsertFamily(Family instance);
        partial void UpdateFamily(Family instance);
        partial void DeleteFamily(Family instance);
        
        partial void InsertFamilyCheckinLock(FamilyCheckinLock instance);
        partial void UpdateFamilyCheckinLock(FamilyCheckinLock instance);
        partial void DeleteFamilyCheckinLock(FamilyCheckinLock instance);
        
        partial void InsertFamilyExtra(FamilyExtra instance);
        partial void UpdateFamilyExtra(FamilyExtra instance);
        partial void DeleteFamilyExtra(FamilyExtra instance);
        
        partial void InsertFamilyMemberType(FamilyMemberType instance);
        partial void UpdateFamilyMemberType(FamilyMemberType instance);
        partial void DeleteFamilyMemberType(FamilyMemberType instance);
        
        partial void InsertFamilyPosition(FamilyPosition instance);
        partial void UpdateFamilyPosition(FamilyPosition instance);
        partial void DeleteFamilyPosition(FamilyPosition instance);
        
        partial void InsertFamilyRelationship(FamilyRelationship instance);
        partial void UpdateFamilyRelationship(FamilyRelationship instance);
        partial void DeleteFamilyRelationship(FamilyRelationship instance);
        
        partial void InsertGender(Gender instance);
        partial void UpdateGender(Gender instance);
        partial void DeleteGender(Gender instance);
        
        partial void InsertGeoCode(GeoCode instance);
        partial void UpdateGeoCode(GeoCode instance);
        partial void DeleteGeoCode(GeoCode instance);
        
        partial void InsertGoerSenderAmount(GoerSenderAmount instance);
        partial void UpdateGoerSenderAmount(GoerSenderAmount instance);
        partial void DeleteGoerSenderAmount(GoerSenderAmount instance);
        
        partial void InsertGoerSupporter(GoerSupporter instance);
        partial void UpdateGoerSupporter(GoerSupporter instance);
        partial void DeleteGoerSupporter(GoerSupporter instance);
        
        partial void InsertInterestPoint(InterestPoint instance);
        partial void UpdateInterestPoint(InterestPoint instance);
        partial void DeleteInterestPoint(InterestPoint instance);
        
        partial void InsertJoinType(JoinType instance);
        partial void UpdateJoinType(JoinType instance);
        partial void DeleteJoinType(JoinType instance);
        
        partial void InsertLabelFormat(LabelFormat instance);
        partial void UpdateLabelFormat(LabelFormat instance);
        partial void DeleteLabelFormat(LabelFormat instance);
        
        partial void InsertManagedGiving(ManagedGiving instance);
        partial void UpdateManagedGiving(ManagedGiving instance);
        partial void DeleteManagedGiving(ManagedGiving instance);
        
        partial void InsertMaritalStatus(MaritalStatus instance);
        partial void UpdateMaritalStatus(MaritalStatus instance);
        partial void DeleteMaritalStatus(MaritalStatus instance);
        
        partial void InsertMeetingExtra(MeetingExtra instance);
        partial void UpdateMeetingExtra(MeetingExtra instance);
        partial void DeleteMeetingExtra(MeetingExtra instance);
        
        partial void InsertMeeting(Meeting instance);
        partial void UpdateMeeting(Meeting instance);
        partial void DeleteMeeting(Meeting instance);
        
        partial void InsertMeetingType(MeetingType instance);
        partial void UpdateMeetingType(MeetingType instance);
        partial void DeleteMeetingType(MeetingType instance);
        
        partial void InsertMemberDocForm(MemberDocForm instance);
        partial void UpdateMemberDocForm(MemberDocForm instance);
        partial void DeleteMemberDocForm(MemberDocForm instance);
        
        partial void InsertMemberLetterStatus(MemberLetterStatus instance);
        partial void UpdateMemberLetterStatus(MemberLetterStatus instance);
        partial void DeleteMemberLetterStatus(MemberLetterStatus instance);
        
        partial void InsertMemberStatus(MemberStatus instance);
        partial void UpdateMemberStatus(MemberStatus instance);
        partial void DeleteMemberStatus(MemberStatus instance);
        
        partial void InsertMemberTag(MemberTag instance);
        partial void UpdateMemberTag(MemberTag instance);
        partial void DeleteMemberTag(MemberTag instance);
        
        partial void InsertMemberType(MemberType instance);
        partial void UpdateMemberType(MemberType instance);
        partial void DeleteMemberType(MemberType instance);
        
        partial void InsertMinistry(Ministry instance);
        partial void UpdateMinistry(Ministry instance);
        partial void DeleteMinistry(Ministry instance);
        
        partial void InsertNameTitle(NameTitle instance);
        partial void UpdateNameTitle(NameTitle instance);
        partial void DeleteNameTitle(NameTitle instance);
        
        partial void InsertNewMemberClassStatus(NewMemberClassStatus instance);
        partial void UpdateNewMemberClassStatus(NewMemberClassStatus instance);
        partial void DeleteNewMemberClassStatus(NewMemberClassStatus instance);
        
        partial void InsertNumber(Number instance);
        partial void UpdateNumber(Number instance);
        partial void DeleteNumber(Number instance);
        
        partial void InsertOneTimeLink(OneTimeLink instance);
        partial void UpdateOneTimeLink(OneTimeLink instance);
        partial void DeleteOneTimeLink(OneTimeLink instance);
        
        partial void InsertOrganizationExtra(OrganizationExtra instance);
        partial void UpdateOrganizationExtra(OrganizationExtra instance);
        partial void DeleteOrganizationExtra(OrganizationExtra instance);
        
        partial void InsertOrganizationMember(OrganizationMember instance);
        partial void UpdateOrganizationMember(OrganizationMember instance);
        partial void DeleteOrganizationMember(OrganizationMember instance);
        
        partial void InsertOrganization(Organization instance);
        partial void UpdateOrganization(Organization instance);
        partial void DeleteOrganization(Organization instance);
        
        partial void InsertOrganizationStatus(OrganizationStatus instance);
        partial void UpdateOrganizationStatus(OrganizationStatus instance);
        partial void DeleteOrganizationStatus(OrganizationStatus instance);
        
        partial void InsertOrganizationType(OrganizationType instance);
        partial void UpdateOrganizationType(OrganizationType instance);
        partial void DeleteOrganizationType(OrganizationType instance);
        
        partial void InsertOrgContent(OrgContent instance);
        partial void UpdateOrgContent(OrgContent instance);
        partial void DeleteOrgContent(OrgContent instance);
        
        partial void InsertOrgMemMemTag(OrgMemMemTag instance);
        partial void UpdateOrgMemMemTag(OrgMemMemTag instance);
        partial void DeleteOrgMemMemTag(OrgMemMemTag instance);
        
        partial void InsertOrgSchedule(OrgSchedule instance);
        partial void UpdateOrgSchedule(OrgSchedule instance);
        partial void DeleteOrgSchedule(OrgSchedule instance);
        
        partial void InsertOrigin(Origin instance);
        partial void UpdateOrigin(Origin instance);
        partial void DeleteOrigin(Origin instance);
        
        partial void InsertPaymentInfo(PaymentInfo instance);
        partial void UpdatePaymentInfo(PaymentInfo instance);
        partial void DeletePaymentInfo(PaymentInfo instance);
        
        partial void InsertPerson(Person instance);
        partial void UpdatePerson(Person instance);
        partial void DeletePerson(Person instance);
        
        partial void InsertPeopleCanEmailFor(PeopleCanEmailFor instance);
        partial void UpdatePeopleCanEmailFor(PeopleCanEmailFor instance);
        partial void DeletePeopleCanEmailFor(PeopleCanEmailFor instance);
        
        partial void InsertPeopleExtra(PeopleExtra instance);
        partial void UpdatePeopleExtra(PeopleExtra instance);
        partial void DeletePeopleExtra(PeopleExtra instance);
        
        partial void InsertPicture(Picture instance);
        partial void UpdatePicture(Picture instance);
        partial void DeletePicture(Picture instance);
        
        partial void InsertPostalLookup(PostalLookup instance);
        partial void UpdatePostalLookup(PostalLookup instance);
        partial void DeletePostalLookup(PostalLookup instance);
        
        partial void InsertPreference(Preference instance);
        partial void UpdatePreference(Preference instance);
        partial void DeletePreference(Preference instance);
        
        partial void InsertPrintJob(PrintJob instance);
        partial void UpdatePrintJob(PrintJob instance);
        partial void DeletePrintJob(PrintJob instance);
        
        partial void InsertProgDiv(ProgDiv instance);
        partial void UpdateProgDiv(ProgDiv instance);
        partial void DeleteProgDiv(ProgDiv instance);
        
        partial void InsertProgram(Program instance);
        partial void UpdateProgram(Program instance);
        partial void DeleteProgram(Program instance);
        
        partial void InsertPromotion(Promotion instance);
        partial void UpdatePromotion(Promotion instance);
        partial void DeletePromotion(Promotion instance);
        
        partial void InsertQBConnection(QBConnection instance);
        partial void UpdateQBConnection(QBConnection instance);
        partial void DeleteQBConnection(QBConnection instance);
        
        partial void InsertQuery(Query instance);
        partial void UpdateQuery(Query instance);
        partial void DeleteQuery(Query instance);
        
        partial void InsertQueryStat(QueryStat instance);
        partial void UpdateQueryStat(QueryStat instance);
        partial void DeleteQueryStat(QueryStat instance);
        
        partial void InsertRecReg(RecReg instance);
        partial void UpdateRecReg(RecReg instance);
        partial void DeleteRecReg(RecReg instance);
        
        partial void InsertRecurringAmount(RecurringAmount instance);
        partial void UpdateRecurringAmount(RecurringAmount instance);
        partial void DeleteRecurringAmount(RecurringAmount instance);
        
        partial void InsertRelatedFamily(RelatedFamily instance);
        partial void UpdateRelatedFamily(RelatedFamily instance);
        partial void DeleteRelatedFamily(RelatedFamily instance);
        
        partial void InsertRepairTransactionsRun(RepairTransactionsRun instance);
        partial void UpdateRepairTransactionsRun(RepairTransactionsRun instance);
        partial void DeleteRepairTransactionsRun(RepairTransactionsRun instance);
        
        partial void InsertResidentCode(ResidentCode instance);
        partial void UpdateResidentCode(ResidentCode instance);
        partial void DeleteResidentCode(ResidentCode instance);
        
        partial void InsertRole(Role instance);
        partial void UpdateRole(Role instance);
        partial void DeleteRole(Role instance);
        
        partial void InsertRssFeed(RssFeed instance);
        partial void UpdateRssFeed(RssFeed instance);
        partial void DeleteRssFeed(RssFeed instance);
        
        partial void InsertSecurityCode(SecurityCode instance);
        partial void UpdateSecurityCode(SecurityCode instance);
        partial void DeleteSecurityCode(SecurityCode instance);
        
        partial void InsertSetting(Setting instance);
        partial void UpdateSetting(Setting instance);
        partial void DeleteSetting(Setting instance);
        
        partial void InsertShirtSize(ShirtSize instance);
        partial void UpdateShirtSize(ShirtSize instance);
        partial void DeleteShirtSize(ShirtSize instance);
        
        partial void InsertSMSGroupMember(SMSGroupMember instance);
        partial void UpdateSMSGroupMember(SMSGroupMember instance);
        partial void DeleteSMSGroupMember(SMSGroupMember instance);
        
        partial void InsertSMSGroup(SMSGroup instance);
        partial void UpdateSMSGroup(SMSGroup instance);
        partial void DeleteSMSGroup(SMSGroup instance);
        
        partial void InsertSMSItem(SMSItem instance);
        partial void UpdateSMSItem(SMSItem instance);
        partial void DeleteSMSItem(SMSItem instance);
        
        partial void InsertSMSList(SMSList instance);
        partial void UpdateSMSList(SMSList instance);
        partial void DeleteSMSList(SMSList instance);
        
        partial void InsertSMSNumber(SMSNumber instance);
        partial void UpdateSMSNumber(SMSNumber instance);
        partial void DeleteSMSNumber(SMSNumber instance);
        
        partial void InsertStateLookup(StateLookup instance);
        partial void UpdateStateLookup(StateLookup instance);
        partial void DeleteStateLookup(StateLookup instance);
        
        partial void InsertStreetType(StreetType instance);
        partial void UpdateStreetType(StreetType instance);
        partial void DeleteStreetType(StreetType instance);
        
        partial void InsertSubRequest(SubRequest instance);
        partial void UpdateSubRequest(SubRequest instance);
        partial void DeleteSubRequest(SubRequest instance);
        
        partial void InsertTag(Tag instance);
        partial void UpdateTag(Tag instance);
        partial void DeleteTag(Tag instance);
        
        partial void InsertTagPerson(TagPerson instance);
        partial void UpdateTagPerson(TagPerson instance);
        partial void DeleteTagPerson(TagPerson instance);
        
        partial void InsertTagShare(TagShare instance);
        partial void UpdateTagShare(TagShare instance);
        partial void DeleteTagShare(TagShare instance);
        
        partial void InsertTagType(TagType instance);
        partial void UpdateTagType(TagType instance);
        partial void DeleteTagType(TagType instance);
        
        partial void InsertTask(Task instance);
        partial void UpdateTask(Task instance);
        partial void DeleteTask(Task instance);
        
        partial void InsertTaskList(TaskList instance);
        partial void UpdateTaskList(TaskList instance);
        partial void DeleteTaskList(TaskList instance);
        
        partial void InsertTaskListOwner(TaskListOwner instance);
        partial void UpdateTaskListOwner(TaskListOwner instance);
        partial void DeleteTaskListOwner(TaskListOwner instance);
        
        partial void InsertTaskStatus(TaskStatus instance);
        partial void UpdateTaskStatus(TaskStatus instance);
        partial void DeleteTaskStatus(TaskStatus instance);
        
        partial void InsertTransaction(Transaction instance);
        partial void UpdateTransaction(Transaction instance);
        partial void DeleteTransaction(Transaction instance);
        
        partial void InsertTransactionPerson(TransactionPerson instance);
        partial void UpdateTransactionPerson(TransactionPerson instance);
        partial void DeleteTransactionPerson(TransactionPerson instance);
        
        partial void InsertUploadPeopleRun(UploadPeopleRun instance);
        partial void UpdateUploadPeopleRun(UploadPeopleRun instance);
        partial void DeleteUploadPeopleRun(UploadPeopleRun instance);
        
        partial void InsertUserRole(UserRole instance);
        partial void UpdateUserRole(UserRole instance);
        partial void DeleteUserRole(UserRole instance);
        
        partial void InsertUser(User instance);
        partial void UpdateUser(User instance);
        partial void DeleteUser(User instance);
        
        partial void InsertVolApplicationStatus(VolApplicationStatus instance);
        partial void UpdateVolApplicationStatus(VolApplicationStatus instance);
        partial void DeleteVolApplicationStatus(VolApplicationStatus instance);
        
        partial void InsertVolInterestCode(VolInterestCode instance);
        partial void UpdateVolInterestCode(VolInterestCode instance);
        partial void DeleteVolInterestCode(VolInterestCode instance);
        
        partial void InsertVolInterestInterestCode(VolInterestInterestCode instance);
        partial void UpdateVolInterestInterestCode(VolInterestInterestCode instance);
        partial void DeleteVolInterestInterestCode(VolInterestInterestCode instance);
        
        partial void InsertVolRequest(VolRequest instance);
        partial void UpdateVolRequest(VolRequest instance);
        partial void DeleteVolRequest(VolRequest instance);
        
        partial void InsertVolunteer(Volunteer instance);
        partial void UpdateVolunteer(Volunteer instance);
        partial void DeleteVolunteer(Volunteer instance);
        
        partial void InsertVolunteerCode(VolunteerCode instance);
        partial void UpdateVolunteerCode(VolunteerCode instance);
        partial void DeleteVolunteerCode(VolunteerCode instance);
        
        partial void InsertVolunteerForm(VolunteerForm instance);
        partial void UpdateVolunteerForm(VolunteerForm instance);
        partial void DeleteVolunteerForm(VolunteerForm instance);
        
        partial void InsertVoluteerApprovalId(VoluteerApprovalId instance);
        partial void UpdateVoluteerApprovalId(VoluteerApprovalId instance);
        partial void DeleteVoluteerApprovalId(VoluteerApprovalId instance);
        
        partial void InsertWord(Word instance);
        partial void UpdateWord(Word instance);
        partial void DeleteWord(Word instance);
        
        partial void InsertZipCode(ZipCode instance);
        partial void UpdateZipCode(ZipCode instance);
        partial void DeleteZipCode(ZipCode instance);
        
        partial void InsertZip(Zip instance);
        partial void UpdateZip(Zip instance);
        partial void DeleteZip(Zip instance);
        
#endregion
		
		public CMSDataContext() : 
				base(System.Configuration.ConfigurationManager.ConnectionStrings["CMS"].ConnectionString, mappingSource)
		{
			OnCreated();
		}

		
		public CMSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

		
		public CMSDataContext(IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

		
		public CMSDataContext(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

		
		public CMSDataContext(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

    #region Tables
		
		public Table< ActivityLog> ActivityLogs
		{
			get	{ return this.GetTable< ActivityLog>(); }

		}

		public Table< Address> Addresses
		{
			get	{ return this.GetTable< Address>(); }

		}

		public Table< AddressType> AddressTypes
		{
			get	{ return this.GetTable< AddressType>(); }

		}

		public Table< AddToOrgFromTagRun> AddToOrgFromTagRuns
		{
			get	{ return this.GetTable< AddToOrgFromTagRun>(); }

		}

		public Table< Attend> Attends
		{
			get	{ return this.GetTable< Attend>(); }

		}

		public Table< AttendCredit> AttendCredits
		{
			get	{ return this.GetTable< AttendCredit>(); }

		}

		public Table< AttendType> AttendTypes
		{
			get	{ return this.GetTable< AttendType>(); }

		}

		public Table< Audit> Audits
		{
			get	{ return this.GetTable< Audit>(); }

		}

		public Table< AuditValue> AuditValues
		{
			get	{ return this.GetTable< AuditValue>(); }

		}

		public Table< BackgroundCheckLabel> BackgroundCheckLabels
		{
			get	{ return this.GetTable< BackgroundCheckLabel>(); }

		}

		public Table< BackgroundCheckMVRCode> BackgroundCheckMVRCodes
		{
			get	{ return this.GetTable< BackgroundCheckMVRCode>(); }

		}

		public Table< BackgroundCheck> BackgroundChecks
		{
			get	{ return this.GetTable< BackgroundCheck>(); }

		}

		public Table< BaptismStatus> BaptismStatuses
		{
			get	{ return this.GetTable< BaptismStatus>(); }

		}

		public Table< BaptismType> BaptismTypes
		{
			get	{ return this.GetTable< BaptismType>(); }

		}

		public Table< BuildingAccessType> BuildingAccessTypes
		{
			get	{ return this.GetTable< BuildingAccessType>(); }

		}

		public Table< BundleDetail> BundleDetails
		{
			get	{ return this.GetTable< BundleDetail>(); }

		}

		public Table< BundleHeader> BundleHeaders
		{
			get	{ return this.GetTable< BundleHeader>(); }

		}

		public Table< BundleHeaderType> BundleHeaderTypes
		{
			get	{ return this.GetTable< BundleHeaderType>(); }

		}

		public Table< BundleStatusType> BundleStatusTypes
		{
			get	{ return this.GetTable< BundleStatusType>(); }

		}

		public Table< Campu> Campus
		{
			get	{ return this.GetTable< Campu>(); }

		}

		public Table< CardIdentifier> CardIdentifiers
		{
			get	{ return this.GetTable< CardIdentifier>(); }

		}

		public Table< ChangeDetail> ChangeDetails
		{
			get	{ return this.GetTable< ChangeDetail>(); }

		}

		public Table< ChangeLog> ChangeLogs
		{
			get	{ return this.GetTable< ChangeLog>(); }

		}

		public Table< CheckedBatch> CheckedBatches
		{
			get	{ return this.GetTable< CheckedBatch>(); }

		}

		public Table< CheckInActivity> CheckInActivities
		{
			get	{ return this.GetTable< CheckInActivity>(); }

		}

		public Table< CheckInTime> CheckInTimes
		{
			get	{ return this.GetTable< CheckInTime>(); }

		}

		public Table< ChurchAttReportId> ChurchAttReportIds
		{
			get	{ return this.GetTable< ChurchAttReportId>(); }

		}

		public Table< Contact> Contacts
		{
			get	{ return this.GetTable< Contact>(); }

		}

		public Table< Contactee> Contactees
		{
			get	{ return this.GetTable< Contactee>(); }

		}

		public Table< Contactor> Contactors
		{
			get	{ return this.GetTable< Contactor>(); }

		}

		public Table< ContactPreference> ContactPreferences
		{
			get	{ return this.GetTable< ContactPreference>(); }

		}

		public Table< ContactReason> ContactReasons
		{
			get	{ return this.GetTable< ContactReason>(); }

		}

		public Table< ContactType> ContactTypes
		{
			get	{ return this.GetTable< ContactType>(); }

		}

		public Table< Content> Contents
		{
			get	{ return this.GetTable< Content>(); }

		}

		public Table< ContentKeyWord> ContentKeyWords
		{
			get	{ return this.GetTable< ContentKeyWord>(); }

		}

		public Table< Contribution> Contributions
		{
			get	{ return this.GetTable< Contribution>(); }

		}

		public Table< ContributionFund> ContributionFunds
		{
			get	{ return this.GetTable< ContributionFund>(); }

		}

		public Table< ContributionsRun> ContributionsRuns
		{
			get	{ return this.GetTable< ContributionsRun>(); }

		}

		public Table< ContributionStatus> ContributionStatuses
		{
			get	{ return this.GetTable< ContributionStatus>(); }

		}

		public Table< ContributionType> ContributionTypes
		{
			get	{ return this.GetTable< ContributionType>(); }

		}

		public Table< Country> Countries
		{
			get	{ return this.GetTable< Country>(); }

		}

		public Table< Coupon> Coupons
		{
			get	{ return this.GetTable< Coupon>(); }

		}

		public Table< DecisionType> DecisionTypes
		{
			get	{ return this.GetTable< DecisionType>(); }

		}

		public Table< DeleteMeetingRun> DeleteMeetingRuns
		{
			get	{ return this.GetTable< DeleteMeetingRun>(); }

		}

		public Table< Division> Divisions
		{
			get	{ return this.GetTable< Division>(); }

		}

		public Table< DivOrg> DivOrgs
		{
			get	{ return this.GetTable< DivOrg>(); }

		}

		public Table< DropType> DropTypes
		{
			get	{ return this.GetTable< DropType>(); }

		}

		public Table< Duplicate> Duplicates
		{
			get	{ return this.GetTable< Duplicate>(); }

		}

		public Table< DuplicatesRun> DuplicatesRuns
		{
			get	{ return this.GetTable< DuplicatesRun>(); }

		}

		public Table< EmailLink> EmailLinks
		{
			get	{ return this.GetTable< EmailLink>(); }

		}

		public Table< EmailLog> EmailLogs
		{
			get	{ return this.GetTable< EmailLog>(); }

		}

		public Table< EmailOptOut> EmailOptOuts
		{
			get	{ return this.GetTable< EmailOptOut>(); }

		}

		public Table< EmailQueue> EmailQueues
		{
			get	{ return this.GetTable< EmailQueue>(); }

		}

		public Table< EmailQueueTo> EmailQueueTos
		{
			get	{ return this.GetTable< EmailQueueTo>(); }

		}

		public Table< EmailQueueToFail> EmailQueueToFails
		{
			get	{ return this.GetTable< EmailQueueToFail>(); }

		}

		public Table< EmailResponse> EmailResponses
		{
			get	{ return this.GetTable< EmailResponse>(); }

		}

		public Table< EmailToText> EmailToTexts
		{
			get	{ return this.GetTable< EmailToText>(); }

		}

		public Table< EnrollmentTransaction> EnrollmentTransactions
		{
			get	{ return this.GetTable< EnrollmentTransaction>(); }

		}

		public Table< EntryPoint> EntryPoints
		{
			get	{ return this.GetTable< EntryPoint>(); }

		}

		public Table< EnvelopeOption> EnvelopeOptions
		{
			get	{ return this.GetTable< EnvelopeOption>(); }

		}

		public Table< ExtraDatum> ExtraDatas
		{
			get	{ return this.GetTable< ExtraDatum>(); }

		}

		public Table< Family> Families
		{
			get	{ return this.GetTable< Family>(); }

		}

		public Table< FamilyCheckinLock> FamilyCheckinLocks
		{
			get	{ return this.GetTable< FamilyCheckinLock>(); }

		}

		public Table< FamilyExtra> FamilyExtras
		{
			get	{ return this.GetTable< FamilyExtra>(); }

		}

		public Table< FamilyMemberType> FamilyMemberTypes
		{
			get	{ return this.GetTable< FamilyMemberType>(); }

		}

		public Table< FamilyPosition> FamilyPositions
		{
			get	{ return this.GetTable< FamilyPosition>(); }

		}

		public Table< FamilyRelationship> FamilyRelationships
		{
			get	{ return this.GetTable< FamilyRelationship>(); }

		}

		public Table< Gender> Genders
		{
			get	{ return this.GetTable< Gender>(); }

		}

		public Table< GeoCode> GeoCodes
		{
			get	{ return this.GetTable< GeoCode>(); }

		}

		public Table< GoerSenderAmount> GoerSenderAmounts
		{
			get	{ return this.GetTable< GoerSenderAmount>(); }

		}

		public Table< GoerSupporter> GoerSupporters
		{
			get	{ return this.GetTable< GoerSupporter>(); }

		}

		public Table< InterestPoint> InterestPoints
		{
			get	{ return this.GetTable< InterestPoint>(); }

		}

		public Table< JoinType> JoinTypes
		{
			get	{ return this.GetTable< JoinType>(); }

		}

		public Table< LabelFormat> LabelFormats
		{
			get	{ return this.GetTable< LabelFormat>(); }

		}

		public Table< ManagedGiving> ManagedGivings
		{
			get	{ return this.GetTable< ManagedGiving>(); }

		}

		public Table< MaritalStatus> MaritalStatuses
		{
			get	{ return this.GetTable< MaritalStatus>(); }

		}

		public Table< MeetingExtra> MeetingExtras
		{
			get	{ return this.GetTable< MeetingExtra>(); }

		}

		public Table< Meeting> Meetings
		{
			get	{ return this.GetTable< Meeting>(); }

		}

		public Table< MeetingType> MeetingTypes
		{
			get	{ return this.GetTable< MeetingType>(); }

		}

		public Table< MemberDocForm> MemberDocForms
		{
			get	{ return this.GetTable< MemberDocForm>(); }

		}

		public Table< MemberLetterStatus> MemberLetterStatuses
		{
			get	{ return this.GetTable< MemberLetterStatus>(); }

		}

		public Table< MemberStatus> MemberStatuses
		{
			get	{ return this.GetTable< MemberStatus>(); }

		}

		public Table< MemberTag> MemberTags
		{
			get	{ return this.GetTable< MemberTag>(); }

		}

		public Table< MemberType> MemberTypes
		{
			get	{ return this.GetTable< MemberType>(); }

		}

		public Table< Ministry> Ministries
		{
			get	{ return this.GetTable< Ministry>(); }

		}

		public Table< NameTitle> NameTitles
		{
			get	{ return this.GetTable< NameTitle>(); }

		}

		public Table< NewMemberClassStatus> NewMemberClassStatuses
		{
			get	{ return this.GetTable< NewMemberClassStatus>(); }

		}

		public Table< Number> Numbers
		{
			get	{ return this.GetTable< Number>(); }

		}

		public Table< OneTimeLink> OneTimeLinks
		{
			get	{ return this.GetTable< OneTimeLink>(); }

		}

		public Table< OrganizationExtra> OrganizationExtras
		{
			get	{ return this.GetTable< OrganizationExtra>(); }

		}

		public Table< OrganizationMember> OrganizationMembers
		{
			get	{ return this.GetTable< OrganizationMember>(); }

		}

		public Table< Organization> Organizations
		{
			get	{ return this.GetTable< Organization>(); }

		}

		public Table< OrganizationStatus> OrganizationStatuses
		{
			get	{ return this.GetTable< OrganizationStatus>(); }

		}

		public Table< OrganizationType> OrganizationTypes
		{
			get	{ return this.GetTable< OrganizationType>(); }

		}

		public Table< OrgContent> OrgContents
		{
			get	{ return this.GetTable< OrgContent>(); }

		}

		public Table< OrgMemMemTag> OrgMemMemTags
		{
			get	{ return this.GetTable< OrgMemMemTag>(); }

		}

		public Table< OrgSchedule> OrgSchedules
		{
			get	{ return this.GetTable< OrgSchedule>(); }

		}

		public Table< Origin> Origins
		{
			get	{ return this.GetTable< Origin>(); }

		}

		public Table< PaymentInfo> PaymentInfos
		{
			get	{ return this.GetTable< PaymentInfo>(); }

		}

		public Table< Person> People
		{
			get	{ return this.GetTable< Person>(); }

		}

		public Table< PeopleCanEmailFor> PeopleCanEmailFors
		{
			get	{ return this.GetTable< PeopleCanEmailFor>(); }

		}

		public Table< PeopleExtra> PeopleExtras
		{
			get	{ return this.GetTable< PeopleExtra>(); }

		}

		public Table< Picture> Pictures
		{
			get	{ return this.GetTable< Picture>(); }

		}

		public Table< PostalLookup> PostalLookups
		{
			get	{ return this.GetTable< PostalLookup>(); }

		}

		public Table< Preference> Preferences
		{
			get	{ return this.GetTable< Preference>(); }

		}

		public Table< PrintJob> PrintJobs
		{
			get	{ return this.GetTable< PrintJob>(); }

		}

		public Table< ProgDiv> ProgDivs
		{
			get	{ return this.GetTable< ProgDiv>(); }

		}

		public Table< Program> Programs
		{
			get	{ return this.GetTable< Program>(); }

		}

		public Table< Promotion> Promotions
		{
			get	{ return this.GetTable< Promotion>(); }

		}

		public Table< QBConnection> QBConnections
		{
			get	{ return this.GetTable< QBConnection>(); }

		}

		public Table< Query> Queries
		{
			get	{ return this.GetTable< Query>(); }

		}

		public Table< QueryStat> QueryStats
		{
			get	{ return this.GetTable< QueryStat>(); }

		}

		public Table< RecReg> RecRegs
		{
			get	{ return this.GetTable< RecReg>(); }

		}

		public Table< RecurringAmount> RecurringAmounts
		{
			get	{ return this.GetTable< RecurringAmount>(); }

		}

		public Table< RelatedFamily> RelatedFamilies
		{
			get	{ return this.GetTable< RelatedFamily>(); }

		}

		public Table< RepairTransactionsRun> RepairTransactionsRuns
		{
			get	{ return this.GetTable< RepairTransactionsRun>(); }

		}

		public Table< ResidentCode> ResidentCodes
		{
			get	{ return this.GetTable< ResidentCode>(); }

		}

		public Table< Role> Roles
		{
			get	{ return this.GetTable< Role>(); }

		}

		public Table< RssFeed> RssFeeds
		{
			get	{ return this.GetTable< RssFeed>(); }

		}

		public Table< SecurityCode> SecurityCodes
		{
			get	{ return this.GetTable< SecurityCode>(); }

		}

		public Table< Setting> Settings
		{
			get	{ return this.GetTable< Setting>(); }

		}

		public Table< ShirtSize> ShirtSizes
		{
			get	{ return this.GetTable< ShirtSize>(); }

		}

		public Table< SMSGroupMember> SMSGroupMembers
		{
			get	{ return this.GetTable< SMSGroupMember>(); }

		}

		public Table< SMSGroup> SMSGroups
		{
			get	{ return this.GetTable< SMSGroup>(); }

		}

		public Table< SMSItem> SMSItems
		{
			get	{ return this.GetTable< SMSItem>(); }

		}

		public Table< SMSList> SMSLists
		{
			get	{ return this.GetTable< SMSList>(); }

		}

		public Table< SMSNumber> SMSNumbers
		{
			get	{ return this.GetTable< SMSNumber>(); }

		}

		public Table< StateLookup> StateLookups
		{
			get	{ return this.GetTable< StateLookup>(); }

		}

		public Table< StreetType> StreetTypes
		{
			get	{ return this.GetTable< StreetType>(); }

		}

		public Table< SubRequest> SubRequests
		{
			get	{ return this.GetTable< SubRequest>(); }

		}

		public Table< Tag> Tags
		{
			get	{ return this.GetTable< Tag>(); }

		}

		public Table< TagPerson> TagPeople
		{
			get	{ return this.GetTable< TagPerson>(); }

		}

		public Table< TagShare> TagShares
		{
			get	{ return this.GetTable< TagShare>(); }

		}

		public Table< TagType> TagTypes
		{
			get	{ return this.GetTable< TagType>(); }

		}

		public Table< Task> Tasks
		{
			get	{ return this.GetTable< Task>(); }

		}

		public Table< TaskList> TaskLists
		{
			get	{ return this.GetTable< TaskList>(); }

		}

		public Table< TaskListOwner> TaskListOwners
		{
			get	{ return this.GetTable< TaskListOwner>(); }

		}

		public Table< TaskStatus> TaskStatuses
		{
			get	{ return this.GetTable< TaskStatus>(); }

		}

		public Table< Transaction> Transactions
		{
			get	{ return this.GetTable< Transaction>(); }

		}

		public Table< TransactionPerson> TransactionPeople
		{
			get	{ return this.GetTable< TransactionPerson>(); }

		}

		public Table< UploadPeopleRun> UploadPeopleRuns
		{
			get	{ return this.GetTable< UploadPeopleRun>(); }

		}

		public Table< UserRole> UserRoles
		{
			get	{ return this.GetTable< UserRole>(); }

		}

		public Table< User> Users
		{
			get	{ return this.GetTable< User>(); }

		}

		public Table< VolApplicationStatus> VolApplicationStatuses
		{
			get	{ return this.GetTable< VolApplicationStatus>(); }

		}

		public Table< VolInterestCode> VolInterestCodes
		{
			get	{ return this.GetTable< VolInterestCode>(); }

		}

		public Table< VolInterestInterestCode> VolInterestInterestCodes
		{
			get	{ return this.GetTable< VolInterestInterestCode>(); }

		}

		public Table< VolRequest> VolRequests
		{
			get	{ return this.GetTable< VolRequest>(); }

		}

		public Table< Volunteer> Volunteers
		{
			get	{ return this.GetTable< Volunteer>(); }

		}

		public Table< VolunteerCode> VolunteerCodes
		{
			get	{ return this.GetTable< VolunteerCode>(); }

		}

		public Table< VolunteerForm> VolunteerForms
		{
			get	{ return this.GetTable< VolunteerForm>(); }

		}

		public Table< VoluteerApprovalId> VoluteerApprovalIds
		{
			get	{ return this.GetTable< VoluteerApprovalId>(); }

		}

		public Table< Word> Words
		{
			get	{ return this.GetTable< Word>(); }

		}

		public Table< ZipCode> ZipCodes
		{
			get	{ return this.GetTable< ZipCode>(); }

		}

		public Table< Zip> Zips
		{
			get	{ return this.GetTable< Zip>(); }

		}

	#endregion
	#region Views
		
	    public Table< View.ActivityAll> ViewActivityAlls
	    {
		    get { return this.GetTable< View.ActivityAll>(); }

	    }

	    public Table< View.AttendCredit> ViewAttendCredits
	    {
		    get { return this.GetTable< View.AttendCredit>(); }

	    }

	    public Table< View.BundleList> ViewBundleLists
	    {
		    get { return this.GetTable< View.BundleList>(); }

	    }

	    public Table< View.ChangeLogDetail> ViewChangeLogDetails
	    {
		    get { return this.GetTable< View.ChangeLogDetail>(); }

	    }

	    public Table< View.Church> ViewChurches
	    {
		    get { return this.GetTable< View.Church>(); }

	    }

	    public Table< View.City> ViewCities
	    {
		    get { return this.GetTable< View.City>(); }

	    }

	    public Table< View.ContributionsView> ViewContributionsViews
	    {
		    get { return this.GetTable< View.ContributionsView>(); }

	    }

	    public Table< View.FirstName> ViewFirstNames
	    {
		    get { return this.GetTable< View.FirstName>(); }

	    }

	    public Table< View.FirstName2> ViewFirstName2s
	    {
		    get { return this.GetTable< View.FirstName2>(); }

	    }

	    public Table< View.FirstNick> ViewFirstNicks
	    {
		    get { return this.GetTable< View.FirstNick>(); }

	    }

	    public Table< View.LastName> ViewLastNames
	    {
		    get { return this.GetTable< View.LastName>(); }

	    }

	    public Table< View.MasterOrg> ViewMasterOrgs
	    {
		    get { return this.GetTable< View.MasterOrg>(); }

	    }

	    public Table< View.MissionTripTotal> ViewMissionTripTotals
	    {
		    get { return this.GetTable< View.MissionTripTotal>(); }

	    }

	    public Table< View.Nick> ViewNicks
	    {
		    get { return this.GetTable< View.Nick>(); }

	    }

	    public Table< View.OrganizationLeader> ViewOrganizationLeaders
	    {
		    get { return this.GetTable< View.OrganizationLeader>(); }

	    }

	    public Table< View.OrganizationStructure> ViewOrganizationStructures
	    {
		    get { return this.GetTable< View.OrganizationStructure>(); }

	    }

	    public Table< View.PickListOrg> ViewPickListOrgs
	    {
		    get { return this.GetTable< View.PickListOrg>(); }

	    }

	    public Table< View.PickListOrgs2> ViewPickListOrgs2s
	    {
		    get { return this.GetTable< View.PickListOrgs2>(); }

	    }

	    public Table< View.PreviousMemberCount> ViewPreviousMemberCounts
	    {
		    get { return this.GetTable< View.PreviousMemberCount>(); }

	    }

	    public Table< View.RandNumber> ViewRandNumbers
	    {
		    get { return this.GetTable< View.RandNumber>(); }

	    }

	    public Table< View.Sproc> ViewSprocs
	    {
		    get { return this.GetTable< View.Sproc>(); }

	    }

	    public Table< View.StatusFlagList> ViewStatusFlagLists
	    {
		    get { return this.GetTable< View.StatusFlagList>(); }

	    }

	    public Table< View.Trigger> ViewTriggers
	    {
		    get { return this.GetTable< View.Trigger>(); }

	    }

	    public Table< View.UserList> ViewUserLists
	    {
		    get { return this.GetTable< View.UserList>(); }

	    }

	    public Table< View.UserRole> ViewUserRoles
	    {
		    get { return this.GetTable< View.UserRole>(); }

	    }

    #endregion
	#region Table Functions
		
		[Function(Name="dbo.AttendanceCredits", IsComposable = true)]
		public IQueryable< View.AttendanceCredit > AttendanceCredits(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="int")] int? pid
            )
		{
			return this.CreateMethodCallQuery< View.AttendanceCredit>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                pid
                );
		}

		[Function(Name="dbo.AttendanceTypeAsOf", IsComposable = true)]
		public IQueryable< View.AttendanceTypeAsOf > AttendanceTypeAsOf(
            [Parameter(DbType="datetime")] DateTime? from,
            [Parameter(DbType="datetime")] DateTime? to,
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="int")] int? orgtype,
            [Parameter(DbType="nvarchar")] string ids
            )
		{
			return this.CreateMethodCallQuery< View.AttendanceTypeAsOf>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                from,
                to,
                progid,
                divid,
                orgid,
                orgtype,
                ids
                );
		}

		[Function(Name="dbo.AttendCntHistory", IsComposable = true)]
		public IQueryable< View.AttendCntHistory > AttendCntHistory(
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? org,
            [Parameter(DbType="int")] int? sched,
            [Parameter(DbType="datetime")] DateTime? start,
            [Parameter(DbType="datetime")] DateTime? end
            )
		{
			return this.CreateMethodCallQuery< View.AttendCntHistory>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                progid,
                divid,
                org,
                sched,
                start,
                end
                );
		}

		[Function(Name="dbo.AttendDaysAfterNthVisitAsOf", IsComposable = true)]
		public IQueryable< View.AttendDaysAfterNthVisitAsOf > AttendDaysAfterNthVisitAsOf(
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? org,
            [Parameter(DbType="datetime")] DateTime? d1,
            [Parameter(DbType="datetime")] DateTime? d2,
            [Parameter(DbType="int")] int? n,
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.AttendDaysAfterNthVisitAsOf>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                progid,
                divid,
                org,
                d1,
                d2,
                n,
                days
                );
		}

		[Function(Name="dbo.AttendedAsOf", IsComposable = true)]
		public IQueryable< View.AttendedAsOf > AttendedAsOf(
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? org,
            [Parameter(DbType="datetime")] DateTime? dt1,
            [Parameter(DbType="datetime")] DateTime? dt2,
            [Parameter(DbType="bit")] bool? guestonly
            )
		{
			return this.CreateMethodCallQuery< View.AttendedAsOf>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                progid,
                divid,
                org,
                dt1,
                dt2,
                guestonly
                );
		}

		[Function(Name="dbo.AttendMemberTypeAsOf", IsComposable = true)]
		public IQueryable< View.AttendMemberTypeAsOf > AttendMemberTypeAsOf(
            [Parameter(DbType="datetime")] DateTime? from,
            [Parameter(DbType="datetime")] DateTime? to,
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="nvarchar")] string ids
            )
		{
			return this.CreateMethodCallQuery< View.AttendMemberTypeAsOf>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                from,
                to,
                progid,
                divid,
                orgid,
                ids
                );
		}

		[Function(Name="dbo.CheckinFamilyMembers", IsComposable = true)]
		public IQueryable< View.CheckinFamilyMember > CheckinFamilyMembers(
            [Parameter(DbType="int")] int? familyid,
            [Parameter(DbType="int")] int? campus,
            [Parameter(DbType="int")] int? thisday
            )
		{
			return this.CreateMethodCallQuery< View.CheckinFamilyMember>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                familyid,
                campus,
                thisday
                );
		}

		[Function(Name="dbo.CheckinMatch", IsComposable = true)]
		public IQueryable< View.CheckinMatch > CheckinMatch(
            [Parameter(DbType="nvarchar")] string id
            )
		{
			return this.CreateMethodCallQuery< View.CheckinMatch>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                id
                );
		}

		[Function(Name="dbo.ConsecutiveAbsents", IsComposable = true)]
		public IQueryable< View.ConsecutiveAbsent > ConsecutiveAbsents(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.ConsecutiveAbsent>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                divid,
                days
                );
		}

		[Function(Name="dbo.ContactSummary", IsComposable = true)]
		public IQueryable< View.ContactSummary > ContactSummary(
            [Parameter(DbType="datetime")] DateTime? dt1,
            [Parameter(DbType="datetime")] DateTime? dt2,
            [Parameter(DbType="int")] int? min,
            [Parameter(DbType="int")] int? type,
            [Parameter(DbType="int")] int? reas
            )
		{
			return this.CreateMethodCallQuery< View.ContactSummary>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                dt1,
                dt2,
                min,
                type,
                reas
                );
		}

		[Function(Name="dbo.ContactTypeTotals", IsComposable = true)]
		public IQueryable< View.ContactTypeTotal > ContactTypeTotals(
            [Parameter(DbType="datetime")] DateTime? dt1,
            [Parameter(DbType="datetime")] DateTime? dt2,
            [Parameter(DbType="int")] int? min
            )
		{
			return this.CreateMethodCallQuery< View.ContactTypeTotal>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                dt1,
                dt2,
                min
                );
		}

		[Function(Name="dbo.ContributionCountTable", IsComposable = true)]
		public IQueryable< View.ContributionCountTable > ContributionCountTable(
            [Parameter(DbType="int")] int? days,
            [Parameter(DbType="int")] int? cnt,
            [Parameter(DbType="int")] int? fundid,
            [Parameter(DbType="nvarchar")] string op
            )
		{
			return this.CreateMethodCallQuery< View.ContributionCountTable>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                days,
                cnt,
                fundid,
                op
                );
		}

		[Function(Name="dbo.Contributions0", IsComposable = true)]
		public IQueryable< View.Contributions0 > Contributions0(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? fundid,
            [Parameter(DbType="int")] int? campusid,
            [Parameter(DbType="bit")] bool? pledges,
            [Parameter(DbType="bit")] bool? nontaxded,
            [Parameter(DbType="bit")] bool? includeUnclosed
            )
		{
			return this.CreateMethodCallQuery< View.Contributions0>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                fundid,
                campusid,
                pledges,
                nontaxded,
                includeUnclosed
                );
		}

		[Function(Name="dbo.Contributions2", IsComposable = true)]
		public IQueryable< View.Contributions2 > Contributions2(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? campusid,
            [Parameter(DbType="bit")] bool? pledges,
            [Parameter(DbType="bit")] bool? nontaxded,
            [Parameter(DbType="bit")] bool? includeUnclosed
            )
		{
			return this.CreateMethodCallQuery< View.Contributions2>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                campusid,
                pledges,
                nontaxded,
                includeUnclosed
                );
		}

		[Function(Name="dbo.Contributors", IsComposable = true)]
		public IQueryable< View.Contributor > Contributors(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? pid,
            [Parameter(DbType="int")] int? spid,
            [Parameter(DbType="int")] int? fid,
            [Parameter(DbType="bit")] bool? noaddrok,
            [Parameter(DbType="int")] int? tagid
            )
		{
			return this.CreateMethodCallQuery< View.Contributor>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                pid,
                spid,
                fid,
                noaddrok,
                tagid
                );
		}

		[Function(Name="dbo.CsvTable", IsComposable = true)]
		public IQueryable< View.CsvTable > CsvTable(
            [Parameter(DbType="nvarchar")] string csv
            )
		{
			return this.CreateMethodCallQuery< View.CsvTable>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                csv
                );
		}

		[Function(Name="dbo.FindPerson", IsComposable = true)]
		public IQueryable< View.FindPerson > FindPerson(
            [Parameter(DbType="nvarchar")] string first,
            [Parameter(DbType="nvarchar")] string last,
            [Parameter(DbType="datetime")] DateTime? dob,
            [Parameter(DbType="nvarchar")] string email,
            [Parameter(DbType="nvarchar")] string phone
            )
		{
			return this.CreateMethodCallQuery< View.FindPerson>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                first,
                last,
                dob,
                email,
                phone
                );
		}

		[Function(Name="dbo.FindPerson2", IsComposable = true)]
		public IQueryable< View.FindPerson2 > FindPerson2(
            [Parameter(DbType="nvarchar")] string first,
            [Parameter(DbType="nvarchar")] string goesby,
            [Parameter(DbType="nvarchar")] string last,
            [Parameter(DbType="int")] int? m,
            [Parameter(DbType="int")] int? d,
            [Parameter(DbType="int")] int? y,
            [Parameter(DbType="nvarchar")] string email,
            [Parameter(DbType="nvarchar")] string email2,
            [Parameter(DbType="nvarchar")] string phone1,
            [Parameter(DbType="nvarchar")] string phone2,
            [Parameter(DbType="nvarchar")] string phone3
            )
		{
			return this.CreateMethodCallQuery< View.FindPerson2>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                first,
                goesby,
                last,
                m,
                d,
                y,
                email,
                email2,
                phone1,
                phone2,
                phone3
                );
		}

		[Function(Name="dbo.FindPerson3", IsComposable = true)]
		public IQueryable< View.FindPerson3 > FindPerson3(
            [Parameter(DbType="nvarchar")] string first,
            [Parameter(DbType="nvarchar")] string last,
            [Parameter(DbType="datetime")] DateTime? dob,
            [Parameter(DbType="nvarchar")] string email,
            [Parameter(DbType="nvarchar")] string phone1,
            [Parameter(DbType="nvarchar")] string phone2,
            [Parameter(DbType="nvarchar")] string phone3
            )
		{
			return this.CreateMethodCallQuery< View.FindPerson3>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                first,
                last,
                dob,
                email,
                phone1,
                phone2,
                phone3
                );
		}

		[Function(Name="dbo.FindPerson4", IsComposable = true)]
		public IQueryable< View.FindPerson4 > FindPerson4(
            [Parameter(DbType="int")] int? PeopleId1
            )
		{
			return this.CreateMethodCallQuery< View.FindPerson4>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                PeopleId1
                );
		}

		[Function(Name="dbo.FirstTimeGivers", IsComposable = true)]
		public IQueryable< View.FirstTimeGiver > FirstTimeGivers(
            [Parameter(DbType="int")] int? days,
            [Parameter(DbType="int")] int? fundid
            )
		{
			return this.CreateMethodCallQuery< View.FirstTimeGiver>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                days,
                fundid
                );
		}

		[Function(Name="dbo.GetContributions", IsComposable = true)]
		public IQueryable< View.GetContribution > GetContributions(
            [Parameter(DbType="int")] int? fid,
            [Parameter(DbType="bit")] bool? pledge
            )
		{
			return this.CreateMethodCallQuery< View.GetContribution>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fid,
                pledge
                );
		}

		[Function(Name="dbo.GetTodaysMeetingHours", IsComposable = true)]
		public IQueryable< View.GetTodaysMeetingHour > GetTodaysMeetingHours(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="int")] int? thisday
            )
		{
			return this.CreateMethodCallQuery< View.GetTodaysMeetingHour>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                thisday
                );
		}

		[Function(Name="dbo.GetTodaysMeetingHours2", IsComposable = true)]
		public IQueryable< View.GetTodaysMeetingHours2 > GetTodaysMeetingHours2(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="int")] int? thisday,
            [Parameter(DbType="bit")] bool? kioskmode
            )
		{
			return this.CreateMethodCallQuery< View.GetTodaysMeetingHours2>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                thisday,
                kioskmode
                );
		}

		[Function(Name="dbo.GetTodaysMeetingHours3", IsComposable = true)]
		public IQueryable< View.GetTodaysMeetingHours3 > GetTodaysMeetingHours3(
            [Parameter(DbType="int")] int? thisday
            )
		{
			return this.CreateMethodCallQuery< View.GetTodaysMeetingHours3>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                thisday
                );
		}

		[Function(Name="dbo.GetTotalContributions", IsComposable = true)]
		public IQueryable< View.GetTotalContribution > GetTotalContributions(
            [Parameter(DbType="datetime")] DateTime? startdt,
            [Parameter(DbType="datetime")] DateTime? enddt
            )
		{
			return this.CreateMethodCallQuery< View.GetTotalContribution>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                startdt,
                enddt
                );
		}

		[Function(Name="dbo.GetTotalContributions2", IsComposable = true)]
		public IQueryable< View.GetTotalContributions2 > GetTotalContributions2(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? campusid,
            [Parameter(DbType="bit")] bool? nontaxded,
            [Parameter(DbType="bit")] bool? includeUnclosed
            )
		{
			return this.CreateMethodCallQuery< View.GetTotalContributions2>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                campusid,
                nontaxded,
                includeUnclosed
                );
		}

		[Function(Name="dbo.GetTotalContributions3", IsComposable = true)]
		public IQueryable< View.GetTotalContributions3 > GetTotalContributions3(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? campusid,
            [Parameter(DbType="bit")] bool? nontaxded,
            [Parameter(DbType="bit")] bool? includeUnclosed
            )
		{
			return this.CreateMethodCallQuery< View.GetTotalContributions3>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                campusid,
                nontaxded,
                includeUnclosed
                );
		}

		[Function(Name="dbo.GetTotalContributionsDonor2", IsComposable = true)]
		public IQueryable< View.GetTotalContributionsDonor2 > GetTotalContributionsDonor2(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? campusid,
            [Parameter(DbType="bit")] bool? nontaxded,
            [Parameter(DbType="bit")] bool? includeUnclosed
            )
		{
			return this.CreateMethodCallQuery< View.GetTotalContributionsDonor2>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                campusid,
                nontaxded,
                includeUnclosed
                );
		}

		[Function(Name="dbo.GetTotalContributionsRange", IsComposable = true)]
		public IQueryable< View.GetTotalContributionsRange > GetTotalContributionsRange(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? campusid,
            [Parameter(DbType="bit")] bool? nontaxded,
            [Parameter(DbType="bit")] bool? includeUnclosed
            )
		{
			return this.CreateMethodCallQuery< View.GetTotalContributionsRange>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                campusid,
                nontaxded,
                includeUnclosed
                );
		}

		[Function(Name="dbo.GivingCurrentPercentOfFormer", IsComposable = true)]
		public IQueryable< View.GivingCurrentPercentOfFormer > GivingCurrentPercentOfFormer(
            [Parameter(DbType="datetime")] DateTime? dt1,
            [Parameter(DbType="datetime")] DateTime? dt2,
            [Parameter(DbType="nvarchar")] string comp,
            [Parameter(DbType="float")] double? pct
            )
		{
			return this.CreateMethodCallQuery< View.GivingCurrentPercentOfFormer>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                dt1,
                dt2,
                comp,
                pct
                );
		}

		[Function(Name="dbo.LastMeetings", IsComposable = true)]
		public IQueryable< View.LastMeeting > LastMeetings(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.LastMeeting>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                divid,
                days
                );
		}

		[Function(Name="dbo.MeetingsDataForDateRange", IsComposable = true)]
		public IQueryable< View.MeetingsDataForDateRange > MeetingsDataForDateRange(
            [Parameter(DbType="varchar")] string orgs,
            [Parameter(DbType="datetime")] DateTime? startdate,
            [Parameter(DbType="datetime")] DateTime? enddate
            )
		{
			return this.CreateMethodCallQuery< View.MeetingsDataForDateRange>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgs,
                startdate,
                enddate
                );
		}

		[Function(Name="dbo.MembersAsOf", IsComposable = true)]
		public IQueryable< View.MembersAsOf > MembersAsOf(
            [Parameter(DbType="datetime")] DateTime? from,
            [Parameter(DbType="datetime")] DateTime? to,
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? orgid
            )
		{
			return this.CreateMethodCallQuery< View.MembersAsOf>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                from,
                to,
                progid,
                divid,
                orgid
                );
		}

		[Function(Name="dbo.MembersWhoAttendedOrgs", IsComposable = true)]
		public IQueryable< View.MembersWhoAttendedOrg > MembersWhoAttendedOrgs(
            [Parameter(DbType="varchar")] string orgs,
            [Parameter(DbType="datetime")] DateTime? firstdate
            )
		{
			return this.CreateMethodCallQuery< View.MembersWhoAttendedOrg>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgs,
                firstdate
                );
		}

		[Function(Name="dbo.MostRecentItems", IsComposable = true)]
		public IQueryable< View.MostRecentItem > MostRecentItems(
            [Parameter(DbType="int")] int? uid
            )
		{
			return this.CreateMethodCallQuery< View.MostRecentItem>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                uid
                );
		}

		[Function(Name="dbo.OrgMembersAsOfDate", IsComposable = true)]
		public IQueryable< View.OrgMembersAsOfDate > OrgMembersAsOfDate(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="datetime")] DateTime? meetingdt
            )
		{
			return this.CreateMethodCallQuery< View.OrgMembersAsOfDate>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                meetingdt
                );
		}

		[Function(Name="dbo.OrgVisitorsAsOfDate", IsComposable = true)]
		public IQueryable< View.OrgVisitorsAsOfDate > OrgVisitorsAsOfDate(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="datetime")] DateTime? meetingdt,
            [Parameter(DbType="bit")] bool? NoCurrentMembers
            )
		{
			return this.CreateMethodCallQuery< View.OrgVisitorsAsOfDate>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                meetingdt,
                NoCurrentMembers
                );
		}

		[Function(Name="dbo.PledgeFulfillment", IsComposable = true)]
		public IQueryable< View.PledgeFulfillment > PledgeFulfillment(
            [Parameter(DbType="int")] int? fundid
            )
		{
			return this.CreateMethodCallQuery< View.PledgeFulfillment>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fundid
                );
		}

		[Function(Name="dbo.PledgeReport", IsComposable = true)]
		public IQueryable< View.PledgeReport > PledgeReport(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? campusid
            )
		{
			return this.CreateMethodCallQuery< View.PledgeReport>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                campusid
                );
		}

		[Function(Name="dbo.Pledges0", IsComposable = true)]
		public IQueryable< View.Pledges0 > Pledges0(
            [Parameter(DbType="datetime")] DateTime? fd,
            [Parameter(DbType="datetime")] DateTime? td,
            [Parameter(DbType="int")] int? fundid,
            [Parameter(DbType="int")] int? campusid
            )
		{
			return this.CreateMethodCallQuery< View.Pledges0>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fd,
                td,
                fundid,
                campusid
                );
		}

		[Function(Name="dbo.RecentAbsents", IsComposable = true)]
		public IQueryable< View.RecentAbsent > RecentAbsents(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.RecentAbsent>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                divid,
                days
                );
		}

		[Function(Name="dbo.RecentAbsents2", IsComposable = true)]
		public IQueryable< View.RecentAbsents2 > RecentAbsents2(
            [Parameter(DbType="int")] int? orgid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.RecentAbsents2>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                divid,
                days
                );
		}

		[Function(Name="dbo.RecentAttendance", IsComposable = true)]
		public IQueryable< View.RecentAttendance > RecentAttendance(
            [Parameter(DbType="int")] int? oid
            )
		{
			return this.CreateMethodCallQuery< View.RecentAttendance>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid
                );
		}

		[Function(Name="dbo.RecentAttendInDaysByCount", IsComposable = true)]
		public IQueryable< View.RecentAttendInDaysByCount > RecentAttendInDaysByCount(
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? org,
            [Parameter(DbType="int")] int? orgtype,
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.RecentAttendInDaysByCount>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                progid,
                divid,
                org,
                orgtype,
                days
                );
		}

		[Function(Name="dbo.RecentAttendMemberType", IsComposable = true)]
		public IQueryable< View.RecentAttendMemberType > RecentAttendMemberType(
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? org,
            [Parameter(DbType="int")] int? days,
            [Parameter(DbType="varchar")] string idstring
            )
		{
			return this.CreateMethodCallQuery< View.RecentAttendMemberType>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                progid,
                divid,
                org,
                days,
                idstring
                );
		}

		[Function(Name="dbo.RecentAttendType", IsComposable = true)]
		public IQueryable< View.RecentAttendType > RecentAttendType(
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? org,
            [Parameter(DbType="int")] int? days,
            [Parameter(DbType="varchar")] string idstring
            )
		{
			return this.CreateMethodCallQuery< View.RecentAttendType>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                progid,
                divid,
                org,
                days,
                idstring
                );
		}

		[Function(Name="dbo.RecentNewVisitCount", IsComposable = true)]
		public IQueryable< View.RecentNewVisitCount > RecentNewVisitCount(
            [Parameter(DbType="int")] int? progid,
            [Parameter(DbType="int")] int? divid,
            [Parameter(DbType="int")] int? org,
            [Parameter(DbType="int")] int? orgtype,
            [Parameter(DbType="int")] int? days0,
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.RecentNewVisitCount>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                progid,
                divid,
                org,
                orgtype,
                days0,
                days
                );
		}

		[Function(Name="dbo.RecentRegistrations", IsComposable = true)]
		public IQueryable< View.RecentRegistration > RecentRegistrations(
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.RecentRegistration>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                days
                );
		}

		[Function(Name="dbo.Registrations", IsComposable = true)]
		public IQueryable< View.Registration > Registrations(
            [Parameter(DbType="int")] int? days
            )
		{
			return this.CreateMethodCallQuery< View.Registration>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                days
                );
		}

		[Function(Name="dbo.Split", IsComposable = true)]
		public IQueryable< View.Split > Split(
            [Parameter(DbType="nvarchar")] string InputText,
            [Parameter(DbType="nvarchar")] string Delimiter
            )
		{
			return this.CreateMethodCallQuery< View.Split>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                InputText,
                Delimiter
                );
		}

		[Function(Name="dbo.SplitInts", IsComposable = true)]
		public IQueryable< View.SplitInt > SplitInts(
            [Parameter(DbType="varchar")] string List
            )
		{
			return this.CreateMethodCallQuery< View.SplitInt>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                List
                );
		}

		[Function(Name="dbo.StatusFlags", IsComposable = true)]
		public IQueryable< View.StatusFlag > StatusFlags(
            [Parameter(DbType="nvarchar")] string flags
            )
		{
			return this.CreateMethodCallQuery< View.StatusFlag>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                flags
                );
		}

		[Function(Name="dbo.StatusFlagsPerson", IsComposable = true)]
		public IQueryable< View.StatusFlagsPerson > StatusFlagsPerson(
            [Parameter(DbType="int")] int? pid
            )
		{
			return this.CreateMethodCallQuery< View.StatusFlagsPerson>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                );
		}

		[Function(Name="dbo.SundayDates", IsComposable = true)]
		public IQueryable< View.SundayDate > SundayDates(
            [Parameter(DbType="datetime")] DateTime? dt1,
            [Parameter(DbType="datetime")] DateTime? dt2
            )
		{
			return this.CreateMethodCallQuery< View.SundayDate>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                dt1,
                dt2
                );
		}

		[Function(Name="dbo.TaggedPeople", IsComposable = true)]
		public IQueryable< View.TaggedPerson > TaggedPeople(
            [Parameter(DbType="int")] int? tagid
            )
		{
			return this.CreateMethodCallQuery< View.TaggedPerson>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                tagid
                );
		}

		[Function(Name="dbo.VisitNumberSinceDate", IsComposable = true)]
		public IQueryable< View.VisitNumberSinceDate > VisitNumberSinceDate(
            [Parameter(DbType="datetime")] DateTime? dt,
            [Parameter(DbType="int")] int? n
            )
		{
			return this.CreateMethodCallQuery< View.VisitNumberSinceDate>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                dt,
                n
                );
		}

		[Function(Name="dbo.WeeklyAttendsForOrgs", IsComposable = true)]
		public IQueryable< View.WeeklyAttendsForOrg > WeeklyAttendsForOrgs(
            [Parameter(DbType="varchar")] string orgs,
            [Parameter(DbType="datetime")] DateTime? firstdate
            )
		{
			return this.CreateMethodCallQuery< View.WeeklyAttendsForOrg>(this, 
			    ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgs,
                firstdate
                );
		}

    #endregion
	#region Scalar Functions
		
		[Function(Name="dbo.AttendItem", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? AttendItem(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "n", DbType="int")] int? n
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                n
                ).ReturnValue));
		}

		[Function(Name="dbo.ContributionChange", IsComposable = true)]
		[return: Parameter(DbType = "float")]
		public double? ContributionChange(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "dt1", DbType="datetime")] DateTime? dt1,
            [Parameter(Name = "dt2", DbType="datetime")] DateTime? dt2
            )
		{
			return ((double?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                dt1,
                dt2
                ).ReturnValue));
		}

		[Function(Name="dbo.LastActive", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? LastActive(
            [Parameter(Name = "uid", DbType="int")] int? uid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                uid
                ).ReturnValue));
		}

		[Function(Name="dbo.ContributionAmount2", IsComposable = true)]
		[return: Parameter(DbType = "money")]
		public decimal? ContributionAmount2(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "dt1", DbType="datetime")] DateTime? dt1,
            [Parameter(Name = "dt2", DbType="datetime")] DateTime? dt2,
            [Parameter(Name = "fundid", DbType="int")] int? fundid
            )
		{
			return ((decimal?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                dt1,
                dt2,
                fundid
                ).ReturnValue));
		}

		[Function(Name="dbo.AddressMatch", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? AddressMatch(
            [Parameter(Name = "var1", DbType="nvarchar")] string var1,
            [Parameter(Name = "var2", DbType="nvarchar")] string var2
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                var1,
                var2
                ).ReturnValue));
		}

		[Function(Name="dbo.AvgSunAttendance", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? AvgSunAttendance(
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod()))
                ).ReturnValue));
		}

		[Function(Name="dbo.GetAttendedTodaysMeeting", IsComposable = true)]
		[return: Parameter(DbType = "bit")]
		public bool? GetAttendedTodaysMeeting(
            [Parameter(Name = "orgid", DbType="int")] int? orgid,
            [Parameter(Name = "thisday", DbType="int")] int? thisday,
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((bool?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                thisday,
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.GetTodaysMeetingHour", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? GetTodaysMeetingHour(
            [Parameter(Name = "thisday", DbType="int")] int? thisday,
            [Parameter(Name = "MeetingTime", DbType="datetime")] DateTime? MeetingTime,
            [Parameter(Name = "SchedDay", DbType="int")] int? SchedDay
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                thisday,
                MeetingTime,
                SchedDay
                ).ReturnValue));
		}

		[Function(Name="dbo.GetTodaysMeetingId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? GetTodaysMeetingId(
            [Parameter(Name = "orgid", DbType="int")] int? orgid,
            [Parameter(Name = "thisday", DbType="int")] int? thisday
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                thisday
                ).ReturnValue));
		}

		[Function(Name="dbo.TotalPaid", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? TotalPaid(
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid,
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.SpouseIdJoint", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? SpouseIdJoint(
            [Parameter(Name = "peopleid", DbType="int")] int? peopleid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                peopleid
                ).ReturnValue));
		}

		[Function(Name="dbo.AttendDesc", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string AttendDesc(
            [Parameter(Name = "id", DbType="int")] int? id
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                id
                ).ReturnValue));
		}

		[Function(Name="dbo.MemberDesc", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string MemberDesc(
            [Parameter(Name = "id", DbType="int")] int? id
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                id
                ).ReturnValue));
		}

		[Function(Name="dbo.fn_diagramobjects", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? FnDiagramobjects(
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod()))
                ).ReturnValue));
		}

		[Function(Name="dbo.PrimaryCountry", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string PrimaryCountry(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.WasDeaconActive2008", IsComposable = true)]
		[return: Parameter(DbType = "bit")]
		public bool? WasDeaconActive2008(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "dt", DbType="datetime")] DateTime? dt
            )
		{
			return ((bool?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                dt
                ).ReturnValue));
		}

		[Function(Name="dbo.LastAttend", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? LastAttend(
            [Parameter(Name = "orgid", DbType="int")] int? orgid,
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.LastDrop", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? LastDrop(
            [Parameter(Name = "orgid", DbType="int")] int? orgid,
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.LastAttended", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? LastAttended(
            [Parameter(Name = "orgid", DbType="int")] int? orgid,
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid,
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.BaptismAgeRange", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string BaptismAgeRange(
            [Parameter(Name = "age", DbType="int")] int? age
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                age
                ).ReturnValue));
		}

		[Function(Name="dbo.DaysSinceAttend", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? DaysSinceAttend(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "oid", DbType="int")] int? oid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                oid
                ).ReturnValue));
		}

		[Function(Name="dbo.SundayForWeek", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? SundayForWeek(
            [Parameter(Name = "year", DbType="int")] int? year,
            [Parameter(Name = "week", DbType="int")] int? week
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                year,
                week
                ).ReturnValue));
		}

		[Function(Name="dbo.ScheduleId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? ScheduleId(
            [Parameter(Name = "day", DbType="int")] int? day,
            [Parameter(Name = "time", DbType="datetime")] DateTime? time
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                day,
                time
                ).ReturnValue));
		}

		[Function(Name="dbo.GetScheduleTime", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? GetScheduleTime(
            [Parameter(Name = "day", DbType="int")] int? day,
            [Parameter(Name = "time", DbType="datetime")] DateTime? time
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                day,
                time
                ).ReturnValue));
		}

		[Function(Name="dbo.OrganizationMemberCount", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? OrganizationMemberCount(
            [Parameter(Name = "oid", DbType="int")] int? oid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid
                ).ReturnValue));
		}

		[Function(Name="dbo.PersonAttendCountOrg", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? PersonAttendCountOrg(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "oid", DbType="int")] int? oid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                oid
                ).ReturnValue));
		}

		[Function(Name="dbo.PrimaryAddress2", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string PrimaryAddress2(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.GetEldestFamilyMember", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? GetEldestFamilyMember(
            [Parameter(Name = "fid", DbType="int")] int? fid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fid
                ).ReturnValue));
		}

		[Function(Name="dbo.Birthday", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? Birthday(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.HeadOfHouseholdId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? HeadOfHouseholdId(
            [Parameter(Name = "familyid", DbType="int")] int? familyid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                familyid
                ).ReturnValue));
		}

		[Function(Name="dbo.HeadOfHouseHoldSpouseId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? HeadOfHouseHoldSpouseId(
            [Parameter(Name = "familyid", DbType="int")] int? familyid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                familyid
                ).ReturnValue));
		}

		[Function(Name="dbo.CoupleFlag", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? CoupleFlag(
            [Parameter(Name = "familyid", DbType="int")] int? familyid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                familyid
                ).ReturnValue));
		}

		[Function(Name="dbo.NextChangeTransactionId2", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? NextChangeTransactionId2(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "tid", DbType="int")] int? tid,
            [Parameter(Name = "typeid", DbType="int")] int? typeid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                oid,
                tid,
                typeid
                ).ReturnValue));
		}

		[Function(Name="dbo.PrimaryCity", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string PrimaryCity(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.PrimaryZip", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string PrimaryZip(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.BibleFellowshipClassId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? BibleFellowshipClassId(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.SpouseId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? SpouseId(
            [Parameter(Name = "peopleid", DbType="int")] int? peopleid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                peopleid
                ).ReturnValue));
		}

		[Function(Name="dbo.Age", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? Age(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.PrimaryResCode", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? PrimaryResCode(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.EntryPointId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? EntryPointId(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.Tool_VarbinaryToVarcharHex", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string ToolVarbinaryToVarcharHex(
            [Parameter(Name = "VarbinaryValue", DbType="varbinary")] byte[] VarbinaryValue
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                VarbinaryValue
                ).ReturnValue));
		}

		[Function(Name="dbo.PrimaryBadAddressFlag", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? PrimaryBadAddressFlag(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.NextTranChangeDate", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? NextTranChangeDate(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "tdt", DbType="datetime")] DateTime? tdt,
            [Parameter(Name = "typeid", DbType="int")] int? typeid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                oid,
                tdt,
                typeid
                ).ReturnValue));
		}

		[Function(Name="dbo.NextChangeTransactionId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? NextChangeTransactionId(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "tid", DbType="int")] int? tid,
            [Parameter(Name = "typeid", DbType="int")] int? typeid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                oid,
                tid,
                typeid
                ).ReturnValue));
		}

		[Function(Name="dbo.PrimaryAddress", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string PrimaryAddress(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.LastNameCount", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? LastNameCount(
            [Parameter(Name = "last", DbType="nvarchar")] string last
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                last
                ).ReturnValue));
		}

		[Function(Name="dbo.PrimaryState", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string PrimaryState(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.HomePhone", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string HomePhone(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.MemberStatusDescription", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string MemberStatusDescription(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.OrganizationLeaderId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? OrganizationLeaderId(
            [Parameter(Name = "orgid", DbType="int")] int? orgid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid
                ).ReturnValue));
		}

		[Function(Name="dbo.UserName", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string UserName(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.EnrollmentTransactionId", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? EnrollmentTransactionId(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "tdt", DbType="datetime")] DateTime? tdt,
            [Parameter(Name = "ttid", DbType="int")] int? ttid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                oid,
                tdt,
                ttid
                ).ReturnValue));
		}

		[Function(Name="dbo.NextBirthday", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? NextBirthday(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.GetPeopleIdFromIndividualNumber", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? GetPeopleIdFromIndividualNumber(
            [Parameter(Name = "indnum", DbType="int")] int? indnum
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                indnum
                ).ReturnValue));
		}

		[Function(Name="dbo.OrganizationLeaderName", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string OrganizationLeaderName(
            [Parameter(Name = "orgid", DbType="int")] int? orgid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                orgid
                ).ReturnValue));
		}

		[Function(Name="dbo.UserPeopleIdFromEmail", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? UserPeopleIdFromEmail(
            [Parameter(Name = "email", DbType="nvarchar")] string email
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                email
                ).ReturnValue));
		}

		[Function(Name="dbo.DayAndTime", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string DayAndTime(
            [Parameter(Name = "dt", DbType="datetime")] DateTime? dt
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                dt
                ).ReturnValue));
		}

		[Function(Name="dbo.DollarRange", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? DollarRange(
            [Parameter(Name = "amt", DbType="decimal")] decimal? amt
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                amt
                ).ReturnValue));
		}

		[Function(Name="dbo.FirstMondayOfMonth", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? FirstMondayOfMonth(
            [Parameter(Name = "inputDate", DbType="datetime")] DateTime? inputDate
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                inputDate
                ).ReturnValue));
		}

		[Function(Name="dbo.StartsLower", IsComposable = true)]
		[return: Parameter(DbType = "bit")]
		public bool? StartsLower(
            [Parameter(Name = "s", DbType="nvarchar")] string s
            )
		{
			return ((bool?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                s
                ).ReturnValue));
		}

		[Function(Name="dbo.LastContact", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? LastContact(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.DaysSinceContact", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? DaysSinceContact(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.DaysBetween12Attend", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? DaysBetween12Attend(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "progid", DbType="int")] int? progid,
            [Parameter(Name = "divid", DbType="int")] int? divid,
            [Parameter(Name = "orgid", DbType="int")] int? orgid,
            [Parameter(Name = "lookback", DbType="int")] int? lookback
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                progid,
                divid,
                orgid,
                lookback
                ).ReturnValue));
		}

		[Function(Name="dbo.UserRoleList", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string UserRoleList(
            [Parameter(Name = "uid", DbType="int")] int? uid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                uid
                ).ReturnValue));
		}

		[Function(Name="dbo.LastMemberTypeInTrans", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? LastMemberTypeInTrans(
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid,
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.MemberTypeAtLastDrop", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? MemberTypeAtLastDrop(
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid,
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.OrganizationMemberCount2", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? OrganizationMemberCount2(
            [Parameter(Name = "oid", DbType="int")] int? oid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid
                ).ReturnValue));
		}

		[Function(Name="dbo.LastIdInTrans", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? LastIdInTrans(
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid,
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.ComputeAge", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? ComputeAge(
            [Parameter(Name = "m", DbType="int")] int? m,
            [Parameter(Name = "d", DbType="int")] int? d,
            [Parameter(Name = "y", DbType="int")] int? y
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                m,
                d,
                y
                ).ReturnValue));
		}

		[Function(Name="dbo.GetWeekDayNameOfDate", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string GetWeekDayNameOfDate(
            [Parameter(Name = "DateX", DbType="datetime")] DateTime? DateX
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                DateX
                ).ReturnValue));
		}

		[Function(Name="dbo.GetScheduleDesc", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string GetScheduleDesc(
            [Parameter(Name = "meetingtime", DbType="datetime")] DateTime? meetingtime
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                meetingtime
                ).ReturnValue));
		}

		[Function(Name="dbo.NextAnniversary", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? NextAnniversary(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.FindResCode", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? FindResCode(
            [Parameter(Name = "zipcode", DbType="nvarchar")] string zipcode,
            [Parameter(Name = "country", DbType="nvarchar")] string country
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                zipcode,
                country
                ).ReturnValue));
		}

		[Function(Name="dbo.SchoolGrade", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? SchoolGrade(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.WidowedDate", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? WidowedDate(
            [Parameter(Name = "peopleid", DbType="int")] int? peopleid
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                peopleid
                ).ReturnValue));
		}

		[Function(Name="dbo.FamilyMakeup", IsComposable = true)]
		[return: Parameter(DbType = "varchar")]
		public string FamilyMakeup(
            [Parameter(Name = "fid", DbType="int")] int? fid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fid
                ).ReturnValue));
		}

		[Function(Name="dbo.GetPeopleIdFromACS", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? GetPeopleIdFromACS(
            [Parameter(Name = "famnum", DbType="int")] int? famnum,
            [Parameter(Name = "indnum", DbType="int")] int? indnum
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                famnum,
                indnum
                ).ReturnValue));
		}

		[Function(Name="dbo.SundayForDate", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? SundayForDate(
            [Parameter(Name = "dt", DbType="datetime")] DateTime? dt
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                dt
                ).ReturnValue));
		}

		[Function(Name="dbo.ComputePositionInFamily", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? ComputePositionInFamily(
            [Parameter(Name = "age", DbType="int")] int? age,
            [Parameter(Name = "marital", DbType="int")] int? marital,
            [Parameter(Name = "fid", DbType="int")] int? fid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                age,
                marital,
                fid
                ).ReturnValue));
		}

		[Function(Name="dbo.UEmail", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string UEmail(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.DecToBase", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string DecToBase(
            [Parameter(Name = "val", DbType="bigint")] long? val,
            [Parameter(Name = "baseX", DbType="int")] int? baseX
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                val,
                baseX
                ).ReturnValue));
		}

		[Function(Name="dbo.FirstMeetingDateLastLear", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string FirstMeetingDateLastLear(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.MemberTypeAsOf", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? MemberTypeAsOf(
            [Parameter(Name = "oid", DbType="int")] int? oid,
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "dt", DbType="datetime")] DateTime? dt
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid,
                pid,
                dt
                ).ReturnValue));
		}

		[Function(Name="dbo.GetSecurityCode", IsComposable = true)]
		[return: Parameter(DbType = "char")]
		public string GetSecurityCode(
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod()))
                ).ReturnValue));
		}

		[Function(Name="dbo.PledgeCount", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? PledgeCount(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "days", DbType="int")] int? days,
            [Parameter(Name = "fundid", DbType="int")] int? fundid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                days,
                fundid
                ).ReturnValue));
		}

		[Function(Name="dbo.IsValidEmail", IsComposable = true)]
		[return: Parameter(DbType = "bit")]
		public bool? IsValidEmail(
            [Parameter(Name = "addr", DbType="nvarchar")] string addr
            )
		{
			return ((bool?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                addr
                ).ReturnValue));
		}

		[Function(Name="dbo.PledgeAmount", IsComposable = true)]
		[return: Parameter(DbType = "money")]
		public decimal? PledgeAmount(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "days", DbType="int")] int? days,
            [Parameter(Name = "fundid", DbType="int")] int? fundid
            )
		{
			return ((decimal?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                days,
                fundid
                ).ReturnValue));
		}

		[Function(Name="dbo.FmtPhone", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string FmtPhone(
            [Parameter(Name = "PhoneNumber", DbType="nvarchar")] string PhoneNumber
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                PhoneNumber
                ).ReturnValue));
		}

		[Function(Name="dbo.GetAttendType", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? GetAttendType(
            [Parameter(Name = "attended", DbType="bit")] bool? attended,
            [Parameter(Name = "membertypeid", DbType="int")] int? membertypeid,
            [Parameter(Name = "group", DbType="bit")] bool? group
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                attended,
                membertypeid,
                group
                ).ReturnValue));
		}

		[Function(Name="dbo.LastChanged", IsComposable = true)]
		[return: Parameter(DbType = "datetime")]
		public DateTime? LastChanged(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "field", DbType="nvarchar")] string field
            )
		{
			return ((DateTime?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                field
                ).ReturnValue));
		}

		[Function(Name="dbo.GetDigits", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string GetDigits(
            [Parameter(Name = "Str", DbType="nvarchar")] string Str
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                Str
                ).ReturnValue));
		}

		[Function(Name="dbo.ParentNamesAndCells", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string ParentNamesAndCells(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.StatusFlagsAll", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string StatusFlagsAll(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.StatusFlag", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string StatusFlag(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.OrganizationPrevMemberCount", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? OrganizationPrevMemberCount(
            [Parameter(Name = "oid", DbType="int")] int? oid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                oid
                ).ReturnValue));
		}

		[Function(Name="dbo.SpaceToNull", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string SpaceToNull(
            [Parameter(Name = "s", DbType="nvarchar")] string s
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                s
                ).ReturnValue));
		}

		[Function(Name="dbo.ContributionCount", IsComposable = true)]
		[return: Parameter(DbType = "int")]
		public int? ContributionCount(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "days", DbType="int")] int? days,
            [Parameter(Name = "fundid", DbType="int")] int? fundid
            )
		{
			return ((int?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                days,
                fundid
                ).ReturnValue));
		}

		[Function(Name="dbo.ContributionAmount", IsComposable = true)]
		[return: Parameter(DbType = "money")]
		public decimal? ContributionAmount(
            [Parameter(Name = "pid", DbType="int")] int? pid,
            [Parameter(Name = "days", DbType="int")] int? days,
            [Parameter(Name = "fundid", DbType="int")] int? fundid
            )
		{
			return ((decimal?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid,
                days,
                fundid
                ).ReturnValue));
		}

		[Function(Name="dbo.UName2", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string UName2(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

		[Function(Name="dbo.OneHeadOfHouseholdIsMember", IsComposable = true)]
		[return: Parameter(DbType = "bit")]
		public bool? OneHeadOfHouseholdIsMember(
            [Parameter(Name = "fid", DbType="int")] int? fid
            )
		{
			return ((bool?)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                fid
                ).ReturnValue));
		}

		[Function(Name="dbo.UName", IsComposable = true)]
		[return: Parameter(DbType = "nvarchar")]
		public string UName(
            [Parameter(Name = "pid", DbType="int")] int? pid
            )
		{
			return ((string)(this.ExecuteMethodCall(this, 
                ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                pid
                ).ReturnValue));
		}

    #endregion
	#region Stored Procedures
		
		[Function(Name="dbo.NextSecurityCode")]
		public ISingleResult< SecurityCode> NextSecurityCode(
            [Parameter(Name = "dt", DbType="datetime")] DateTime? dt
            )
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                dt
			);
			return ((ISingleResult< SecurityCode>)(result.ReturnValue));
		}

		[Function(Name="dbo.TopPledgers")]
		public ISingleResult< TopGiver> TopPledgers(
            [Parameter(Name = "top", DbType="int")] int? top,
            [Parameter(Name = "sdate", DbType="datetime")] DateTime? sdate,
            [Parameter(Name = "edate", DbType="datetime")] DateTime? edate
            )
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                top,
                sdate,
                edate
			);
			return ((ISingleResult< TopGiver>)(result.ReturnValue));
		}

		[Function(Name="dbo.TopGivers")]
		public ISingleResult< TopGiver> TopGivers(
            [Parameter(Name = "top", DbType="int")] int? top,
            [Parameter(Name = "sdate", DbType="datetime")] DateTime? sdate,
            [Parameter(Name = "edate", DbType="datetime")] DateTime? edate
            )
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),
                top,
                sdate,
                edate
			);
			return ((ISingleResult< TopGiver>)(result.ReturnValue));
		}

    #endregion
   }

}

