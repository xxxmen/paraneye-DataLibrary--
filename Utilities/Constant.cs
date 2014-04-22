using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element.Reveal.DataLibrary.Utilities
{    
    public sealed class HashKey
    {
        public const string Key_DrawingList = "E_I_S_Drawing";
    }

    public sealed class DrawingMode
    {
        public const int Pen = 0;
        public const int Text = 1;
        public const int Rectangle = 2;
        public const int Ellipse = 3;
    }

    public enum DrawingEditMode : int
    {
        RFI = 0,
        MarkUp = 1
    }

    public sealed class TableName
    {
        public const string Area = "area";
        public const string Calendar = "calendar";
        public const string Company = "company";
        public const string Component = "component";
        public const string Componentlog = "componentlog";
        public const string Connector = "connector";
        public const string Contcostcode = "contcostcode";
        public const string ContProject = "contProject";
        public const string Costcode = "costcode";
        public const string Costcodelocked = "costcodelocked";
        public const string Costcodestructure = "costcodestructure";
        public const string Costcodetale = "costcodetale";
        public const string Country = "country";
        public const string Cwa = "cwa";
        public const string Cwp = "cwp";
        public const string Dailybrass = "dailybrass";
        public const string Dailybrasssign = "dailybrasssign";
        public const string Dailytoolbox = "dailytoolbox";
        public const string Dailytimesheet = "dailytimesheet";
        public const string Department = "department";
        public const string Departstructure = "departstructure";
        public const string Document = "document";
        public const string DocumentNote = "documentnote";
        public const string Documentmarkup = "documentmarkup";
        public const string Documentmarkupmto = "documentmarkupmto";
        public const string Drawing = "drawing";
        public const string Drawingcwp = "drawingcwp";
        public const string Drawingreference = "drawingreference";
        public const string Drawingrevision = "drawingrevision";
        public const string Drawingsdref = "drawingsdref";
        public const string Drawingtype = "drawingtype";
        public const string Ehtmaterial = "ehtmaterial";
        public const string Ehtprogress = "ehtprogress";
        public const string Empclass = "empclass";
        public const string Equipadditionalparameters = "equipadditionalparameters";
        public const string Equipment = "equipment";
        public const string FieldEquipment = "fieldequipment";
        public const string Ewr = "ewr";
        public const string FIWP = "fiwp";
        public const string Fiwpdocordinal = "fiwpdocordinal";
        public const string FIWPEquip = "fiwpequip";
        public const string FIWPManPower = "fiwpmanpower";
        public const string FIWPHistory = "fiwphistory";
        public const string HydroGroup = "hydrogroup";
        public const string FIWPWorkflow = "fiwpworkflow";
        public const string FiwpManOnSite = "Fiwpmanonsite";
        public const string FiwpMaterial = "Fiwpmaterial";
        public const string FiwpComment = "fiwpcomment";
        public const string FiwpQaqc = "fiwpqaqc";
        public const string FIWPWFP = "fiwpwfp";
        public const string Helpfile = "helpfile";
        public const string Holiday = "holiday";
        public const string HolidayOrException = "holidayorexception";
        public const string Importedfilename = "Importedfilename";
        public const string Libconsumable = "libconsumable";
        public const string Libcablemanhour = "libcablemanhour";
        public const string Libehtmanhour = "libehtmanhour";
        public const string Libequipmanhour = "libequipmanhour";
        public const string Libgroundinglocknut = "libgroundinglocknut";
        public const string Libinstrmanhour = "libinstrmanhour";
        public const string Libinsulfireproof = "libinsulfireproof";
        public const string Libinsulpipefactor = "libinsulpipefactor";
        public const string Libinsulpaintmanhour = "libinsulpaintmanhour";
        public const string Libinsulfactor = "libinsulfactor";
        public const string Liblightingmanhour = "liblightingmanhour";
        public const string Libqaqcformtemplate = "libqaqcformtemplate";
        public const string Libracewaymanhour = "libracewaymanhour";
        public const string Libpipemanhour = "libpipemanhour";
        public const string Libpipeclassmanhour = "libpipeclassmanhour";
        public const string Libpipematerialgrp = "libpipematerialgrp";
        public const string Libpipeschmanhour = "libpipeschmanhour";
        public const string Libpipesupmanhour = "libpipesupmanhour";
        public const string Libinsulpipemanhour = "libinsulpipemanhour";
        public const string Libhydromanhour = "libhydromanhour";
        public const string Libpipemanhourratio = "libpipemanhourratio";
        public const string Libscaffoldpart = "libscaffoldpart";
        public const string Loginaccount = "loginaccount";
        public const string Loginaccountmoduleusergroup = "loginaccountmoduleusergroup";
        public const string Lookup = "lookup";
        public const string Userlookup = "userlookup";
        public const string Materialcategory = "materialcategory";
        public const string Material = "material";
        public const string Materiallog = "materiallog";
        public const string Materiallist = "materiallist";
        public const string Module = "module";
        public const string Mtoissueconcernlog = "mtoissueconcernlog";
        public const string Page = "page";
        public const string Pageusergroup = "pageusergroup";
        public const string Personnel = "personnel";
        public const string Plant = "plant";
        public const string Po = "po";
        public const string Pohistory = "pohistory";
        public const string Polineitem = "polineitem";
        public const string Powerpointidrefdrawing = "powerpointidrefdrawing";
        public const string Powerpointidsplicebox = "powerpointidsplicebox";
        public const string Powerpointidtagname = "powerpointidtagname";
        public const string Progress = "progress";
        public const string Progresslog = "progresslog";
        public const string Progresshistory = "progresshistory";
        public const string Progressruleofcredit = "progressruleofcredit";
        public const string Project = "project";
        public const string ProjectFileInfo = "projectfileinfo";
        public const string ProjectContractor = "projectcontractor";
        public const string ProjectModule = "projectmodule";
        public const string Projectschedule = "projschedule";
        public const string ProjectscheduleHistory = "projschedulehistory";
        public const string ProjScheduleWorkflow = "projscheduleworkflow";
        public const string Provence = "provence";
        public const string Qaqcconfig = "qaqcconfig";
        public const string Qaqcform = "qaqcform";
        public const string QaqcformDetail = "qaqcformdetail";
        public const string Qaqcformtemplate = "qaqcformtemplate";
        public const string Qaqcformcomponent = "qaqcformcomponent";
        public const string Quantityservey = "quantityservey";
        public const string Racewaylocation = "racewaylocation";
        public const string Rate = "rate";
        public const string Rfi = "rfi";
        public const string RFIDrawing = "rfidrawing";
        public const string Ruleofcreditweight = "ruleofcreditweight";
        public const string Scaffold = "scaffold";
        public const string ScaffoldRequest = "scaffoldrequest";
        public const string ScaffoldRequestHistory = "scaffoldrequesthistory";
        public const string ScaffoldTrade = "scaffoldtrade";
        public const string Sd = "sd";
        public const string Sdmateriallist = "sdmateriallist";
        public const string Shift = "shift";
        public const string Skill = "skill";
        public const string SigmaCue = "sigmacue";
        public const string StandardWorkweek = "standardworkweek";
        public const string System = "system";
        public const string Tagnumberdrawing = "tagnumberdrawing";
        public const string Taskcategory = "taskcategory";
        public const string Task = "task";
        public const string Taskmaterialcategory = "taskmaterialcategory";
        public const string Timesheet = "timesheet";
        public const string TimesheetProgress = "timesheetprogress";
        public const string TimeAllocation = "timeallocation";
        public const string Toolboxsign = "toolboxsign";
        public const string TrackTimesheet = "tracktimesheet";
        public const string Turnover = "turnover";
        public const string Turnoverattendee = "turnoverattendee";
        public const string Uom = "uom";
        public const string Usergroup = "usergroup";
        public const string Weather = "weather";
        public const string Weekendholiday = "weekendholiday";
        public const string Workpackage = "workpackage";
        public const string Workpackagerfi = "workpackagerfi";
        public const string Workpackagestatus = "workpackagestatus";
        public const string Worktime = "worktime";
    }

    public sealed class DTOName
    {
        public const string Area = "AreaDTO";
        public const string Calendar = "CalendarDTO";
        public const string Company = "CompanyDTO";
        public const string Component = "ComponentDTO";
        public const string Componentlog = "ComponentlogDTO";
        public const string Connector = "ConnectorDTO";
        public const string Contcostcode = "ContcostcodeDTO";
        public const string ContProject = "ContProjectDTO";
        public const string Costcode = "CostcodeDTO";
        public const string Costcodelocked = "CostcodelockedDTO";
        public const string Costcodestructure = "CostcodestructureDTO";
        public const string Costcodetale = "CostcodetaleDTO";
        public const string Country = "CountryDTO";
        public const string Cwa = "CwaDTO";
        public const string Cwp = "CwpDTO";
        public const string Dailybrass = "DailybrassDTO";
        public const string Dailybrasssign = "DailybrasssignDTO";
        public const string Dailytimesheet = "DailytimesheetDTO";
        public const string Dailytoolbox = "DailytoolboxDTO";
        public const string Department = "DepartmentDTO";
        public const string Departstructure = "DepartstructureDTO";
        public const string Document = "DocumentDTO";
        public const string Documentmarkup = "DocumentmarkupDTO";
        public const string Documentmarkupmto = "DocumentmarkupmtoDTO";
        public const string Documentnote = "DocumentnoteDTO";
        public const string Drawing = "DrawingDTO";
        public const string Drawingcwp = "DrawingcwpDTO";
        public const string Drawingreference = "DrawingreferenceDTO";
        public const string Drawingrevision = "DrawingrevisionDTO";
        public const string Drawingsdref = "DrawingsdrefDTO";
        public const string Drawingtype = "DrawingtypeDTO";
        public const string Empclass = "EmpclassDTO";
        public const string Equipment = "EquipmentDTO";
        public const string Ewr = "EwrDTO";
        public const string FIWP = "FiwpDTO";
        public const string FieldEquipment = "FieldequipmentDTO";
        public const string FiwpComment = "FiwpcommentDTO";
        public const string Fiwpdocordinal = "fiwpdocordinal";
        public const string FiwpEquip = "FiwpequipDTO";
        public const string FIWPManPower = "FiwpmanpowerDTO";
        public const string FiwpMaterial = "FiwpmaterialDTO";
        public const string FIWPHistory = "FiwphistoryDTO";
        public const string FIWPWorkflow = "FiwpworkflowDTO";
        public const string FiwpManOnSite = "FiwpmanonsiteDTO";
        public const string FiwpQaqc = "FiwpqaqcDTO";
        public const string FIWPWFP = "FiwpwfpDTO";
        public const string Helpfile = "HelpfileDTO";
        public const string HolidayOrException = "HolidayorexceptionDTO";
        public const string Importedfilename = "ImportedfilenameDTO";
        public const string Libconsumable = "LibconsumableDTO";
        public const string Libcablemanhour = "LibcablemanhourDTO";
        public const string Libehtmanhour = "LibehtmanhourDTO";
        public const string Libequipmanhour = "LibequipmanhourDTO";
        public const string Libinstrmanhour = "LibinstrmanhourDTO";
        public const string Libinsulfireproof = "LibinsulfireproofDTO";
        public const string Libinsulpipefactor = "LibinsulpipefactorDTO";
        public const string Libinsulpaintmanhour = "LibinsulpaintmanhourDTO";
        public const string Libinsulfactor = "LibinsulfactorDTO";
        public const string Liblightingmanhour = "LiblightingmanhourDTO";
        public const string Libqaqcformtemplate = "LibqaqcformtemplateDTO";
        public const string Libracewaymanhour = "LibracewaymanhourDTO";
        public const string Libpipemanhour = "LibpipemanhourDTO";
        public const string Libpipeclassmanhour = "LibpipeclassmanhourDTO";
        public const string Libpipematerialgrp = "LibpipematerialgrpDTO";
        public const string Libpipeschmanhour = "LibpipeschmanhourDTO";
        public const string Libpipesupmanhour = "LibpipesupmanhourDTO";
        public const string Libpipemanhourratio = "LibpipemanhourratioDTO";
        public const string Libscaffoldpart = "LibscaffoldpartDTO";
        public const string Libhydromanhour = "LibhydromanhourDTO";
        public const string Libinsulpipemanhour = "LibinsulpipemanhourDTO";
        public const string Loginaccount = "LoginaccountDTO";
        public const string Loginaccountmoduleusergroup = "LoginaccountmoduleusergroupDTO";
        public const string Lookup = "LookupDTO";
        public const string Materialcategory = "MaterialcategoryDTO";
        public const string Material = "MaterialDTO";
        public const string Materiallog = "MateriallogDTO";
        public const string Materiallist = "MateriallistDTO";
        public const string Module = "ModuleDTO";
        public const string Mtoissueconcernlog = "MtoissueconcernlogDTO";
        public const string Page = "PageDTO";
        public const string Pageusergroup = "PageusergroupDTO";
        public const string Personnel = "PersonnelDTO";
        public const string Plant = "PlantDTO";
        public const string Po = "PoDTO";
        public const string Pohistory = "PohistoryDTO";
        public const string Polineitem = "PolineitemDTO";
        public const string Progress = "ProgressDTO";
        public const string Progresslog = "ProgresslogDTO";
        public const string ProgressMTO = "MTODTO";
        public const string Progressruleofcredit = "ProgressruleofcreditDTO";
        public const string Progresshistory = "ProgresshistoryDTO";
        public const string Project = "ProjectDTO";
        public const string ProjectFileInfo = "ProjectFileInfoDTO";
        public const string ProjectContractor = "ProjectcontractorDTO";
        public const string ProjectModule = "ProjectmoduleDTO";
        public const string Projectschedule = "ProjectscheduleDTO";
        public const string ProjectscheduleHistory = "ProjectscheduleHistoryDTO";
        public const string ProjScheduleWorkflow = "ProjScheduleWorkflowDTO";
        public const string Qaqcconfig = "QaqcconfigDTO";
        public const string Qaqcform = "QaqcformDTO";
        public const string QaqcformDetail = "QaqcformdetailDTO";
        public const string Qaqcformtemplate = "QaqcformtemplateDTO";
        public const string Qaqcformtracking = "QaqcformtrackingDTO";
        public const string Qaqcformcomponent = "QaqcformcomponentDTO";
        public const string Quantityservey = "QuantityserveyDTO";
        public const string Racewaylocation = "RacewaylocationDTO";
        public const string Rate = "RateDTO";
        public const string Rfi = "RfiDTO";
        public const string RFIDrawing = "RFIDrawingDTO";
        public const string Ruleofcreditweight = "RuleofcreditweightDTO";
        public const string Scaffold = "ScaffoldDTO";
        public const string ScaffoldRequest = "ScaffoldrequestDTO";
        public const string ScaffoldRequestHistory = "ScaffoldrequesthistoryDTO";
        public const string ScaffoldTrade = "ScaffoldtradeDTO";
        public const string Sd = "SdDTO";
        public const string Sdmateriallist = "SdmateriallistDTO";
        public const string Shift = "ShiftDTO";
        public const string Skill = "SkillDTO";
        public const string SigmaCue = "SigmacueDTO";
        public const string StandardWorkweek = "StandardworkweekDTO";
        public const string System = "SystemDTO";
        public const string Tagnumberdrawing = "TagnumberdrawingDTO";
        public const string Taskcategory = "TaskcategoryDTO";
        public const string Timesheet = "TimesheetDTO";
        public const string TimesheetProgress = "TimesheetprogressDTO";
        public const string TimeAllocation = "TimeallocationDTO";
        public const string Toolboxsign = "ToolboxsignDTO";
        public const string TrackTimesheet = "TracktimesheetDTO";
        public const string Turnover = "turnover";
        public const string Turnoverattendee = "turnoverattendee";
        public const string Usergroup = "UsergroupDTO";
        public const string Userlookup = "UserlookupDTO";
        public const string UserlookupCity = "UserlookupCityDTO";
        public const string Weather = "WeatherDTO";
        public const string Weekendholiday = "WeekendholidayDTO";
        public const string Workpackage = "WorkpackageDTO";
        public const string Workpackagerfi = "WorkpackagerfiDTO";
        public const string Workpackagestatus = "WorkpackagestatusDTO";
        public const string Worktime = "WorktimeDTO";
    }
    public sealed class TaskCategory
    {
        public const int Grounding_Install = 1;
        public const int Equipment_Install = 2;
        public const int Lighting_Install = 3;
        public const int Raceway_Install = 4;
        public const int Instrument_Install = 5;
        public const int EHT_Install = 6;
        public const int Cable_QC1 = 7;
        public const int Cable_Pull = 8;
        public const int Cable_GlandFrom = 9;
        public const int Cable_GlandTo = 10;
        public const int Cable_QC2 = 11;
        public const int Cable_TerminateFrom = 12;
        public const int Cable_TerminateTo = 13;
        public const int Cable_QC3 = 14;
        public const int Cable_QC4 = 15;
        public const int Raceway_SD_Install = 16;
        public const int Connection = 17;
        public const int Cable_Demolition = 25;
        public const int Insulation = 34;
        public const int Paint = 35;
        public const int Fireproofing = 36;
    }


    public sealed class MaterialCategory
    {
        public const int Grounding = 1;
        public const int Equipment = 2;
        public const int LightingREC = 3;
        public const int Raceway = 4;
        public const int Instruments = 5;
        public const int EHT = 6;
        public const int Cable = 7;
    }

    public sealed class PipeMaterialCategory
    {
        public const int Pipe_Bend = 11;
        public const int Weld = 12;
        public const int Support = 13;
        public const int Valve = 14;
        public const int Flange = 15;
        public const int Bolt = 16;
        public const int Tee = 17;
        public const int Others = 18;
        public const int Gasket = 19;
        public const int Fitting = 20;
    }

    public sealed class InsulMaterialCategory
    {
        public const int Piping = 21;
        public const int Vessel = 22;
        public const int Equipment = 23;
        public const int Building = 24;
        public const int Steel = 25;
        public const int Instrument = 26;
    }

    public sealed class PipeTaskCategory
    {
        public const int ErectingSpool = 16;
        public const int ThreadingSpool = 17;
        public const int WeldingSpool = 18;
        public const int Support = 19;
        public const int Flange = 20;
        public const int Boltup = 21;
        public const int ErectValve = 22;
        public const int ThreadingFitting = 23;
        public const int WeldingFittiing = 24;
        public const int ShopWeld = 26;
        public const int Insulation = 27;
        public const int Instrument = 28;
        public const int Hydrotest = 29;
    }

    public sealed class Fitting
    {
        public const string Valve = "VALVE";
        public const string Flange = "FLANGE";

        public const string Olet = "OLET";
        public const string Nipple = "NIPPLE";
        public const string Reducer = "REDUCER";
        public const string ExpansionJoint = "EXPANSION JOINT";
        public const string Swedge = "SWEDGE";

        public const string Bushing = "BUSHING";
    }

    public sealed class PipeMHType
    {
        public const int Soflange = 326;
        public const int Bwneckflange = 327;
        public const int Swclass = 328;
        public const int Erectpipe = 329;
        public const int Erectspool = 330;
        public const int Erectvalve = 331;
        public const int Thdfitting = 332;
        public const int Thdpipe = 333;
        public const int Thdvalveflange = 334;
        public const int Bwsch = 335;
        public const int Swsch = 336;
        public const int Bwinches = 337;
        public const int Boltup = 338;
    }

    public sealed class PCFItem
    {
        public const string PIPE = "PIPE";
        public const string BEND = "BEND";
        public const string WELD = "WELD";
        public const string SUPPORT = "SUPPORT";
        public const string VALVE = "VALVE";
        public const string FLANGE = "FLANGE";
        public const string BOLT = "BOLT";
        public const string GASKET = "GASKET";
        public const string REDUCER = "REDUCER-CONCENTRIC";
        public const string MISC_COMPONENT = "MISC-COMPONENT";
        public const string MATERIALS = "MATERIALS";
        public const string DESCRIPTION = "DESCRIPTION";
        public const string Tee = "TEE";
        public const string Elbow = "ELBOW";
        public const string Cap = "CAP";
        public const string Coupling = "COUPLING";
        public const string Union = "UNION";
        public const string Plug = "PLUG";
        public const string Olet = "OLET";
        public const string Bushing = "BUSHING";
        public const string END_POSITION_OPEN = "END-POSITION-OPEN";
        public const string FLANGE_REDUCING_CONCENTRIC = "FLANGE-REDUCING-CONCENTRIC";
        public const string UNITS_BORE = "UNITS-BORE";
        public const string UNITS_WEIGHT = "UNITS-WEIGHT";
        public const string PIPELINE_REFERENCE = "PIPELINE-REFERENCE";
        public const string ISO_SPLIT_POINT = "ISO-SPLIT-POINT ";
    }

    public sealed class PCFItemSub
    {
        public const string END_POINT = "END-POINT";
        public const string FABRICATION_ITEM = "FABRICATION-ITEM";
        public const string ITEM_CODE = "ITEM-CODE";
        public const string UNIQUE_COMPONENT_IDENTIFIER = "UNIQUE-COMPONENT-IDENTIFIER";
        public const string CONTINUATION = "CONTINUATION";
        public const string WEIGHT = "WEIGHT";
        public const string PIPING_SPEC = "PIPING-SPEC";
        public const string SKEY = "SKEY";
        public const string THICKNESS_RATING = "THICKNESS/RATING";
        public const string WELD_REMARK_NUMBER = "WELD-REMARK-NUMBER";
        public const string CO_ORDS = "CO-ORDS";
        public const string TAG = "TAG";
        public const string SUPPORT_DIRECTION = "SUPPORT-DIRECTION";
        public const string ERECTION_ITEM = "ERECTION-ITEM";
        public const string CENTRE_POINT = "CENTRE-POINT";
        public const string BUTT_WELD = "BUTT-WELD";
        public const string SOCKET_WELD = "SOCKET-WELD";
        public const string DWG = "DWG";
        public const string DET = "DET";
        public const string SPINDLE_DIRECTION = "SPINDLE-DIRECTION";
        public const string BOLT_DIA = "BOLT-DIA";
        public const string BOLT_QUANTITY = "BOLT-QUANTITY";
        public const string BOLT_LENGTH = "BOLT-LENGTH";
        public const string BRANCH1_POINT = "BRANCH1-POINT";
    }

    public sealed class PCFItemDesc
    {
        public const string CL = "CL";
        public const string LB = "LB";
        public const string THD = "THD";
        public const string BW = "BW";
        public const string SW = "SW";
        public const string SO = "SO";
        public const string WN = "WN";
        public const string SA = "SA";
        public const string PipeNipple = "PIPE NIPPLE";
        public const string Bushing = "BUSHING";
        public const string XS = "XS";
        public const string XXS = "XXS";
        public const string STD = "STD";
        public const string SCH = "SCH";
        public const string TBE = "TBE";
        public const string TOE = "TOE";
        public const string WS = "WS";
        public const string BE = "BE";
        public const string PE = "PE";
        public const string TE = "TE";
        public const string SC = "SC";
        public const string WST = "WST";
        public const string WW = "WW";

    }

    public sealed class IDFItem
    {
        public const string Component_WEIGHT = "10";
        public const string BEND = "30";
        public const string UBEND = "31";
        public const string ELBOW = "35";
        public const string ELBOW_REDUCING = "36";
        public const string OLET = "40";
        public const string INSTRUMENT_TEE = "41";
        public const string INSTRUMENT_TEE2 = "42";
        public const string TEE = "45";
        public const string TEE_SET_ON = "46";
        public const string TEE_STUB = "47";
        public const string REDUCER_CONNECTRIC = "55";
        public const string INSTRUMENT = "90";
        public const string MISC_COMPONENT = "95";
        public const string MISC_COMPONENT_ANGLE = "96";
        public const string PIPE = "100";
        public const string FLANGE = "105";
        public const string GASKET = "110";
        public const string BOLT = "115";
        public const string WELD = "120";
        public const string CAP = "125";
        public const string COUPLING = "126";
        public const string UNION = "127";
        public const string VALVE = "130";
        public const string DRAWING_SPLIT_POINT = "148";
        public const string LOCATION_RECORDS = "149";
        public const string SUPPORT = "150";
        public const string LARGE_COORDINATE_OFFSET_METRIC = "300";
        public const string LARGE_COORDINATE_OFFSET = "301";
        public const string END_FILE = "999";

        public const string Plug = "PLUG";
        public const string Bushing = "BUSHING";
    }

    public sealed class IDFItemSub
    {
        public const string ADDITIONAL_BORE = "0";
        public const string OVERFLOW = "-1";
        public const string PIPELINE_REFERENCE = "-6";
        public const string ITEM_CODE = "-20";
        public const string DESCRIPTION = "-21";
        public const string COMPONENT_TAG = "-22";
        public const string PIPING_SPEC = "-26";
        public const string END_POSITION_OPEN = "-32";
        public const string USER_DEFINED_MESSAGE = "-37";
        public const string PIPELINE_SPLIT_POINT = "-38";
        public const string UNIQUE_COMPONENT_IDENTIFIER = "-39";
        public const string WELD_NUMBER = "-67";
        public const string CO_ORDS = "-55"; //Need to be confirmed
        public const string WELD_REMARK_NUMBER = "-79";
        public const string OPTIONAL_DESCRIPTION = "-80";
        public const string OPTIONAL_DESCRIPTION2 = "-81";
        public const string MATERIALS_IDENTIFICATION = "-115";
        public const string ERECTION_ITEM = "-310";
        public const string M = "-329";
        public const string INS = "-330";
        public const string MM = "-331";

        public const string FABRICATION_ITEM = "FABRICATION-ITEM";
        public const string CONTINUATION = "CONTINUATION";
        public const string THICKNESS_RATING = "THICKNESS/RATING";
        public const string SUPPORT_DIRECTION = "SUPPORT-DIRECTION";
        public const string CENTRE_POINT = "CENTRE-POINT";
        public const string BUTT_WELD = "BUTT-WELD";
        public const string SOCKET_WELD = "SOCKET-WELD";
        public const string TAG = "TAG";
        public const string DWG = "DWG";
        public const string DET = "DET";
        public const string SPINDLE_DIRECTION = "SPINDLE-DIRECTION";
        public const string BOLT_DIA = "BOLT-DIA";
        public const string BOLT_QUANTITY = "BOLT-QUANTITY";
        public const string BOLT_LENGTH = "BOLT-LENGTH";
        public const string BRANCH1_POINT = "BRANCH1-POINT";
    }

    public sealed class IDFItemDesc
    {
        public const int Farbication = 1;
        public const int Erection = 2;
        public const int Offshore = 3;
        public const int Direction_North = 1;
        public const int Direction_South = 2;
        public const int Direction_East = 3;
        public const int Direction_West = 4;
        public const int Direction_Up = 5;
        public const int Direction_Down = 6;

        public const string North = "North";
        public const string South = "South";
        public const string East = "East";
        public const string West = "West";
        public const string Up = "Up";
        public const string Down = "Down";
    }

    public sealed class PipeConnectionType
    {
        public const string WELD = "WELD";
        public const string BOLTUP = "BOLT";
        public const string THD = "THD";
    }

    public enum RowStatus
    {
        None = 0,
        New = 4,
        Update = 16,
        Delete = 8
    }

    public sealed class Modules
    {
        // DB변경에 의한 Modules Type 변경 int 로 사용하던것을 필히 삭제 하여야함.
        // wcho 2014-02-20
        //public const int Piping = 1;
        //public const int Electrical = 2;
        //public const int Instrumentation = 3;
        //public const int Scaffold = 4;
        //public const int Insulation = 5;
        //public const int Steel = 6;
        //public const int Mechanical = 7;
        //public const int Civil = 8;
        //public const int MAGS = 9;

        public const string Civil = "DISCIPLINE_CIVIL";
        public const string	Electrical = "DISCIPLINE_ELECTRICAL";
        public const string Instrumentation = "DISCIPLINE_INSTRUMENTATION";
        public const string Insulation = "DISCIPLINE_INSULATION";
        public const string Mechanical = "DISCIPLINE_MECHANICAL";
        public const string Piping = "DISCIPLINE_PIPING";
        public const string RFID = "DISCIPLINE_RFID";
        public const string Scaffold = "DISCIPLINE_SCAFFOLD";
        public const string Steel = "DISCIPLINE_STEEL";
    }

    public sealed class USERLOOKUPTYPE
    {
        public const string Country = "Country";
        public const string Province = "Province";
        public const string City = "City";
        public const string DrawingType = "DrawingType";
        public const string SurveyComments = "SurveyComments";
    }

    public sealed class LOOKUPTYPE
    {
        public const string BoreSize = "BoreSize";
        public const string CableTaskType = "CableTaskType";
        public const string CableType1 = "CableType1";
        public const string CableType2 = "CableType2";
        public const string City = "City";
        public const string Class = "Class";
        public const string CompanyType = "CompanyType";
        public const string ComponentTaskType = "ComponentTaskType";
        public const string ComponentTestType = "ComponentTestType";
        public const string ConnectionType = "ConnectionType";
        public const string CostCodeClass = "CostCodeClass";
        public const string CostCodeType = "CostCodeType";
        public const string Country = "Country";
        public const string CWPLabel = "CWPLabel";
        public const string Department = "DepartmentType";
        public const string DiffFactorVariable = "ADDITIONALLAYER";
        public const string DocumentType = "DocType";
        public const string DrawingJpgDpi = "DrawingJpgDpi";
        public const string DrawingType = "DrawingType";
        public const string EHTType = "EHTType";
        public const string EquipType = "EquipType";
        public const string FireproofType = "FireproofShapes";
        public const string FiwpManonsiteStatus = "FiwpManonsiteStatus";
        public const string FiwpManPower = "FiwpManPower";
        public const string FixtureType = "FixtureType";
        public const string FormulaType = "FormulaType";
        public const string HeightRate = "HeightRate";
        public const string HydrostaticTest = "Hydrostatic Test";
        public const string HydroTestGroup = "HydroTestGroup";
        public const string InstrCategory = "InstrCategory";
        public const string InstrType = "InstrType";
        public const string InsulationPaint = "InsulationPaint";
        public const string InsulLibType = "InsulLibType";
        public const string ItemCode = "ItemCode";
        public const string LibType = "LibType";
        public const string LightingType = "LightingType";
        public const string MaterialType = "MaterialType";
        public const string Module = "Module";
        public const string P6ResourceName = "P6ResourceName";
        public const string PipeEnd = "PipeEnd";
        public const string PipeRatioType = "pipemhratiotype";
        public const string PipeSupportLUID = "PipeSupport";
        public const string PipeTypeLUID = "pipemhtype";
        public const string PneumaticTest = "Pneumatic Test";
        public const string ProcessSystem = "ProcessSystem";
        public const string QAManhourIncluded = "QAManhourIncluded";
        public const string RacewayClass = "RacewayClass";
        public const string RacewayLength = "RacewayLength";
        public const string RacewayMaterialType = "RacewayMaterialType";
        public const string RacewayType = "RacewayType";
        public const string RacewayWidth = "RacewayWidth";
        public const string RoomType = "RoomType";
        public const string RuleOfCredit = "RuleOfCredit";
        public const string ScaffoldStatus = "ScaffoldStatus";
        public const string ScaffoldTrade = "ScaffoldTrade";
        public const string Schedule = "Schedule";
        public const string ScheduleType = "ScheduleType";
        public const string SDType = "SD";  // Lookup : LookupType = 'ComponentTaskType' and lookupSubType = 'SD' (SDType(X) )
        public const string Shape = "Shape";
        public const string SiderailDepth = "SiderailDepth";
        public const string Skill = "Skill";
        public const string Stage = "Stage";
        public const string SurveyResult = "SurveyResult";
        public const string SurveyComments = "SurveyComments";
        public const string SystemType = "SystemType";
        public const string SystemGroup = "SystemGroup";  //SystemType -> SystemGroup 
        public const string TrackTimeSheetNo = "TrackTimeSheetNo";
        public const string TrayType = "TrayType";
        public const string TurnoverPackage = "TurnoverPackage";
        public const string Type = "Type";
        public const string UOM = "UOM";
        public const string UserGroup = "UserGroup";
        public const string Vendor = "Vendor";
        public const string WBS = "WBS";
        public const string WeldType = "WeldType";
        public const string WorkHour = "WorkHour";
    }

    public enum Privilege { View, Edit, New, Delete };

    #region "QAQC"
    public sealed class QAQCFormTemplate
    {
        public const string QAQC_CTR = "SuncorCableTrayQC"; //CableTray6.9R
        public const string QAQC_PCRRR = "QAQC_PCRRR"; //7.1
        public const string QAQC_CCRRR = "QAQC_CCRRR"; //7.2
        public const string QAQC_ICRRR = "QAQC_ICRRR"; //7.3
        public const string QAQC_PCIR = "QAQC_PCIR"; //7.4
        public const string QAQC_CCIR = "QAQC_CCIR"; //7.5
        public const string QAQC_ICIR = "QAQC_ICIR"; //7.6
        public const string QAQC_PCICR = "QAQC_PCICR"; //7.7
        public const string QAQC_PCICR_Inspect = "QAQC_PCICR_Inspect";
        public const string REQC = "REQC"; //2.1 Suncor Cable Tracy 

        public const string Suncor2_1QST = "Suncor2-1QST"; //Structural Steel Inspection Record
        public const string Suncor6_24QEL = "Suncor6-24QEL"; //Grounding Systems
        public const string Suncor6_34QEL = "Suncor6-34QEL"; // Cable Tray Installation Report
        public const string Suncor6_23QEL = "Suncor6-23QEL"; //Lighting Systems
        public const string Suncor6_25QEL = "Suncor6-25QEL"; //Power Supplies  Inverters
        public const string Suncor6_14QEL = "Suncor6-14QEL"; //Electrical Cables
        public const string Suncor6_22QEL = "Suncor6-22QEL"; //Power Panel Distribution Centers (120-208, 277-480, 347-600 Volts)
        public const string Suncor6_35QEL = "Suncor6-35QEL"; //Junction Boxes and Terminations
        public const string Suncor6_37QEL = "Suncor6-37QEL"; //Bolt Torque Report – Cables LugsBusses
        public const string Suncor7_1QQT = "Suncor7-1QQT"; //Outdoor Bus Structures
        public const string Suncor6_36QEL = "Suncor6-36QEL"; //Conduit System Installation
        public const string Suncor6_12QEL = "Suncor6-12QEL"; //Meters and Transducers
        public const string Suncor6_13QEL = "Suncor6-13QEL"; //Protective Relays
        public const string Suncor7_2QQT = "Suncor7-2QQT"; //Overhead Powerlines
        public const string Suncor2_2QST = "Suncor2-2QST"; //Torque Wrench Calibration Log
        public const string Suncor6_1QEL = "Suncor6-1QEL"; //Surge Protection
        public const string Suncor6_2QEL = "Suncor6-2QEL"; //Disconnect Switches   (TBD)
        public const string Suncor6_3QEL = "Suncor6-3QEL"; //Fuses
        public const string Suncor6_4QEL = "Suncor6-4QEL"; //Power Capacitor Banks
        public const string Suncor6_6QEL = "Suncor6-6QEL"; //Metal Enclosed Bus Duct
        public const string Suncor6_7QEL = "Suncor6-7QEL"; //Automatic Transfer Switches
        public const string Suncor6_8QEL = "Suncor6-8QEL"; //Switchgears
        public const string Suncor6_9QEL = "Suncor6-9QEL"; //Withdrawable Breakers
        public const string Suncor6_10QEL = "Suncor6-10QEL"; //Current Transformers  (TBD)
        public const string Suncor6_11QEL = "Suncor6-11QEL"; //Potential Transformers  (TBD)
        public const string Suncor6_15QEL = "Suncor6-15QEL"; //Motor Control Center (Excluding Starters, Feeders, And VFDs)
        public const string Suncor6_16QEL = "Suncor6-16QEL"; //Motor Starters (Full Voltage Start)
        public const string Suncor6_17QEL = "Suncor6-17QEL"; //Variable Frequency Drives
        public const string Suncor6_18QEL = "Suncor6-18QEL"; //Molded Case Circuit Breakers (Above 250 Amp Frame)
        public const string Suncor6_19QEL = "Suncor6-19QEL"; //Motor Test Run
        public const string Suncor6_20QEL = "Suncor6-20QEL"; //System Function Checks
        public const string Suncor6_26QEL = "Suncor6-26QEL"; //Battery Chargers
        public const string Suncor6_27QEL = "Suncor6-27QEL"; //Battery Sets
        public const string Suncor6_28QEL = "Suncor6-28QEL"; //Generators
        public const string Suncor6_29QEL = "Suncor6-29QEL"; //Cathodic Protection
        public const string Suncor6_30QEL = "Suncor6-30QEL"; //D.C. Hipot Test Report (for Switchgear and Cables rated 5 KV and above)
        public const string Suncor6_31QEL = "Suncor6-31QEL"; //Insulation Resistance Test Report
        public const string Suncor6_33QEL = "Suncor6-33QEL"; //Reactors
        public const string Suncor18_1QAF = "Suncor18-1QAF"; //NCR Non Conformance Report
        public const string Suncor18_2QAF = "Suncor18-2QAF"; //CAR_PAR Corrective/Preventive Action Request
        public const string Suncor7_3QQT = "Suncor7-3QQT"; //Line Data Summary *NOTE* Please refer to corresponding form in Suncor Standard -560
        public const string Suncor7_4QQT = "Suncor7-4QQT"; //Structure List *NOTE* Please refer to corresponding form in Suncor Standard -560
        public const string Suncor7_5QQT = "Suncor7-5QQT"; //Non-Standard Structure or Assembly Drawing *NOTE* Please refer to corresponding form in Suncor Stand
        public const string Suncor7_6QQT = "Suncor7-6QQT"; //Final Tower Commissioning Report  *NOTE* Please refer to corresponding form in Suncor Standard -560
        public const string Suncor7_7QQT = "Suncor7-7QQT"; //Structure Assessment Record  *NOTE* Please refer to corresponding form in Suncor Standard -560
        public const string Suncor7_8QQT = "Suncor7-8QQT"; //Site Inspection Record *NOTE* Please refer to corresponding form in Suncor Standard -560
        public const string Suncor7_9QQT = "Suncor7-9QQT"; //Site Inspection Record *NOTE* Please refer to corresponding form in Suncor Standard -560
        public const string Suncor7_10QQT = "Suncor7-10QQT"; //Site Inspection Record *NOTE* Please refer to corresponding form in Suncor Standard -560
        public const string Suncor6_32QEL = "Suncor6-32QEL"; //Secondary Selective Transfer System (TBD)
        public const string Suncor6_38QEL = "Suncor6-38QEL"; //Fibre Optic Cables *NOTE* Please refer to corresponding form in Suncor Standard -2601
        public const string Suncor6_21QEL = "Suncor6-21QEL"; //Dry Type Power Transformers (TBD)

        public const string QCF1_01_VOY = "QCF1_01-VOY";
        public const string QCF1_02_VOY = "QCF1_02-VOY";
        public const string QCF1_04_VOY = "QCF1_04-VOY";
        public const string QCF1_05_VOY = "QCF1_05-VOY";
        public const string QCF3_04_VOY = "QCF3_04-VOY";

        public const string ITR_5641 = "ITR-5.6.4.1";//Cable Tray Inspection
        public const string ITR_5631 = "ITR-5.6.3.1";//Lighting and Device Installation
        public const string ITR_5632 = "ITR-5.6.3.2";//Lighting and Device Circuit
        public const string ITR_5671 = "ITR-5.6.7.1";//Power Cable Reel Receiving Exhibit
        public const string ITR_5672 = "ITR-5.6.7.2";//Control Cable Reel Reciving Exhibit
        public const string ITR_5673 = "ITR-5.6.7.3";//Instrument Cable Reel Receiving Exhibit
        public const string ITR_5674 = "ITR-5.6.7.4";//Power Cable Inspection Exhibit
        public const string ITR_5675 = "ITR-5.6.7.5";//Control Cable Inspection Exhibit
        public const string ITR_5676 = "ITR-5.6.7.6";//Instrument Cable Inspection Exhibit
        public const string ITR_5661 = "ITR-5.6.6.1";//MI Receiving Report
        public const string ITR_5662 = "ITR-5.6.6.2";//SR/PL Receiving Report
        public const string ITR_5663 = "ITR-5.6.6.3";//MI Inspection Report
        public const string ITR_5664 = "ITR-5.6.6.4";//SR/PL Inspection Report
        public const string ITR_551 = "ITR-5.5.1";//Piping Test Record
        public const string ITR_5517 = "ITR-5.5.17";//Pipe Cleaning Travel Sheet
        public const string ITR_5516 = "ITR-5.5.16";//ABSA
        public const string ITR_5518 = "ITR-5.5.18";//Bolt Torquing / Tensioning Travel Sheet
        public const string ITR_5701 = "ITR-5.7.0.1";//Instrument Receiving Report
        public const string ITR_5702 = "ITR-5.7.0.2";//Instrument Installation Inspection
        public const string ITR_5731 = "ITR-5.7.3.1";//Instrument Calibration Record

        public const string PunchList = "PunchList";
    }

    public sealed class QAQCFormArea
    {
        public const int Area1 = 1074;
        public const int Area2 = 1075;
        public const int Area3 = 1076;
        public const int Area4 = 1077;
        public const int Area5 = 1078;
        public const int Area6 = 1751;
        public const int Area7 = 1752;
        public const int Area8 = 1753;
        public const int Area9 = 1754;
        public const int Area10 = 1755;
        public const int Header = 1749;
        public const int Grid = 1750;
    }

    public sealed class QAQCFormCode
    {
        public const string QAQC_CTR = "FB6_9R"; //CableTray6.9R
        public const string QAQC_PCRRR = "QAQC_PCRRR"; //7.1
        public const string QAQC_CCRRR = "QAQC_CCRRR"; //7.2
        public const string QAQC_ICRRR = "QAQC_ICRRR"; //7.3
        public const string QAQC_PCIR = "QAQC_PCIR"; //7.4
        public const string QAQC_CCIR = "QAQC_CCIR"; //7.5
        public const string QAQC_ICIR = "QAQC_ICIR"; //7.6
        public const string QAQC_PCICR = "QAQC_PCICR"; //7.7
        public const string QAQC_PCICR_Inspect = "QAQC_PCICR_Inspect";
        public const string REQC = "REQC"; //2.1 Suncor Cable Tracy 

    }

    public sealed class QAQCFormKeyType
    {
        public const string EngTagNumber = "EngTagNumber"; //735
        public const string ReelNumber = "ReelNumber"; //736
    }

    public sealed class QAQC_PCRRR
    {
        public const int Warehouse = 309;
        public const int PreTest = 310;
        public const int TestInfo = 311;
    }

    public sealed class QAQC_PCIR
    {
        public const int Data = 313;
        public const int SignOff = 315;
        public const int ConnectorsTight = 316;
        public const int CableSupported = 317;
        public const int CableTagChecked = 318;
        public const int PostGlandTest = 320;
        public const int TestInfo = 321;
        public const int TerminationsChecked = 322;
        public const int GrndConnectionChecked = 323;
        public const int WireMarkersChecked = 324;
    }

    public sealed class QAQC_PCICR
    {
        public const int PowerCableMeter = 718;
        public const int ABC_Grd = 719;
        public const int ABCN_Grd = 720;
        public const int ConductorCableMeter = 721;
        public const int MeterNo = 722;
        public const int InstrumentTest = 723;
        public const int ConductorTo = 726;
    }

    public sealed class QAQC_EffectiveDate
    {
        public const string Date1 = "2012-08-20";
        public const string Date2 = "2012-08-21";
    }
    #endregion

    #region "Suncor QEL"
    public sealed class Suncor6_12QEL
    {
        public const int Rows1 = 1283;
        public const int Rows2 = 1284;
        public const int Rows3 = 1285;
        public const int Rows4 = 1286;
        public const int Rows5 = 1287;
        public const int CheckRow1 = 1288;
        public const int CheckRow2 = 1289;
        public const int CheckRow3 = 1290;
        public const int CheckRow4 = 1291;
        public const int CheckRow5 = 1292;
        public const int CheckRow6 = 1293;
        public const int CheckRow7 = 1294;
        public const int CheckRow8 = 1295;
        public const int CheckRow9 = 1296;
        public const int Ranges1 = 1297;
        public const int Ranges2 = 1298;
        public const int Ranges3 = 1299;
        public const int TestInstruments1 = 1300;
        public const int TestInstruments2 = 1301;
        public const int TestInstruments3 = 1302;

    };

    public sealed class Suncor6_13QEL
    {
        public const int Rows1 = 1305;
        public const int Rows2 = 1306;
        public const int Rows3 = 1307;
        public const int CheckRow1 = 1308;
        public const int CheckRow2 = 1309;
        public const int CheckRow3 = 1310;
        public const int CheckRow4 = 1311;
        public const int CheckRow5 = 1312;
        public const int CheckRow6 = 1313;
        public const int CheckRow7 = 1314;
        public const int CheckRow8 = 1315;
        public const int CheckRow9 = 1316;
        public const int CheckRow10 = 1317;
        public const int CheckRow11 = 1318;
        public const int CheckRow12 = 1319;
        public const int CheckRow13 = 1320;
        public const int CheckRow14 = 1321;
        public const int CheckRow15 = 1322;
        public const int TestInstruments1 = 1323;
        public const int TestInstruments2 = 1324;
        public const int TestInstruments3 = 1325;
    };

    public sealed class Suncor6_34QEL
    {
        public const int CheckRow1 = 1054;
        public const int CheckRow2 = 1055;
        public const int CheckRow3 = 1056;
        public const int CheckRow4 = 1057;
        public const int CheckRow5 = 1058;
        public const int CheckRow6 = 1059;
        public const int CheckRow7 = 1060;
        public const int CheckRow8 = 1061;
        public const int CheckRow9 = 1062;
        public const int CheckRow10 = 1063;
        public const int CheckRow11 = 1064;
        public const int CheckRow12 = 1065;
        public const int CheckRow13 = 1066;
        public const int CheckRow14 = 1067;
        public const int CheckRow15 = 1068;
        public const int CheckRow16 = 1089;
        public const int CheckRow17 = 1070;
        public const int CheckRow18 = 1071;
        public const int CheckRow19 = 1072;
        public const int TestInstruments1 = 1073;
        public const int TestInstruments2 = 1074;
        public const int TestInstruments3 = 1075;
        public const int TestInstruments4 = 1076;
    };

    public sealed class Suncor6_14QEL
    {
        public const int CableInfo = 0;
        public const int Checks = 1;
        public const int Test = 2;
        public const int TestInstruments = 3;
    }

    public sealed class Suncor6_23QEL
    {
        public const int CheckRow1 = 1133;
        public const int CheckRow2 = 1134;
        public const int CheckRow3 = 1135;
        public const int CheckRow4 = 1136;
        public const int CheckRow5 = 1137;
        public const int CheckRow6 = 1138;
        public const int CheckRow7 = 1139;
        public const int CheckRow8 = 1140;
        public const int CheckRow9 = 1141;
        public const int CheckRow10 = 1142;
        public const int CheckRow11 = 1143;
        public const int CheckRow12 = 1144;
        public const int CheckRow13 = 1145;
        public const int CheckRow14 = 1146;
        public const int CheckRow15 = 1147;

        public const int TestInstruments1 = 1148;
        public const int TestInstruments2 = 1149;
        public const int TestInstruments3 = 1150;
    }

    public sealed class Suncor6_36QEL
    {
        public const int CheckRow1 = 1262;
        public const int CheckRow2 = 1263;
        public const int CheckRow3 = 1264;
        public const int CheckRow4 = 1265;
        public const int CheckRow5 = 1266;
        public const int CheckRow6 = 1267;
        public const int CheckRow7 = 1268;
        public const int CheckRow8 = 1269;
        public const int CheckRow9 = 1270;
        public const int CheckRow10 = 1271;
        public const int CheckRow11 = 1272;
        public const int CheckRow12 = 1273;
        public const int CheckRow13 = 1274;
        public const int CheckRow14 = 1275;
        public const int CheckRow15 = 1276;
        public const int CheckRow16 = 1277;
        public const int CheckRow17 = 1278;
        public const int CheckRow18 = 1279;

        public const int TestInstruments1 = 1280;
        public const int TestInstruments2 = 1281;
        public const int TestInstruments3 = 1282;
    }

    public sealed class Suncor6_37QEL
    {
        public const int CheckRow1 = 1381;
        public const int CheckRow2 = 1382;
        public const int CheckRow3 = 1383;
        public const int CheckRow4 = 1384;

        public const int TorqueRow1 = 1385;
        public const int TorqueRow2 = 1386;
        public const int TorqueRow3 = 1387;
        public const int TorqueRow4 = 1388;
        public const int TorqueRow5 = 1389;
        public const int TorqueRow6 = 1390;
        public const int TorqueRow7 = 1391;
        public const int TorqueRow8 = 1392;
        public const int TorqueRow9 = 1393;
        public const int TorqueRow10 = 1394;
        public const int TorqueRow11 = 1395;
        public const int TorqueRow12 = 1396;

        public const int TestInstruments1 = 1397;
        public const int TestInstruments2 = 1398;
        public const int TestInstruments3 = 1399;
    }

    public sealed class Suncor6_24QEL
    {
        public const int AmbientTemperature = 1179;
        public const int SoilConditions = 1180;
        public const int CheckRow1 = 1151;
        public const int CheckRow2 = 1152;
        public const int CheckRow3 = 1153;
        public const int CheckRow4 = 1154;
        public const int CheckRow5 = 1155;
        public const int CheckRow6 = 1156;
        public const int CheckRow7 = 1157;
        public const int CheckRow8 = 1158;
        public const int CheckRow9 = 1159;
        public const int CheckRow10 = 1160;
        public const int TestInstruments1 = 1181;
        public const int TestInstruments2 = 1182;
        public const int TestInstruments3 = 1183;

    };

    public sealed class Suncor6_25QEL
    {
        public const int CheckRow1 = 1161;
        public const int CheckRow2 = 1162;
        public const int CheckRow3 = 1163;
        public const int CheckRow4 = 1164;
        public const int CheckRow5 = 1165;
        public const int CheckRow6 = 1166;
        public const int CheckRow7 = 1167;
        public const int CheckRow8 = 1168;
        public const int CheckRow9 = 1169;
        public const int CheckRow10 = 1170;
        public const int CheckRow11 = 1171;
        public const int CheckRow12 = 1172;
        public const int CheckRow13 = 1173;
        public const int CheckRow14 = 1174;
        public const int CheckRow15 = 1175;
        public const int TestInstruments1 = 1176;
        public const int TestInstruments2 = 1177;
        public const int TestInstruments3 = 1178;
    };

    public sealed class QCF1_02_VOY
    {
        public const int CableInfo = 0;
        public const int Checks = 1;
        public const int CableRoute = 2;
    }
    #endregion

    #region "ETC in order of alphabet"
    public sealed class CableMaterialType
    {
        public const string Grounding = "Grounding";
        public const string Equipment = "Equipment";
        public const string LightingREC = "Lighting";
        public const string Raceway = "Raceway";
        public const string Instruments = "Instrument";
        public const string EHT = "EHT";
        public const string Cable = "Cable";
    }

    public sealed class CableTaskType
    {
        public const int Power = 221;
        public const int PowerControl = 222;
        public const int Instrumentation = 223;
        public const int Communication = 224;
        public const int MI = 299;//EHT
    }

    public sealed class Costcode
    {
        public const int LOA = 700824;
        public const int EquipmentFrom = 700900;
        public const int EquipmentTo = 701000;
    }

    public sealed class CostcodeStructure
    {
        public const int RootCostcodeStructure = 1;
    }

    public sealed class Department
    {
        public const int Owner = 21;
        public const int Piping = 1;
        public const int Electrical = 2;
        public const int Instrumentation = 3;
        public const int Scaffold = 4;
        public const int Insulation = 5;
        public const int Steel = 6;
        public const int Mechanical = 7;
        public const int Civil = 8;
        public const int MAGS = 9;
        public const int ConstructionManagement = 10;
        public const int Superintendant = 11;
        public const int ProjectManagement = 12;
        public const int GeneralForeman = 13;
        public const int Foreman = 14;
        public const int Crew = 15;
        public const int SupportStaff = 16;
        public const int MaterialManagement = 17;
        public const int QualityManagement = 18;
        public const int FieldEngineering = 19;
        public const int Administration = 20;
        public const int ProjectControl = 22;
        public const int EquipmentManagement = 23;
        public const int SafetyEnvironment = 25;
        public const int DocumentControl = 27;
        public const int Planner = 28;
        public const int Coordinator = 30;
    }

    public sealed class DepartmentType
    {
        public const int ProjectControl = 57;
        public const int Construction = 60;
        public const int ProjectManagement = 62;
        public const int ProjectManagementConstruction = 6062;
        public const int IWPSignOff = 6260;
        public const int All = -1;

    }

    public sealed class DomainUser
    {
        public const int True = 1;
        public const int False = 0;
    }

    public sealed class DrawingType
    {
        public const int LayoutDrawing = 41;
        public const int SingleLine = 42;
        public const int WiringDiagram = 56;
        public const int MotorSchematic = 105;
        public const int LoopDrawing = 107;
        public const int PanelSchedule = 108;
        public const int MCCSection = 109;
        public const int PANDID = 581;
        public const int DataSheet = 582;
        public const int InstallationDetail = 583;
        public const int Schedule = 584;
        public const int FIWPTemplate = 686;
        public const int RFI = 687;
        public const int QCDocument = 688;
        public const int Safety = 689;
        public const int MaterialOrder = 685;
        public const int SD = 692;
        public const int HeatTraceISO = 593;
        public const int DetailDrawing = 950;
        public const int DomolitionDrawing = 952;
        public const int CableTerminationDetail = 593;
        public const int LogicDiagram = 591;
        public const int CableSchedule = 584;
        public const int QAQCTemplate = 993;
        public const int LocationDrawing = 595;
    }

    public sealed class EquipType
    {
        public const int Equipment = 209;
        public const int Tool = 737;
    }

    public sealed class P6Resource
    {
        public const string ResourceName = "REVEAL";
    }

    public sealed class RFIDocumentType
    {
        public const int FCR = 1062;
        public const int FCN = 1063;
        public const int PMOC = 1064;
        public const int TDN = 1065;
        public const int NCR = 1066;
        public const int PAR = 1067;
        public const int CMR = 1068;
        public const int RFIDoc = 693;
    }

    public sealed class TrackTimeSheetStatus
    {
        public const int Submit = 1412;
        public const int Approve = 1413;
        public const int Reject = 1414;
        public const int Delete = 1415;
    }

    public sealed class TypeOfConductor
    {
        public const string C = "C";
        public const string PR = "PR";
        public const string TR = "TR";
    }

    public sealed class UOM
    {
        public const int Meters = 31;
        public const int Feet = 32;
        public const int SQFT = 33;
        public const int SQM = 34;
        public const int TON = 35;
        public const int Each = 36;
        public const int CF = 37;
        public const int CY = 38;
        public const int LB = 307;
        public const int Roll = 308;
        public const int Inch = 567;
        public const int Millimeter = 1088;
        public const int LF = 1570;
    }

    public sealed class UserGroup
    {
        public const int Administrator = 1;
        public const int ProjectManager = 2;
        public const int Management = 3;
        public const int Construction = 4;
        public const int Planner = 5;
        public const int QAQC = 6;
        public const int Guest = 7;
    }
    #endregion

    public sealed class DocType
    {
        public const int RFIDoc = 693;
        public const int EstimateProposal = 694;
        public const int JobSetup = 697;
        public const int WEP = 698;
        public const int WorkfacePlanning = 702;
        public const int WorkfacePlanning1 = 948;
        public const int WorkfacePlanning2 = 949;
        public const int ModelView = 741;
        public const int SafteyDoc = 742;
        public const int Drawing = 983;
        public const int QaqcTemplate = 993;
        public const int QC = 710;
        public const int TurnoverPackage = 1958;
        public const int PnIDDrawing = 1983;
        public const int PSSR = 1984;
        public const int AssociatedDoc = 1985;
    }

    public sealed class DocEstablished
    {
        public const int ModelView = 743;
        public const int WFP1 = 744;
        public const int WFP2 = 947;
        public const int Equipment = 745;
        public const int Safety = 746;
        public const int RFI = 747;
    }

    //public sealed class DocEstablishedForApp
    //{
    //    public const string Scope = "1758";
    //    public const string FieldEquipment = "1759";
    //    public const string ConsumableMaterial = "1760";
    //    public const string ITR = "1761";
    //    public const string SafetyDocument = "1762";
    //    public const string SiteImage = "1763";

    //    //코드값 서비스팀 확인 필요
    //    public const string SafetyChecklist = "1990";
    //    public const string ScaffoldChecklist = "1991";
    //    public const string IWPSignOff = "1992";
    //    public const string SpecsDetails = "1993";
    //    public const string MOC = "1994";
    //}

    public sealed class DocEstablishedForCSU
    {
        public const string PnIDDrawing = "1987";
        public const string PSSR = "1988";
        public const string AssociatedDoc = "1989";
    }

    // CollectionName과 대체되며 추후 참조되는 부분이 없으면 제거해야 함.
    public sealed class SPCollectionName
    {
        public const string QAQC = "QC";
        public const string ProjectDoc = "ProjectDocuments";
        public const string SafetyDoc = "SafetyDocuments";
        //public const string HydroSafetyDoc = "HydroSafetyDocuments";
        public const string RFIDoc = "RFIDocuments";
        public const string Drawing = "EngineerDrawings";
        public const string TimesheetLinks = "TimeSheets";
        public const string Markup = "Markups";
        public const string MarkupSuffix = "_mk_";
        public const string CrewPicture = "CrewPictures";
        public const string ToolboxSign = "ToolboxSigns";
        public const string ToolboxTalk = "ToolboxTalks";
        public const string CrewAttendance = "CrewAttendance";
        public const string Timesheet = "TimeSheet";
        public const string TimesheetDoc = "TimeSheet";
        public const string Turnover = "Turnover";
        public const string Punch = "Punch";
        public const string AssociatedDoc = "AssociatedDocuments";
        public const string PSSR = "PSSR";

    }

    public sealed class SPDocType
    {
        public const string ModelView = "3DModelView";
        public const string WFP = "WFP";
        public const string Drawing = "Drawing";
        public const string RFIDoc = "RFI";
        public const string Timesheets = "Timesheets";
        public const string Toolboxsign = "Toolboxsign";
        public const string ITR = "ITR";
    }

    public sealed class SPTurnoverDocType
    {
        public const string COVER = "Cover";
        public const string INDEX = "Index";
        public const string MC = "Mechanical Completion";
        public const string MC_PDF = "Mechanical Completion by PDF";
        public const string TCCC = "Transfer Of Care Custody Control";
        public const string TCCC_PDF = "Transfer Of Care Custody Control by PDF";
        public const string REDLINE = "Redline Drawings";
        public const string NO20 = "Contractor Discipline System Sign Off";
        public const string NO21 = "Discipline System Sign Off";
        public const string NO30 = "System Turnover Exception List";
        public const string NO32 = "System Walkdown Attendees";
        public const string NO50 = "Turnover System Checklist";
    }

    public sealed class TurnoverPackageDocType
    {
        public const int TurnoverPackage_0 = 1961;
        public const int TurnoverPackage_0_0 = 1963;
        public const int TurnoverPackage_1_1 = 1965;
        public const int TurnoverPackage_1_2 = 1966;
        public const int TurnoverPackage_2_0 = 1967;
        public const int TurnoverPackage_2_1 = 1968;
        public const int TurnoverPackage_3_0 = 1969;
        public const int TurnoverPackage_3_2 = 1970;
        public const int TurnoverPackage_4_0 = 1971;
        public const int TurnoverPackage_4_1 = 1972;
        public const int TurnoverPackage_4_2 = 1973;
        public const int TurnoverPackage_4_3 = 1976;
        public const int TurnoverPackage_5_0 = 1977;
        public const int TurnoverPackage_5_5_1 = 1978;
        public const int TurnoverPackage_5_6_1 = 1979;
        public const int TurnoverPackage_5_7_1 = 1980;
    }

    public sealed class LogSource
    {
        public const int RFI = 1416;
        public const int USER = 1417;
    }

    public sealed class DrawingAttachFileName
    {
        public const string Name1 = "_Page";

    }

    public sealed class DrawingSize
    {
        public const int MaxBytesJPG = 551572;    // 500K(524288)
        public const int MaxTotalBytes = 1048576; // 1 MB
    }

    public sealed class MaterialDimension
    {
        public const string East = "East";
        public const string North = "North";
        public const string Elevation = "Elevation";
        public const string Line4 = "Line4";
        public const string Line5 = "Line5";

        public const string FEast = "FEast";
        public const string TEast = "TEast";
        public const string FNorth = "FNorth";
        public const string TNorth = "TNorth";
        public const string FElevation = "FElevation";
        public const string TElevation = "TElevation";
    }

    public sealed class MaterialField
    {
        public const string StringVar7 = "StringVar7";
        public const string StringVar8 = "StringVar8";
        public const string StringVar9 = "StringVar9";
        public const string StringVar10 = "StringVar10";
        public const string StringVar11 = "StringVar11";
        public const string StringVar12 = "StringVar12";
        public const string StringVar13 = "StringVar13";
        public const string StringVar14 = "StringVar14";
        public const string StringVar20 = "StringVar20";
        public const string StringVar21 = "StringVar21";
        public const string TagNumber = "TagNumber";
        public const string EngTagNumber = "EngTagNumber";
        public const string RFI = "RFINumber";
    }

    public sealed class ComponentField
    {
        public const string LineNo = "ISOLineNo";
        public const string EWO = "EWO";
    }

    public sealed class FiwpManonsiteStatus
    {
        public const int OnSite = 1085;
        public const int DayOff = 1086;
        public const int Absent = 1087;
    }


    public sealed class FormulaType
    {
        public const int Cylindre = 1105;
        public const int Irregular = 1106;
        public const int Circle = 1107;
        public const int Hemispherical = 1108;
        public const int Dished = 1109;
        public const int Cone = 1110;
        public const int Transition = 1111;
        public const int Nozzles = 1112;
        public const int Obstructions = 1113;
        public const int Block_Outs = 1114;
        public const int Square_Duct = 1115;
        public const int Sphare = 1116;
        public const int Repad = 1576;
    }

    public sealed class InsulLibType
    {
        public const int Fastener = 1128;
        public const int Mesh = 1129;
        public const int Coat = 1130;
        public const int Fill = 1131;
        public const int Shape = 1127;

        public const int InsulPaint = 1118;
        public const int InsulSurPrep = 1117;
        public const int InsulPaintType = 1265;

    }

    public sealed class Fireproof
    {
        public const int Saddle = 1400;
        public const int Sturecture = 1399;
        public const int TowerSkirt = 1401;
        public const int Support = 1571;
    }

    public sealed class SiteInstance
    {
        public const string TrueVue = "TrueVue";
    }

    public sealed class InsulationConst
    {
        public const string BuildingTask = "Structure";
        public const string PipeType = "Pipe";
        public const string Steel = "Steel";

    }


    public sealed class OwnerLoginName
    {
        public const string Admin = "admin";
    }

    public sealed class IFCDrawing
    {
        public const string Orignal = "base";
    }

    public sealed class CompanyType
    {
        public const string LookupType = "CompanyType";
        public const string SiteOwner = "SiteOwner";
        public const string Client = "Client";
        public const string SubContractor = "SubContractor";
    }

    public sealed class CostCodeType
    {
        public const string InDirect = "InDirect";
        public const string Direct = "Direct";

        public const int InDirectValue = 1613;
        public const int DirectValue = 1612;
    }

    public sealed class PipeEnd
    {
        public const string BE = "BE";
        public const string PE = "PE";
        public const string TE = "TE";
    }

    public sealed class WeldType
    {
        public const string BW = "BW";
        public const string SW = "SW";
        public const string SO = "SO";
        public const string WN = "WN";
    }

    public sealed class Encription
    {
        public const string keyValue = "Element1";
    }

    public sealed class ProjectWizardStep
    {
        public const int MODULE = 1;
        public const int PROJECT = 2;
        public const int CONTRACTOR = 3;
        public const int CWA = 4;
        public const int CWP = 5;
        public const int SYSTEM = 7;
        public const int COSTCODE = 8;
        public const int FINISH = 10;
    }

    public sealed class ScheduleType
    {
        public const int INDIRECT = 1711;
        public const int HYDRO = 1712;
    }

    public sealed class BrassSignType
    {
        public const int BRASSIN = 1;
        public const int BRASSOUT = 9;
    }


    public sealed class SigmaCueTaskType
    {
        public const string Timesheet = "Timesheet";
        public const string IWP = "IWP";
    }

    public sealed class DailyTimesheetStatus
    {
        public const int F_Sumbitted = 1;
        public const int GF_Approved = 2;
        public const int GF_Rejected = 3;
        public const int A_Approved = 4;
        public const int A_Rejected = 5;
    }

    public sealed class MaterialDataType
    {
        public const int BASIC = 1739;
        public const int HEATTRACE = 1740;
        public const int TEMPERATURE = 1741;
    }

    public sealed class Resp
    {
        public const int GeneralForeman = 1742;
        public const int Foreman = 1743;
        public const int QualityManagement = 1744;
    }

    public sealed class QAQCType
    {
        public const int Tag = 1745;
        public const int Reel = 1746;
        public const int System = 1784;
        public const int Loop = 1785;
        public const int HardTag = 1786;
        public const int Line = 1842;
        public const int Equip = 1843;
    }

    public sealed class QAQCFormType
    {
        public const int IWP = 1747;
        //public const int AssembleIWP = 1748;
        public const int HydroTest = 1782;
        //public const int AssembleHydroTest = 1783;
        public const int SIWP = 1802;
        //public const int AssembleSIWP = 1803;
        public const int PunchList = 1860;
        public const int MC = 1981;
        public const int TCCC = 1982;
    }

    public sealed class SurveyResult
    {
        public const int PASS = 1764;
        public const int FAIL = 1765;
        public const int PASS_isCompleted = 1;
        public const int FAIL_isCompleted = -1;
    }

    public sealed class PackageType
    {
        public const int FIWP = 1798;
        public const int SIWP = 1799;
        public const int HydroTest = 1800;
        public const int CSU = 1872;
    }

    public sealed class PunchCategory
    {
        public const int A = 1844;
        public const int AA = 1845;
        public const int BB = 1846;
        public const int BCC = 1847;
        public const int BSU = 1848;
        public const int C = 1849;
        public const int CA = 1850;
        public const int CB = 1851;
        public const int CNF = 1852;
    }

    public sealed class QAQCApprovalStatus
    {
        public const int ForemanApprove = 1855;
        public const int QCManagerApprove = 1857;
        public const int QCManagerReject = 1858;
    }

    public sealed class QAQCDataType
    {
        public const int ITR = 1901;
        public const int PunchList = 1902;
        public const int Certificates = 1904;
    }

    public sealed class Stage
    {
        public const int CC = 1909;
        public const int MCC = 1910;
        public const int TCCC = 1911;
        public const int CCO = 1912;
    }

    public sealed class ROLE_TYPE
    {
        public const string ROLE_ADMINISTRATOR = "ROLE_ADMINISTRATOR";	
        public const string ROLE_DOCUMENTCONTROL = "ROLE_DOCUMENTCONTROL";	
        public const string ROLE_EQUIPMENTMANAGER = "ROLE_EQUIPMENTMANAGER";
        public const string ROLE_FOREMAN = "ROLE_FOREMAN";	
        public const string ROLE_GENERALFOREMAN	 = "ROLE_GENERALFOREMAN";
        public const string ROLE_MATERIALMANAGER = "ROLE_MATERIALMANAGER";	
        public const string ROLE_PLANNER = "ROLE_PLANNER";	
        public const string ROLE_PROJECTMANAGER	= "ROLE_PROJECTMANAGER";
        public const string ROLE_QUALITYMANAGER	= "ROLE_QUALITYMANAGER";
        public const string ROLE_SAFETYMANAGER = "ROLE_SAFETYMANAGER";
        public const string ROLE_SUPERINTENDENT = "ROLE_SUPERINTENDENT";	
    }

    public sealed class FileCategory
    {
        public const string DOCUMENT = "FILE_CATEGORY_DOCUMENT";
        public const string DRAWING = "FILE_CATEGORY_DRAWING";
        public const string FORM = "FILE_CATEGORY_FORM";
        public const string REPORT = "FILE_CATEGORY_REPORT";
    }

	public sealed class FileType
    {
        public const string COVER = "FILE_TYPE_COVER";
        public const string MOC = "FILE_TYPE_MOC";
        public const string SUMMARY = "FILE_TYPE_SUMMARY";
        public const string SAFETY_CHECK = "FILE_TYPE_SAFETY_CHECK";
        public const string SAFETY_FORM = "FILE_TYPE_SAFETY_FORM";
        public const string ITR = "FILE_TYPE_ITR";
        public const string EQUIPMENT = "FILE_TYPE_EQUIPMENT";
        public const string CONSUMABLE = "FILE_TYPE_CONSUMABLE";
        public const string SCAFFOLD_CHECK = "FILE_TYPE_SCAFFOLD_CHECK";
        public const string SPEC = "FILE_TYPE_SPEC";
        public const string DRAWING_MARKUP = "FILE_TYPE_DRAWING_MARKUP";
        public const string CREW_ATTENDANCE = "FILE_TYPE_CREWATTENDANCE";
        public const string TIME_PROGRESS = "FILE_TYPE_TIMEPROGRESS";
    }

    public sealed class CollectionName
    {
        public const string DRAWING = "Drawings";
        public const string SAFETY = "Safety";
        public const string ITR = "ITR";
        public const string SPEC = "Specs & Details";
        public const string MOC = "MOC";

    }

    public sealed class AssembleStep
    {
        public const string COVER = "IWP_ASSEMBLE_STEP_COVER";
        public const string MOC = "IWP_ASSEMBLE_STEP_MOC";
        public const string SUMMARY = "IWP_ASSEMBLE_STEP_SUMMARY";
        public const string SAFETY_CHECK = "IWP_ASSEMBLE_STEP_SAFETY_CHECK";
        public const string SAFETY_FORM = "IWP_ASSEMBLE_STEP_SAFETY_FORM";
        public const string ITR = "IWP_ASSEMBLE_STEP_ITR";
        public const string EQUIPMENT = "IWP_ASSEMBLE_STEP_EQUIPMENT";
        public const string CONSUMABLE = "IWP_ASSEMBLE_STEP_CONSUMABLE";
        public const string SCAFFOLD_CHECK = "IWP_ASSEMBLE_STEP_SCAFFOLD_CHECK";
        public const string SPEC = "IWP_ASSEMBLE_STEP_SPEC";
        public const string APPROVER = "IWP_ASSEMBLE_STEP_APPROVER";
    }

    public sealed class IsWBS
    {
        public const int Level3 = 3;
        public const int Level4 = 4;
    }

    public sealed class WorklowTypeCode
    {
        public const string IWP = "WORKFLOW_TYPE_IWP";
        public const string RFI = "WORKFLOW_TYPE_RFI";
        public const string ITR = "WORKFLOW_TYPE_ITR";
    }
}
