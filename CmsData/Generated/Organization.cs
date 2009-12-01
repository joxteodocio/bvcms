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
	[Table(Name="dbo.Organizations")]
	public partial class Organization : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
	#region Private Fields
		
		private int _OrganizationId;
		
		private int _CreatedBy;
		
		private DateTime _CreatedDate;
		
		private int _OrganizationStatusId;
		
		private int? _DivisionId;
		
		private int? _LeaderMemberTypeId;
		
		private int? _GradeRangeStart;
		
		private int? _GradeRangeEnd;
		
		private int? _RollSheetVisitorWks;
		
		private int _AttendTrkLevelId;
		
		private int _SecurityTypeId;
		
		private int _AttendClassificationId;
		
		private DateTime? _FirstMeetingDate;
		
		private DateTime? _LastMeetingDate;
		
		private DateTime? _OrganizationClosedDate;
		
		private string _Location;
		
		private string _OrganizationName;
		
		private int? _ModifiedBy;
		
		private DateTime? _ModifiedDate;
		
		private int? _ScheduleId;
		
		private int? _EntryPointId;
		
		private int? _ParentOrgId;
		
		private bool _AllowAttendOverlap;
		
		private int? _MemberCount;
		
		private int? _LeaderId;
		
		private string _LeaderName;
		
		private bool? _ClassFilled;
		
		private int? _OnLineCatalogSort;
		
		private string _PendingLoc;
		
		private bool? _CanSelfCheckin;
		
		private int? _NumCheckInLabels;
		
		private int? _CampusId;
		
		private bool? _AllowNonCampusCheckIn;
		
		private int? _NumWorkerCheckInLabels;
		
		private DateTime? _SchedTime;
		
		private int? _SchedDay;
		
		private DateTime? _MeetingTime;
		
   		
   		private EntitySet< Organization> _ChildOrgs;
		
   		private EntitySet< EnrollmentTransaction> _EnrollmentTransactions;
		
   		private EntitySet< Attend> _Attends;
		
   		private EntitySet< BadET> _BadETs;
		
   		private EntitySet< CheckInTime> _CheckInTimes;
		
   		private EntitySet< DivOrg> _DivOrgs;
		
   		private EntitySet< LoveRespect> _LoveRespects;
		
   		private EntitySet< Meeting> _Meetings;
		
   		private EntitySet< MemberTag> _MemberTags;
		
   		private EntitySet< RecReg> _RecRegs;
		
   		private EntitySet< RecAgeDivision> _RecAgeDivisions;
		
   		private EntitySet< OrganizationMember> _OrganizationMembers;
		
    	
		private EntityRef< Organization> _ParentOrg;
		
		private EntityRef< Campu> _Campu;
		
		private EntityRef< Division> _Division;
		
		private EntityRef< AttendTrackLevel> _AttendTrackLevel;
		
		private EntityRef< EntryPoint> _EntryPoint;
		
		private EntityRef< OrganizationStatus> _OrganizationStatus;
		
	#endregion
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
		
		partial void OnOrganizationIdChanging(int value);
		partial void OnOrganizationIdChanged();
		
		partial void OnCreatedByChanging(int value);
		partial void OnCreatedByChanged();
		
		partial void OnCreatedDateChanging(DateTime value);
		partial void OnCreatedDateChanged();
		
		partial void OnOrganizationStatusIdChanging(int value);
		partial void OnOrganizationStatusIdChanged();
		
		partial void OnDivisionIdChanging(int? value);
		partial void OnDivisionIdChanged();
		
		partial void OnLeaderMemberTypeIdChanging(int? value);
		partial void OnLeaderMemberTypeIdChanged();
		
		partial void OnGradeRangeStartChanging(int? value);
		partial void OnGradeRangeStartChanged();
		
		partial void OnGradeRangeEndChanging(int? value);
		partial void OnGradeRangeEndChanged();
		
		partial void OnRollSheetVisitorWksChanging(int? value);
		partial void OnRollSheetVisitorWksChanged();
		
		partial void OnAttendTrkLevelIdChanging(int value);
		partial void OnAttendTrkLevelIdChanged();
		
		partial void OnSecurityTypeIdChanging(int value);
		partial void OnSecurityTypeIdChanged();
		
		partial void OnAttendClassificationIdChanging(int value);
		partial void OnAttendClassificationIdChanged();
		
		partial void OnFirstMeetingDateChanging(DateTime? value);
		partial void OnFirstMeetingDateChanged();
		
		partial void OnLastMeetingDateChanging(DateTime? value);
		partial void OnLastMeetingDateChanged();
		
		partial void OnOrganizationClosedDateChanging(DateTime? value);
		partial void OnOrganizationClosedDateChanged();
		
		partial void OnLocationChanging(string value);
		partial void OnLocationChanged();
		
		partial void OnOrganizationNameChanging(string value);
		partial void OnOrganizationNameChanged();
		
		partial void OnModifiedByChanging(int? value);
		partial void OnModifiedByChanged();
		
		partial void OnModifiedDateChanging(DateTime? value);
		partial void OnModifiedDateChanged();
		
		partial void OnScheduleIdChanging(int? value);
		partial void OnScheduleIdChanged();
		
		partial void OnEntryPointIdChanging(int? value);
		partial void OnEntryPointIdChanged();
		
		partial void OnParentOrgIdChanging(int? value);
		partial void OnParentOrgIdChanged();
		
		partial void OnAllowAttendOverlapChanging(bool value);
		partial void OnAllowAttendOverlapChanged();
		
		partial void OnMemberCountChanging(int? value);
		partial void OnMemberCountChanged();
		
		partial void OnLeaderIdChanging(int? value);
		partial void OnLeaderIdChanged();
		
		partial void OnLeaderNameChanging(string value);
		partial void OnLeaderNameChanged();
		
		partial void OnClassFilledChanging(bool? value);
		partial void OnClassFilledChanged();
		
		partial void OnOnLineCatalogSortChanging(int? value);
		partial void OnOnLineCatalogSortChanged();
		
		partial void OnPendingLocChanging(string value);
		partial void OnPendingLocChanged();
		
		partial void OnCanSelfCheckinChanging(bool? value);
		partial void OnCanSelfCheckinChanged();
		
		partial void OnNumCheckInLabelsChanging(int? value);
		partial void OnNumCheckInLabelsChanged();
		
		partial void OnCampusIdChanging(int? value);
		partial void OnCampusIdChanged();
		
		partial void OnAllowNonCampusCheckInChanging(bool? value);
		partial void OnAllowNonCampusCheckInChanged();
		
		partial void OnNumWorkerCheckInLabelsChanging(int? value);
		partial void OnNumWorkerCheckInLabelsChanged();
		
		partial void OnSchedTimeChanging(DateTime? value);
		partial void OnSchedTimeChanged();
		
		partial void OnSchedDayChanging(int? value);
		partial void OnSchedDayChanged();
		
		partial void OnMeetingTimeChanging(DateTime? value);
		partial void OnMeetingTimeChanged();
		
    #endregion
		public Organization()
		{
			
			this._ChildOrgs = new EntitySet< Organization>(new Action< Organization>(this.attach_ChildOrgs), new Action< Organization>(this.detach_ChildOrgs)); 
			
			this._EnrollmentTransactions = new EntitySet< EnrollmentTransaction>(new Action< EnrollmentTransaction>(this.attach_EnrollmentTransactions), new Action< EnrollmentTransaction>(this.detach_EnrollmentTransactions)); 
			
			this._Attends = new EntitySet< Attend>(new Action< Attend>(this.attach_Attends), new Action< Attend>(this.detach_Attends)); 
			
			this._BadETs = new EntitySet< BadET>(new Action< BadET>(this.attach_BadETs), new Action< BadET>(this.detach_BadETs)); 
			
			this._CheckInTimes = new EntitySet< CheckInTime>(new Action< CheckInTime>(this.attach_CheckInTimes), new Action< CheckInTime>(this.detach_CheckInTimes)); 
			
			this._DivOrgs = new EntitySet< DivOrg>(new Action< DivOrg>(this.attach_DivOrgs), new Action< DivOrg>(this.detach_DivOrgs)); 
			
			this._LoveRespects = new EntitySet< LoveRespect>(new Action< LoveRespect>(this.attach_LoveRespects), new Action< LoveRespect>(this.detach_LoveRespects)); 
			
			this._Meetings = new EntitySet< Meeting>(new Action< Meeting>(this.attach_Meetings), new Action< Meeting>(this.detach_Meetings)); 
			
			this._MemberTags = new EntitySet< MemberTag>(new Action< MemberTag>(this.attach_MemberTags), new Action< MemberTag>(this.detach_MemberTags)); 
			
			this._RecRegs = new EntitySet< RecReg>(new Action< RecReg>(this.attach_RecRegs), new Action< RecReg>(this.detach_RecRegs)); 
			
			this._RecAgeDivisions = new EntitySet< RecAgeDivision>(new Action< RecAgeDivision>(this.attach_RecAgeDivisions), new Action< RecAgeDivision>(this.detach_RecAgeDivisions)); 
			
			this._OrganizationMembers = new EntitySet< OrganizationMember>(new Action< OrganizationMember>(this.attach_OrganizationMembers), new Action< OrganizationMember>(this.detach_OrganizationMembers)); 
			
			
			this._ParentOrg = default(EntityRef< Organization>); 
			
			this._Campu = default(EntityRef< Campu>); 
			
			this._Division = default(EntityRef< Division>); 
			
			this._AttendTrackLevel = default(EntityRef< AttendTrackLevel>); 
			
			this._EntryPoint = default(EntityRef< EntryPoint>); 
			
			this._OrganizationStatus = default(EntityRef< OrganizationStatus>); 
			
			OnCreated();
		}

		
    #region Columns
		
		[Column(Name="OrganizationId", UpdateCheck=UpdateCheck.Never, Storage="_OrganizationId", AutoSync=AutoSync.OnInsert, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrganizationId
		{
			get { return this._OrganizationId; }

			set
			{
				if (this._OrganizationId != value)
				{
				
                    this.OnOrganizationIdChanging(value);
					this.SendPropertyChanging();
					this._OrganizationId = value;
					this.SendPropertyChanged("OrganizationId");
					this.OnOrganizationIdChanged();
				}

			}

		}

		
		[Column(Name="CreatedBy", UpdateCheck=UpdateCheck.Never, Storage="_CreatedBy", DbType="int NOT NULL")]
		public int CreatedBy
		{
			get { return this._CreatedBy; }

			set
			{
				if (this._CreatedBy != value)
				{
				
                    this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}

			}

		}

		
		[Column(Name="CreatedDate", UpdateCheck=UpdateCheck.Never, Storage="_CreatedDate", DbType="datetime NOT NULL")]
		public DateTime CreatedDate
		{
			get { return this._CreatedDate; }

			set
			{
				if (this._CreatedDate != value)
				{
				
                    this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}

			}

		}

		
		[Column(Name="OrganizationStatusId", UpdateCheck=UpdateCheck.Never, Storage="_OrganizationStatusId", DbType="int NOT NULL")]
		public int OrganizationStatusId
		{
			get { return this._OrganizationStatusId; }

			set
			{
				if (this._OrganizationStatusId != value)
				{
				
					if (this._OrganizationStatus.HasLoadedOrAssignedValue)
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				
                    this.OnOrganizationStatusIdChanging(value);
					this.SendPropertyChanging();
					this._OrganizationStatusId = value;
					this.SendPropertyChanged("OrganizationStatusId");
					this.OnOrganizationStatusIdChanged();
				}

			}

		}

		
		[Column(Name="DivisionId", UpdateCheck=UpdateCheck.Never, Storage="_DivisionId", DbType="int")]
		public int? DivisionId
		{
			get { return this._DivisionId; }

			set
			{
				if (this._DivisionId != value)
				{
				
					if (this._Division.HasLoadedOrAssignedValue)
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				
                    this.OnDivisionIdChanging(value);
					this.SendPropertyChanging();
					this._DivisionId = value;
					this.SendPropertyChanged("DivisionId");
					this.OnDivisionIdChanged();
				}

			}

		}

		
		[Column(Name="LeaderMemberTypeId", UpdateCheck=UpdateCheck.Never, Storage="_LeaderMemberTypeId", DbType="int")]
		public int? LeaderMemberTypeId
		{
			get { return this._LeaderMemberTypeId; }

			set
			{
				if (this._LeaderMemberTypeId != value)
				{
				
                    this.OnLeaderMemberTypeIdChanging(value);
					this.SendPropertyChanging();
					this._LeaderMemberTypeId = value;
					this.SendPropertyChanged("LeaderMemberTypeId");
					this.OnLeaderMemberTypeIdChanged();
				}

			}

		}

		
		[Column(Name="GradeRangeStart", UpdateCheck=UpdateCheck.Never, Storage="_GradeRangeStart", DbType="int")]
		public int? GradeRangeStart
		{
			get { return this._GradeRangeStart; }

			set
			{
				if (this._GradeRangeStart != value)
				{
				
                    this.OnGradeRangeStartChanging(value);
					this.SendPropertyChanging();
					this._GradeRangeStart = value;
					this.SendPropertyChanged("GradeRangeStart");
					this.OnGradeRangeStartChanged();
				}

			}

		}

		
		[Column(Name="GradeRangeEnd", UpdateCheck=UpdateCheck.Never, Storage="_GradeRangeEnd", DbType="int")]
		public int? GradeRangeEnd
		{
			get { return this._GradeRangeEnd; }

			set
			{
				if (this._GradeRangeEnd != value)
				{
				
                    this.OnGradeRangeEndChanging(value);
					this.SendPropertyChanging();
					this._GradeRangeEnd = value;
					this.SendPropertyChanged("GradeRangeEnd");
					this.OnGradeRangeEndChanged();
				}

			}

		}

		
		[Column(Name="RollSheetVisitorWks", UpdateCheck=UpdateCheck.Never, Storage="_RollSheetVisitorWks", DbType="int")]
		public int? RollSheetVisitorWks
		{
			get { return this._RollSheetVisitorWks; }

			set
			{
				if (this._RollSheetVisitorWks != value)
				{
				
                    this.OnRollSheetVisitorWksChanging(value);
					this.SendPropertyChanging();
					this._RollSheetVisitorWks = value;
					this.SendPropertyChanged("RollSheetVisitorWks");
					this.OnRollSheetVisitorWksChanged();
				}

			}

		}

		
		[Column(Name="AttendTrkLevelId", UpdateCheck=UpdateCheck.Never, Storage="_AttendTrkLevelId", DbType="int NOT NULL")]
		public int AttendTrkLevelId
		{
			get { return this._AttendTrkLevelId; }

			set
			{
				if (this._AttendTrkLevelId != value)
				{
				
					if (this._AttendTrackLevel.HasLoadedOrAssignedValue)
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				
                    this.OnAttendTrkLevelIdChanging(value);
					this.SendPropertyChanging();
					this._AttendTrkLevelId = value;
					this.SendPropertyChanged("AttendTrkLevelId");
					this.OnAttendTrkLevelIdChanged();
				}

			}

		}

		
		[Column(Name="SecurityTypeId", UpdateCheck=UpdateCheck.Never, Storage="_SecurityTypeId", DbType="int NOT NULL")]
		public int SecurityTypeId
		{
			get { return this._SecurityTypeId; }

			set
			{
				if (this._SecurityTypeId != value)
				{
				
                    this.OnSecurityTypeIdChanging(value);
					this.SendPropertyChanging();
					this._SecurityTypeId = value;
					this.SendPropertyChanged("SecurityTypeId");
					this.OnSecurityTypeIdChanged();
				}

			}

		}

		
		[Column(Name="AttendClassificationId", UpdateCheck=UpdateCheck.Never, Storage="_AttendClassificationId", DbType="int NOT NULL")]
		public int AttendClassificationId
		{
			get { return this._AttendClassificationId; }

			set
			{
				if (this._AttendClassificationId != value)
				{
				
                    this.OnAttendClassificationIdChanging(value);
					this.SendPropertyChanging();
					this._AttendClassificationId = value;
					this.SendPropertyChanged("AttendClassificationId");
					this.OnAttendClassificationIdChanged();
				}

			}

		}

		
		[Column(Name="FirstMeetingDate", UpdateCheck=UpdateCheck.Never, Storage="_FirstMeetingDate", DbType="datetime")]
		public DateTime? FirstMeetingDate
		{
			get { return this._FirstMeetingDate; }

			set
			{
				if (this._FirstMeetingDate != value)
				{
				
                    this.OnFirstMeetingDateChanging(value);
					this.SendPropertyChanging();
					this._FirstMeetingDate = value;
					this.SendPropertyChanged("FirstMeetingDate");
					this.OnFirstMeetingDateChanged();
				}

			}

		}

		
		[Column(Name="LastMeetingDate", UpdateCheck=UpdateCheck.Never, Storage="_LastMeetingDate", DbType="datetime")]
		public DateTime? LastMeetingDate
		{
			get { return this._LastMeetingDate; }

			set
			{
				if (this._LastMeetingDate != value)
				{
				
                    this.OnLastMeetingDateChanging(value);
					this.SendPropertyChanging();
					this._LastMeetingDate = value;
					this.SendPropertyChanged("LastMeetingDate");
					this.OnLastMeetingDateChanged();
				}

			}

		}

		
		[Column(Name="OrganizationClosedDate", UpdateCheck=UpdateCheck.Never, Storage="_OrganizationClosedDate", DbType="datetime")]
		public DateTime? OrganizationClosedDate
		{
			get { return this._OrganizationClosedDate; }

			set
			{
				if (this._OrganizationClosedDate != value)
				{
				
                    this.OnOrganizationClosedDateChanging(value);
					this.SendPropertyChanging();
					this._OrganizationClosedDate = value;
					this.SendPropertyChanged("OrganizationClosedDate");
					this.OnOrganizationClosedDateChanged();
				}

			}

		}

		
		[Column(Name="Location", UpdateCheck=UpdateCheck.Never, Storage="_Location", DbType="varchar(40)")]
		public string Location
		{
			get { return this._Location; }

			set
			{
				if (this._Location != value)
				{
				
                    this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}

			}

		}

		
		[Column(Name="OrganizationName", UpdateCheck=UpdateCheck.Never, Storage="_OrganizationName", DbType="varchar(60) NOT NULL")]
		public string OrganizationName
		{
			get { return this._OrganizationName; }

			set
			{
				if (this._OrganizationName != value)
				{
				
                    this.OnOrganizationNameChanging(value);
					this.SendPropertyChanging();
					this._OrganizationName = value;
					this.SendPropertyChanged("OrganizationName");
					this.OnOrganizationNameChanged();
				}

			}

		}

		
		[Column(Name="ModifiedBy", UpdateCheck=UpdateCheck.Never, Storage="_ModifiedBy", DbType="int")]
		public int? ModifiedBy
		{
			get { return this._ModifiedBy; }

			set
			{
				if (this._ModifiedBy != value)
				{
				
                    this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
				}

			}

		}

		
		[Column(Name="ModifiedDate", UpdateCheck=UpdateCheck.Never, Storage="_ModifiedDate", DbType="datetime")]
		public DateTime? ModifiedDate
		{
			get { return this._ModifiedDate; }

			set
			{
				if (this._ModifiedDate != value)
				{
				
                    this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}

			}

		}

		
		[Column(Name="ScheduleId", UpdateCheck=UpdateCheck.Never, Storage="_ScheduleId", DbType="int")]
		public int? ScheduleId
		{
			get { return this._ScheduleId; }

			set
			{
				if (this._ScheduleId != value)
				{
				
                    this.OnScheduleIdChanging(value);
					this.SendPropertyChanging();
					this._ScheduleId = value;
					this.SendPropertyChanged("ScheduleId");
					this.OnScheduleIdChanged();
				}

			}

		}

		
		[Column(Name="EntryPointId", UpdateCheck=UpdateCheck.Never, Storage="_EntryPointId", DbType="int")]
		public int? EntryPointId
		{
			get { return this._EntryPointId; }

			set
			{
				if (this._EntryPointId != value)
				{
				
					if (this._EntryPoint.HasLoadedOrAssignedValue)
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				
                    this.OnEntryPointIdChanging(value);
					this.SendPropertyChanging();
					this._EntryPointId = value;
					this.SendPropertyChanged("EntryPointId");
					this.OnEntryPointIdChanged();
				}

			}

		}

		
		[Column(Name="ParentOrgId", UpdateCheck=UpdateCheck.Never, Storage="_ParentOrgId", DbType="int")]
		public int? ParentOrgId
		{
			get { return this._ParentOrgId; }

			set
			{
				if (this._ParentOrgId != value)
				{
				
					if (this._ParentOrg.HasLoadedOrAssignedValue)
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				
                    this.OnParentOrgIdChanging(value);
					this.SendPropertyChanging();
					this._ParentOrgId = value;
					this.SendPropertyChanged("ParentOrgId");
					this.OnParentOrgIdChanged();
				}

			}

		}

		
		[Column(Name="AllowAttendOverlap", UpdateCheck=UpdateCheck.Never, Storage="_AllowAttendOverlap", DbType="bit NOT NULL")]
		public bool AllowAttendOverlap
		{
			get { return this._AllowAttendOverlap; }

			set
			{
				if (this._AllowAttendOverlap != value)
				{
				
                    this.OnAllowAttendOverlapChanging(value);
					this.SendPropertyChanging();
					this._AllowAttendOverlap = value;
					this.SendPropertyChanged("AllowAttendOverlap");
					this.OnAllowAttendOverlapChanged();
				}

			}

		}

		
		[Column(Name="MemberCount", UpdateCheck=UpdateCheck.Never, Storage="_MemberCount", DbType="int", IsDbGenerated=true)]
		public int? MemberCount
		{
			get { return this._MemberCount; }

			set
			{
				if (this._MemberCount != value)
				{
				
                    this.OnMemberCountChanging(value);
					this.SendPropertyChanging();
					this._MemberCount = value;
					this.SendPropertyChanged("MemberCount");
					this.OnMemberCountChanged();
				}

			}

		}

		
		[Column(Name="LeaderId", UpdateCheck=UpdateCheck.Never, Storage="_LeaderId", DbType="int", IsDbGenerated=true)]
		public int? LeaderId
		{
			get { return this._LeaderId; }

			set
			{
				if (this._LeaderId != value)
				{
				
                    this.OnLeaderIdChanging(value);
					this.SendPropertyChanging();
					this._LeaderId = value;
					this.SendPropertyChanged("LeaderId");
					this.OnLeaderIdChanged();
				}

			}

		}

		
		[Column(Name="LeaderName", UpdateCheck=UpdateCheck.Never, Storage="_LeaderName", DbType="varchar(100)", IsDbGenerated=true)]
		public string LeaderName
		{
			get { return this._LeaderName; }

			set
			{
				if (this._LeaderName != value)
				{
				
                    this.OnLeaderNameChanging(value);
					this.SendPropertyChanging();
					this._LeaderName = value;
					this.SendPropertyChanged("LeaderName");
					this.OnLeaderNameChanged();
				}

			}

		}

		
		[Column(Name="ClassFilled", UpdateCheck=UpdateCheck.Never, Storage="_ClassFilled", DbType="bit")]
		public bool? ClassFilled
		{
			get { return this._ClassFilled; }

			set
			{
				if (this._ClassFilled != value)
				{
				
                    this.OnClassFilledChanging(value);
					this.SendPropertyChanging();
					this._ClassFilled = value;
					this.SendPropertyChanged("ClassFilled");
					this.OnClassFilledChanged();
				}

			}

		}

		
		[Column(Name="OnLineCatalogSort", UpdateCheck=UpdateCheck.Never, Storage="_OnLineCatalogSort", DbType="int")]
		public int? OnLineCatalogSort
		{
			get { return this._OnLineCatalogSort; }

			set
			{
				if (this._OnLineCatalogSort != value)
				{
				
                    this.OnOnLineCatalogSortChanging(value);
					this.SendPropertyChanging();
					this._OnLineCatalogSort = value;
					this.SendPropertyChanged("OnLineCatalogSort");
					this.OnOnLineCatalogSortChanged();
				}

			}

		}

		
		[Column(Name="PendingLoc", UpdateCheck=UpdateCheck.Never, Storage="_PendingLoc", DbType="varchar(40)")]
		public string PendingLoc
		{
			get { return this._PendingLoc; }

			set
			{
				if (this._PendingLoc != value)
				{
				
                    this.OnPendingLocChanging(value);
					this.SendPropertyChanging();
					this._PendingLoc = value;
					this.SendPropertyChanged("PendingLoc");
					this.OnPendingLocChanged();
				}

			}

		}

		
		[Column(Name="CanSelfCheckin", UpdateCheck=UpdateCheck.Never, Storage="_CanSelfCheckin", DbType="bit")]
		public bool? CanSelfCheckin
		{
			get { return this._CanSelfCheckin; }

			set
			{
				if (this._CanSelfCheckin != value)
				{
				
                    this.OnCanSelfCheckinChanging(value);
					this.SendPropertyChanging();
					this._CanSelfCheckin = value;
					this.SendPropertyChanged("CanSelfCheckin");
					this.OnCanSelfCheckinChanged();
				}

			}

		}

		
		[Column(Name="NumCheckInLabels", UpdateCheck=UpdateCheck.Never, Storage="_NumCheckInLabels", DbType="int")]
		public int? NumCheckInLabels
		{
			get { return this._NumCheckInLabels; }

			set
			{
				if (this._NumCheckInLabels != value)
				{
				
                    this.OnNumCheckInLabelsChanging(value);
					this.SendPropertyChanging();
					this._NumCheckInLabels = value;
					this.SendPropertyChanged("NumCheckInLabels");
					this.OnNumCheckInLabelsChanged();
				}

			}

		}

		
		[Column(Name="CampusId", UpdateCheck=UpdateCheck.Never, Storage="_CampusId", DbType="int")]
		public int? CampusId
		{
			get { return this._CampusId; }

			set
			{
				if (this._CampusId != value)
				{
				
					if (this._Campu.HasLoadedOrAssignedValue)
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				
                    this.OnCampusIdChanging(value);
					this.SendPropertyChanging();
					this._CampusId = value;
					this.SendPropertyChanged("CampusId");
					this.OnCampusIdChanged();
				}

			}

		}

		
		[Column(Name="AllowNonCampusCheckIn", UpdateCheck=UpdateCheck.Never, Storage="_AllowNonCampusCheckIn", DbType="bit")]
		public bool? AllowNonCampusCheckIn
		{
			get { return this._AllowNonCampusCheckIn; }

			set
			{
				if (this._AllowNonCampusCheckIn != value)
				{
				
                    this.OnAllowNonCampusCheckInChanging(value);
					this.SendPropertyChanging();
					this._AllowNonCampusCheckIn = value;
					this.SendPropertyChanged("AllowNonCampusCheckIn");
					this.OnAllowNonCampusCheckInChanged();
				}

			}

		}

		
		[Column(Name="NumWorkerCheckInLabels", UpdateCheck=UpdateCheck.Never, Storage="_NumWorkerCheckInLabels", DbType="int")]
		public int? NumWorkerCheckInLabels
		{
			get { return this._NumWorkerCheckInLabels; }

			set
			{
				if (this._NumWorkerCheckInLabels != value)
				{
				
                    this.OnNumWorkerCheckInLabelsChanging(value);
					this.SendPropertyChanging();
					this._NumWorkerCheckInLabels = value;
					this.SendPropertyChanged("NumWorkerCheckInLabels");
					this.OnNumWorkerCheckInLabelsChanged();
				}

			}

		}

		
		[Column(Name="SchedTime", UpdateCheck=UpdateCheck.Never, Storage="_SchedTime", DbType="datetime")]
		public DateTime? SchedTime
		{
			get { return this._SchedTime; }

			set
			{
				if (this._SchedTime != value)
				{
				
                    this.OnSchedTimeChanging(value);
					this.SendPropertyChanging();
					this._SchedTime = value;
					this.SendPropertyChanged("SchedTime");
					this.OnSchedTimeChanged();
				}

			}

		}

		
		[Column(Name="SchedDay", UpdateCheck=UpdateCheck.Never, Storage="_SchedDay", DbType="int")]
		public int? SchedDay
		{
			get { return this._SchedDay; }

			set
			{
				if (this._SchedDay != value)
				{
				
                    this.OnSchedDayChanging(value);
					this.SendPropertyChanging();
					this._SchedDay = value;
					this.SendPropertyChanged("SchedDay");
					this.OnSchedDayChanged();
				}

			}

		}

		
		[Column(Name="MeetingTime", UpdateCheck=UpdateCheck.Never, Storage="_MeetingTime", DbType="datetime")]
		public DateTime? MeetingTime
		{
			get { return this._MeetingTime; }

			set
			{
				if (this._MeetingTime != value)
				{
				
                    this.OnMeetingTimeChanging(value);
					this.SendPropertyChanging();
					this._MeetingTime = value;
					this.SendPropertyChanged("MeetingTime");
					this.OnMeetingTimeChanged();
				}

			}

		}

		
    #endregion
        
    #region Foreign Key Tables
   		
   		[Association(Name="ChildOrgs__ParentOrg", Storage="_ChildOrgs", OtherKey="ParentOrgId")]
   		public EntitySet< Organization> ChildOrgs
   		{
   		    get { return this._ChildOrgs; }

			set	{ this._ChildOrgs.Assign(value); }

   		}

		
   		[Association(Name="ENROLLMENT_TRANSACTION_ORG_FK", Storage="_EnrollmentTransactions", OtherKey="OrganizationId")]
   		public EntitySet< EnrollmentTransaction> EnrollmentTransactions
   		{
   		    get { return this._EnrollmentTransactions; }

			set	{ this._EnrollmentTransactions.Assign(value); }

   		}

		
   		[Association(Name="FK_AttendWithAbsents_TBL_ORGANIZATIONS_TBL", Storage="_Attends", OtherKey="OrganizationId")]
   		public EntitySet< Attend> Attends
   		{
   		    get { return this._Attends; }

			set	{ this._Attends.Assign(value); }

   		}

		
   		[Association(Name="FK_BadET_Organizations", Storage="_BadETs", OtherKey="OrgId")]
   		public EntitySet< BadET> BadETs
   		{
   		    get { return this._BadETs; }

			set	{ this._BadETs.Assign(value); }

   		}

		
   		[Association(Name="FK_CheckInTimes_Organizations", Storage="_CheckInTimes", OtherKey="OrganizationId")]
   		public EntitySet< CheckInTime> CheckInTimes
   		{
   		    get { return this._CheckInTimes; }

			set	{ this._CheckInTimes.Assign(value); }

   		}

		
   		[Association(Name="FK_DivOrg_Organizations", Storage="_DivOrgs", OtherKey="OrgId")]
   		public EntitySet< DivOrg> DivOrgs
   		{
   		    get { return this._DivOrgs; }

			set	{ this._DivOrgs.Assign(value); }

   		}

		
   		[Association(Name="FK_LoveRespect_Organizations", Storage="_LoveRespects", OtherKey="OrgId")]
   		public EntitySet< LoveRespect> LoveRespects
   		{
   		    get { return this._LoveRespects; }

			set	{ this._LoveRespects.Assign(value); }

   		}

		
   		[Association(Name="FK_MEETINGS_TBL_ORGANIZATIONS_TBL", Storage="_Meetings", OtherKey="OrganizationId")]
   		public EntitySet< Meeting> Meetings
   		{
   		    get { return this._Meetings; }

			set	{ this._Meetings.Assign(value); }

   		}

		
   		[Association(Name="FK_MemberTags_Organizations", Storage="_MemberTags", OtherKey="OrgId")]
   		public EntitySet< MemberTag> MemberTags
   		{
   		    get { return this._MemberTags; }

			set	{ this._MemberTags.Assign(value); }

   		}

		
   		[Association(Name="FK_Participant_Organizations", Storage="_RecRegs", OtherKey="OrgId")]
   		public EntitySet< RecReg> RecRegs
   		{
   		    get { return this._RecRegs; }

			set	{ this._RecRegs.Assign(value); }

   		}

		
   		[Association(Name="FK_Recreation_Organizations", Storage="_RecAgeDivisions", OtherKey="OrgId")]
   		public EntitySet< RecAgeDivision> RecAgeDivisions
   		{
   		    get { return this._RecAgeDivisions; }

			set	{ this._RecAgeDivisions.Assign(value); }

   		}

		
   		[Association(Name="ORGANIZATION_MEMBERS_ORG_FK", Storage="_OrganizationMembers", OtherKey="OrganizationId")]
   		public EntitySet< OrganizationMember> OrganizationMembers
   		{
   		    get { return this._OrganizationMembers; }

			set	{ this._OrganizationMembers.Assign(value); }

   		}

		
	#endregion
	
	#region Foreign Keys
    	
		[Association(Name="ChildOrgs__ParentOrg", Storage="_ParentOrg", ThisKey="ParentOrgId", IsForeignKey=true)]
		public Organization ParentOrg
		{
			get { return this._ParentOrg.Entity; }

			set
			{
				Organization previousValue = this._ParentOrg.Entity;
				if (((previousValue != value) 
							|| (this._ParentOrg.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if (previousValue != null)
					{
						this._ParentOrg.Entity = null;
						previousValue.ChildOrgs.Remove(this);
					}

					this._ParentOrg.Entity = value;
					if (value != null)
					{
						value.ChildOrgs.Add(this);
						
						this._ParentOrgId = value.OrganizationId;
						
					}

					else
					{
						
						this._ParentOrgId = default(int?);
						
					}

					this.SendPropertyChanged("ParentOrg");
				}

			}

		}

		
		[Association(Name="FK_Organizations_Campus", Storage="_Campu", ThisKey="CampusId", IsForeignKey=true)]
		public Campu Campu
		{
			get { return this._Campu.Entity; }

			set
			{
				Campu previousValue = this._Campu.Entity;
				if (((previousValue != value) 
							|| (this._Campu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if (previousValue != null)
					{
						this._Campu.Entity = null;
						previousValue.Organizations.Remove(this);
					}

					this._Campu.Entity = value;
					if (value != null)
					{
						value.Organizations.Add(this);
						
						this._CampusId = value.Id;
						
					}

					else
					{
						
						this._CampusId = default(int?);
						
					}

					this.SendPropertyChanged("Campu");
				}

			}

		}

		
		[Association(Name="FK_Organizations_Division", Storage="_Division", ThisKey="DivisionId", IsForeignKey=true)]
		public Division Division
		{
			get { return this._Division.Entity; }

			set
			{
				Division previousValue = this._Division.Entity;
				if (((previousValue != value) 
							|| (this._Division.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if (previousValue != null)
					{
						this._Division.Entity = null;
						previousValue.Organizations.Remove(this);
					}

					this._Division.Entity = value;
					if (value != null)
					{
						value.Organizations.Add(this);
						
						this._DivisionId = value.Id;
						
					}

					else
					{
						
						this._DivisionId = default(int?);
						
					}

					this.SendPropertyChanged("Division");
				}

			}

		}

		
		[Association(Name="FK_ORGANIZATIONS_TBL_AttendTrackLevel", Storage="_AttendTrackLevel", ThisKey="AttendTrkLevelId", IsForeignKey=true)]
		public AttendTrackLevel AttendTrackLevel
		{
			get { return this._AttendTrackLevel.Entity; }

			set
			{
				AttendTrackLevel previousValue = this._AttendTrackLevel.Entity;
				if (((previousValue != value) 
							|| (this._AttendTrackLevel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if (previousValue != null)
					{
						this._AttendTrackLevel.Entity = null;
						previousValue.Organizations.Remove(this);
					}

					this._AttendTrackLevel.Entity = value;
					if (value != null)
					{
						value.Organizations.Add(this);
						
						this._AttendTrkLevelId = value.Id;
						
					}

					else
					{
						
						this._AttendTrkLevelId = default(int);
						
					}

					this.SendPropertyChanged("AttendTrackLevel");
				}

			}

		}

		
		[Association(Name="FK_ORGANIZATIONS_TBL_EntryPoint", Storage="_EntryPoint", ThisKey="EntryPointId", IsForeignKey=true)]
		public EntryPoint EntryPoint
		{
			get { return this._EntryPoint.Entity; }

			set
			{
				EntryPoint previousValue = this._EntryPoint.Entity;
				if (((previousValue != value) 
							|| (this._EntryPoint.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if (previousValue != null)
					{
						this._EntryPoint.Entity = null;
						previousValue.Organizations.Remove(this);
					}

					this._EntryPoint.Entity = value;
					if (value != null)
					{
						value.Organizations.Add(this);
						
						this._EntryPointId = value.Id;
						
					}

					else
					{
						
						this._EntryPointId = default(int?);
						
					}

					this.SendPropertyChanged("EntryPoint");
				}

			}

		}

		
		[Association(Name="FK_ORGANIZATIONS_TBL_OrganizationStatus", Storage="_OrganizationStatus", ThisKey="OrganizationStatusId", IsForeignKey=true)]
		public OrganizationStatus OrganizationStatus
		{
			get { return this._OrganizationStatus.Entity; }

			set
			{
				OrganizationStatus previousValue = this._OrganizationStatus.Entity;
				if (((previousValue != value) 
							|| (this._OrganizationStatus.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if (previousValue != null)
					{
						this._OrganizationStatus.Entity = null;
						previousValue.Organizations.Remove(this);
					}

					this._OrganizationStatus.Entity = value;
					if (value != null)
					{
						value.Organizations.Add(this);
						
						this._OrganizationStatusId = value.Id;
						
					}

					else
					{
						
						this._OrganizationStatusId = default(int);
						
					}

					this.SendPropertyChanged("OrganizationStatus");
				}

			}

		}

		
	#endregion
	
		public event PropertyChangingEventHandler PropertyChanging;
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
				this.PropertyChanging(this, emptyChangingEventArgs);
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

   		
		private void attach_ChildOrgs(Organization entity)
		{
			this.SendPropertyChanging();
			entity.ParentOrg = this;
		}

		private void detach_ChildOrgs(Organization entity)
		{
			this.SendPropertyChanging();
			entity.ParentOrg = null;
		}

		
		private void attach_EnrollmentTransactions(EnrollmentTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_EnrollmentTransactions(EnrollmentTransaction entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_Attends(Attend entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_Attends(Attend entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_BadETs(BadET entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_BadETs(BadET entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_CheckInTimes(CheckInTime entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_CheckInTimes(CheckInTime entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_DivOrgs(DivOrg entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_DivOrgs(DivOrg entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_LoveRespects(LoveRespect entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_LoveRespects(LoveRespect entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_Meetings(Meeting entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_Meetings(Meeting entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_MemberTags(MemberTag entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_MemberTags(MemberTag entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_RecRegs(RecReg entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_RecRegs(RecReg entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_RecAgeDivisions(RecAgeDivision entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_RecAgeDivisions(RecAgeDivision entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
		private void attach_OrganizationMembers(OrganizationMember entity)
		{
			this.SendPropertyChanging();
			entity.Organization = this;
		}

		private void detach_OrganizationMembers(OrganizationMember entity)
		{
			this.SendPropertyChanging();
			entity.Organization = null;
		}

		
	}

}

