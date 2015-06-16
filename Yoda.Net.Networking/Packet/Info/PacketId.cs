using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Packet.Info
{
    public class PacketId
    {

        public static int ERROR = -255;

        public static int NOTIFICATION = 144;

        public static int ALERT_RESULT = 149;

        public static int MAINTENANCE_RESULT = 146;

        public static int FLASH_EOS_NOTIFICATION = 150;

        public static int GET_SERVER_TIME = 147;

        public static int GET_SERVER_TIME_RESULT = 148;

        public static int CONF_NOTIFICATION = 149;

        public static int PROCEED_TUTORIAL = 154;

        public static int PROCEED_TUTORIAL_RESULT = 155;

        public static int LOGIN = 256;

        public static int LOGIN_RESULT = 257;

        public static int CHECK_ANNOUNCE = 258;

        public static int MUST_READ_RULES = 259;

        public static int CREATE_USER = 272;

        public static int CREATE_USER_RESULT = 273;

        public static int START_CREATE_USER = 274;

        public static int START_CREATE_USER_RESULT = 275;

        public static int CREATE_PIGG_STEP = 276;

        public static int GET_CONFLICTED_PIGG = 280;

        public static int GET_CONFLICTED_PIGG_RESULT = 281;

        public static int APPLY_CONFLICTED_PIGG = 282;

        public static int APPLY_CONFLICTED_PIGG_RESULT = 283;

        public static int GET_USER_BODY = 288;

        public static int GET_USER_BODY_RESULT = 289;

        public static int UPDATE_USER_BODY = 290;

        public static int UPDATE_PROFILE_IMAGE = 291;

        public static int UPDATE_PROFILE_IMAGE_RESULT = 292;

        public static int SEARCH_FRIEND_ID = 304;

        public static int SEARCH_FRIEND_ID_RESULT = 305;

        public static int SEARCH_FRIEND_NICKNAME = 306;

        public static int SEARCH_FRIEND_NICKNAME_RESULT = 307;

        public static int SEARCH_FRIEND_AMEMBER = 308;

        public static int SEARCH_FRIEND_AMEMBER_RESULT = 309;

        public static int SEARCH_FRIEND_NOW = 310;

        public static int SEARCH_FRIEND_NOW_RESULT = 311;

        public static int SEARCH_FRIEND_RECOMMEND = 312;

        public static int SEARCH_FRIEND_RECOMMEND_RESULT = 313;

        public static int GET_USER_PROFILE = 320;

        public static int GET_USER_PROFILE_RESULT = 321;

        public static int UPDATE_POINT_RESULT = 336;

        public static int UPDATE_CONFIG_RESULT = 345;

        public static int GET_CONFIG = 352;

        public static int GET_CONFIG_RESULT = 353;

        public static int UPDATE_CONFIG = 354;

        public static int LIST_USER_ITEM = 512;

        public static int LIST_USER_ITEM_RESULT = 513;

        public static int DRESSUP = 528;

        public static int DRESSUP_RESULT = 529;

        public static int GET_MANNEQUIN_DETAIL = 550;

        public static int GET_MANNEQUIN_DETAIL_RESULT = 551;

        public static int GET_AREA_MANNEQUIN_DETAIL = 554;

        public static int GET_AREA_MANNEQUIN_DETAIL_RESULT = 555;

        public static int DRESSUP_MANNEQUIN = 546;

        public static int DRESSUP_MANNEQUIN_RESULT = 547;

        public static int LIST_USER_MANNEQUIN = 548;

        public static int LIST_USER_MANNEQUIN_RESULT = 549;

        public static int SWAP_MANNEQUIN = 552;

        public static int SWAP_MANNEQUIN_RESULT = 553;

        public static int OPEN_DRESSUP_MANNEQUIN = 556;

        public static int OPEN_DRESSUP_MANNEQUIN_RESULT = 557;

        public static int REQUEST_FRIENDSHIP = 768;

        public static int APPROVE_FRIENDSHIP = 769;

        public static int DELETE_FRIENDSHIP = 770;

        public static int CANCEL_FRIENDSHIP = 771;

        public static int APPROVE_FRIENDSHIP_RESULT = 772;

        public static int REQUEST_FRIENDSHIP_RESULT = 773;

        public static int DELETE_FRIENDSHIP_RESULT = 774;

        public static int CANCEL_FRIENDSHIP_RESULT = 775;

        public static int CHECK_FRIENDSHIP_REQUESTABLE = 776;

        public static int CHECK_FRIENDSHIP_REQUESTABLE_RESULT = 777;

        public static int LIST_FRIEND = 784;

        public static int LIST_FRIEND_RESULT = 785;

        public static int LIST_FRIENDSHIP_REQUEST = 786;

        public static int LIST_FRIENDSHIP_REQUEST_RESULT = 787;

        public static int LIST_FRIENDSHIP_OTHERS = 788;

        public static int LIST_FRIENDSHIP_OTHERS_RESULT = 789;

        public static int LIST_GIFT_HISTORY_REQUEST = 790;

        public static int LIST_GIFT_HISTORY_RESULT = 791;

        public static int NOTIFY_FRIEND_STATUS = 800;

        public static int SEND_MESSAGE = 1024;

        public static int SEND_MESSAGE_RESULT = 1025;

        public static int RECEIVE_MESSAGE = 1026;

        public static int NOTIFY_RECEIVED_MESSAGE = 1027;

        public static int SEND_ARCHIVE_MESSAGE = 1040;

        public static int SEND_ARCHIVE_MESSAGE_RESULT = 1044;

        public static int LIST_ARCHIVE_MESSAGE = 1041;

        public static int LIST_ARCHIVE_MESSAGE_RESULT = 1042;

        public static int DELETE_ARCHIVE_MESSAGE = 1043;

        public static int CHECK_BAN_WORD = 5633;

        public static int CHECK_BAN_WORD_RESULT = 5634;

        public static int CHECK_ZONING_ARCHIVE_MESSAGE = 357;

        public static int CHECK_ZONING_ARCHIVE_MESSAGE_RESULT = 358;

        public static int MAMA_CREATE = 1028;

        public static int MAMA_CREATE_RESULT = 1029;

        public static int LIST_AREA = 1280;

        public static int LIST_AREA_RESULT = 1281;

        public static int TRAVEL_AREA = 1282;

        public static int TRAVEL_AREA_RESULT = 1283;

        public static int GET_AREA = 1296;

        public static int GET_AREA_RESULT = 1297;

        public static int GET_USER_AREA = 1298;

        public static int GET_USER_AREA_RESULT = 1299;

        public static int DISPATCH_AREA = 1319;

        public static int DISPATCH_AREA_RESULT = 1320;

        public static int VISIT_RANDOM_USER_AREA = 1330;

        public static int VISIT_RANDOM_USER_AREA_RESULT = 1331;

        public static int GET_RANDOM_SELECT_AREA = 1321;

        public static int GET_RANDOM_SELECT_AREA_RESULT = 1322;

        public static int NOTIFY_USER_ROOM_ENTERED = 1312;

        public static int LIST_AREA_BUNDLE = 1313;

        public static int LIST_AREA_BUNDLE_RESULT = 1314;

        public static int TRAVEL_BUNDLE = 1317;

        public static int TRAVEL_BUNDLE_RESULT = 1318;

        public static int LIST_AREA_TOP = 1315;

        public static int LIST_AREA_TOP_RESULT = 1316;

        public static int LIST_SPEAKAREA = 1344;

        public static int LIST_SPEAKAREA_RESULT = 1345;

        public static int LIST_SPEAKLOG = 1346;

        public static int LIST_SPEAKLOG_RESULT = 1347;

        public static int LIST_SPEAKUSER = 1348;

        public static int LIST_SPEAKUSER_RESULT = 1349;

        public static int RESERVE_SPEAKAREA = 1354;

        public static int RESERVE_SPEAKAREA_RESULT = 1355;

        public static int CANCEL_SPEAKAREA = 1356;

        public static int CANCEL_SPEAKAREA_RESULT = 1357;

        public static int CANCEL_RESERVE_AREA = 1358;

        public static int CANCEL_RESERVE_AREA_RESULT = 1359;

        public static int ADD_FAVORITE_AREA = 1350;

        public static int ADD_FAVORITE_AREA_RESULT = 1351;

        public static int REMOVE_FAVORITE_AREA = 1352;

        public static int REMOVE_FAVORITE_AREA_RESULT = 1353;

        public static int LOGIN_ENTER_QUEUE_START = 21505;

        public static int GET_SHOP = 1360;

        public static int GET_SHOP_RESULT = 1361;

        public static int GET_ROOM_EXPANSION_SHOP = 1362;

        public static int GET_ROOM_EXPANSION_SHOP_RESULT = 1363;

        public static int GET_ROOM_ADDITION_SHOP = 1364;

        public static int GET_ROOM_ADDITION_SHOP_RESULT = 1365;

        public static int BUY_SHOP_ITEM = 1376;

        public static int BUY_SHOP_ITEM_RESULT = 1377;

        public static int GET_GIFT_SHOP_DETAIL = 1392;

        public static int GET_GIFT_SHOP_DETAIL_RESULT = 1393;

        public static int BUY_GIFT_ITEM = 1394;

        public static int BUY_GIFT_ITEM_RESULT = 1395;

        public static int INFO_QUEST_UPDATE_FIELD_STATUS = 1408;

        public static int GET_SHOP_FURNITURE_DETAIL = 1378;

        public static int GET_SHOP_FURNITURE_DETAIL_RESULT = 1379;

        public static int GET_SHOP_BANNER = 1380;

        public static int GET_SHOP_BANNER_RESULT = 1381;

        public static int GET_SHOP_RANKING = 1382;

        public static int GET_SHOP_RANKING_RESULT = 1383;

        public static int GET_SALE_SHOP = 1408;

        public static int GET_SALE_SHOP_RESULT = 1409;

        public static int BUY_SALE_SHOP_ITEM = 1410;

        public static int BUY_SALE_SHOP_ITEM_RESULT = 1411;

        public static int GET_SALE_ANNOUNCE = 1412;

        public static int GET_SALE_ANNOUNCE_RESULT = 1413;

        public static int GET_SALE_POYON = 1414;

        public static int GET_SALE_POYON_RESULT = 1415;

        public static int GET_SALE_SHOP_FURNITURE_DETAIL = 1416;

        public static int GET_SALE_SHOP_FURNITURE_DETAIL_RESULT = 1417;

        public static int GET_MULTIPLE_SHOP = 1424;

        public static int GET_MULTIPLE_SHOP_RESULT = 1425;

        public static int GET_MULTIPLE_SHOP_FURNITURE_DETAIL = 1426;

        public static int GET_SHOP_COSME_DETAIL = 1427;

        public static int GET_SHOP_COSME_DETAIL_RESULT = 1428;

        public static int GET_BEGINNER_SHOP_COSME_DETAIL = 1429;

        public static int GET_BEGINNER_SHOP_COSME_DETAIL_RESULT = 1430;

        public static int LIST_USER_FURNITURE = 1536;

        public static int LIST_USER_FURNITURE_RESULT = 1537;

        public static int LIST_ADMIN_FURNITURE = 1538;

        public static int LIST_ADMIN_FURNITURE_RESULT = 1539;

        public static int TRASH_ITEM = 1808;

        public static int TRASH_ITEM_RESULT = 1809;

        public static int GET_SCRACTH = 2048;

        public static int GET_SCRACH_RESULT = 2049;

        public static int LIST_SCRATCH = 2050;

        public static int LIST_SCRATCH_RESULT = 2051;

        public static int CHOOSE_SCRATCH = 2052;

        public static int OPEN_SCRATCH = 2064;

        public static int OPEN_SCRATCH_RESULT = 2065;

        public static int GET_FORTUNE = 2066;

        public static int GET_FORTUNE_RESULT = 2067;

        public static int GET_GAME_LOGIN_INCENTIVE = 2068;

        public static int GET_GAME_LOGIN_INCENTIVE_RESULT = 2069;

        public static int LIST_GOOD = 2305;

        public static int LIST_GOOD_RESULT = 2306;

        public static int START_GOOD_FEVER_RESULT = 2307;

        public static int END_GOOD_FEVER_RESULT = 2308;

        public static int LIST_ACTION = 4097;

        public static int LIST_ACTION_RESULT = 4098;

        public static int UPDATE_ACTION = 4099;

        public static int FLASH_OVERREACTION_RESULT = 4100;

        public static int LEAVE_FOOTPRINT = 4352;

        public static int LEAVE_FOOTPRINT_RESULT = 4353;

        public static int LIST_FOOTPRINT = 4354;

        public static int LIST_FOOTPRINT_RESULT = 4355;

        public static int LIST_ANNOUNCE_RESULT = 4136;

        public static int LIST_ANNOUNCE_EVENT_RESULT = 4144;

        public static int NOTIFY_ANNOUNCE_EVENT = 4145;

        public static int NOTIFY_ANNOUNCE_EVENT_RESULT = 4146;

        public static int LIST_ANNOUNCE_QUEST_RESULT = 18176;

        public static int UPDATE_QUEST_STATUS_START = 18177;

        public static int UPDATE_QUEST_STATUS_CHECK_CLEAR = 18178;

        public static int LIST_CALENDAR = 4147;

        public static int LIST_CALENDAR_RESULT = 4148;

        public static int LIST_ANNOUNCE_FIRST_DAY_RESULT = 4149;

        public static int NOTIFY_ANNOUNCE_FIRST_DAY = 4150;

        public static int NOTIFY_ANNOUNCE_FIRST_DAY_RESULT = 4151;

        public static int LIST_LINK_RESULT = 4137;

        public static int CREATE_CLUB = 4608;

        public static int CREATE_CLUB_RESULT = 4609;

        public static int LIST_CLUB_MEMBER = 4610;

        public static int LIST_CLUB_MEMBER_RESULT = 4611;

        public static int GET_CLUB_CARD = 4614;

        public static int GET_CLUB_CARD_RESULT = 4615;

        public static int UPDATE_CLUB_CONFIG = 4616;

        public static int UPDATE_CLUB_CONFIG_RESULT = 4617;

        public static int UPDATE_CLUB_USER_TYPE = 4624;

        public static int UPDATE_CLUB_USER_TYPE_RESULT = 4625;

        public static int REMOVE_CLUB_USER = 4626;

        public static int REMOVE_CLUB_USER_RESULT = 4627;

        public static int LIST_CLUB = 4628;

        public static int LIST_CLUB_RESULT = 4629;

        public static int REQUEST_CLUB_JOIN = 4630;

        public static int REQUEST_CLUB_JOIN_RESULT = 4631;

        public static int ADD_CLUB_MEMBER = 4632;

        public static int ADD_CLUB_MEMBER_RESULT = 4633;

        public static int INVITE_CLUB_MEMBER = 4640;

        public static int INVITE_CLUB_MEMBER_RESULT = 4641;

        public static int LIST_CLUB_INFO = 4642;

        public static int LIST_CLUB_INFO_RESULT = 4643;

        public static int CLUB_CONFIG = 4644;

        public static int CLUB_CONFIG_RESULT = 4645;

        public static int GET_EMBLEM = 4646;

        public static int GET_EMBLEM_RESULT = 4647;

        public static int NOTIFY_CLUB_ROOM_ENTERED = 4648;

        public static int CLUB_MESSAGE = 4649;

        public static int CLUB_MESSAGE_RESULT = 4656;

        public static int ADD_CLUB_MESSAGE = 4657;

        public static int REMOVE_CLUB_MESSAGE = 4658;

        public static int CLUB_SEARCH = 4659;

        public static int CLUB_SEARCH_RESULT = 4660;

        public static int LIST_CLUB_MEMBER_WAIT = 4661;

        public static int LIST_CLUB_MEMBER_WAIT_RESULT = 4662;

        public static int LIST_CLUB_CATEGORY = 4663;

        public static int LIST_CLUB_CATEGORY_RESULT = 4664;

        public static int LIST_CLUB_REQUEST = 4665;

        public static int LIST_CLUB_REQUEST_RESULT = 4672;

        public static int REJECT_MEMBER = 4673;

        public static int REJECT_MEMBER_RESULT = 4674;

        public static int CLUB_VISITED = 1540;

        public static int CLUB_MESSAGE_UP = 1541;

        public static int LIST_CLUB_CONTRIBUTION = 4681;

        public static int LIST_CLUB_CONTRIBUTION_RESULT = 4682;

        public static int LIST_PET = 4865;

        public static int LIST_PET_RESULT = 4866;

        public static int BUY_PET = 4867;

        public static int BUY_PET_RESULT = 4868;

        public static int RELEASE_PET = 4869;

        public static int RELEASE_PET_RESULT = 4870;

        public static int GET_PET_PROFILE = 4871;

        public static int GET_PET_PROFILE_RESULT = 4872;

        public static int SET_PET_PROFILE = 4873;

        public static int SET_PET_PROFILE_RESULT = 4874;

        public static int BUY_PET_CONFIRM = 4875;

        public static int BUY_PET_CONFIRM_RESULT = 4876;

        public static int LIST_USER_ACTION_ITEM = 5121;

        public static int LIST_USER_ACTION_ITEM_RESULT = 5122;

        public static int USE_ACTION_ITEM = 5123;

        public static int USE_ACTION_ITEM_RESULT = 5124;

        public static int UPDATE_CONDITION_RESULT = 5125;

        public static int CANCEL_CONDITION = 5126;

        public static int INVITE_SEND_MAIL = 5377;

        public static int INVITE_SEND_MAIL_RESULT = 5378;

        public static int CHECK_SEND_MAIL = 5379;

        public static int CHECK_SEND_MAIL_RESULT = 5380;

        public static int CHECK_SEND_MAIL_RETURN = 5381;

        public static int CHECK_SEND_MAIL_RETURN_RESULT = 5382;

        public static int GET_USER_INVITE_INFO = 5383;

        public static int GET_USER_INVITE_INFO_RESULT = 5384;

        public static int LIST_USER_INVITE = 5385;

        public static int LIST_USER_INVITE_RESULT = 5392;

        public static int CHECK_INVITE = 5393;

        public static int CHECK_INVITE_RESULT = 5394;

        public static int CHECK_INVITE_MAIL_ADDRESS = 5395;

        public static int CHECK_INVITE_MAIL_ADDRESS_RESULT = 5396;

        public static int GET_USER_INVITE_COUNT = 5397;

        public static int GET_USER_INVITE_COUNT_RESULT = 5398;

        public static int GET_INVITE_INCENTIVE = 5399;

        public static int GET_INVITE_INCENTIVE_RESULT = 5400;

        public static int GET_SELF_INCENTIVE = 5401;

        public static int GET_SELF_INCENTIVE_RESULT = 5408;

        public static int GET_USER_CODE = 355;

        public static int GET_USER_CODE_RESULT = 356;

        public static int LIST_MISSION = 5889;

        public static int LIST_MISSION_RESULT = 5890;

        public static int CHALLENGE_BEGINNER = 5891;

        public static int AREA_GAME_FIELD = 8704;

        public static int AREA_GAME_FIELD_RESULT = 8705;

        public static int GET_GAME_INIT = 6145;

        public static int GET_GAME_INIT_RESULT = 6146;

        public static int GET_GAME_UPDATE = 6147;

        public static int GET_GAME_UPDATE_RESULT = 6148;

        public static int GET_GAME_UPDATE_BY_METHOD = 6149;

        public static int GET_GAME_UPDATE_BY_METHOD_RESULT = 6150;

        public static int GET_MATCHING_GAME_AREA_STATUS = 6151;

        public static int GET_MATCHING_GAME_AREA_STATUS_RESULT = 6152;

        public static int UPDATE_MATCHING_GAME_AREA_STATUS = 6153;

        public static int UPDATE_MATCHING_GAME_AREA_STATUS_RESULT = 6160;

        public static int GET_USER_GAME_HISTORY = 6161;

        public static int GET_USER_GAME_HISTORY_RESULT = 6162;

        public static int GET_GACHA = 6401;

        public static int GET_GACHA_RESULT = 6402;

        public static int PLAY_GACHA = 6403;

        public static int PLAY_GACHA_RESULT = 6404;

        public static int PLAY_GACHA_STEPUP = 6409;

        public static int PLAY_GACHA_STEPUP_RESULT = 6416;

        public static int GET_STREAMING_INFO = 8199;

        public static int GET_STREAMING_INFO_RESULT = 8200;

        public static int STREAMING_INTERNAL = 8201;

        public static int SYNC_ENTER_ROOM_AREA_INTERNAL = 8208;

        public static int SYNC_DO_ACTION_AREA_INTERNAL = 8209;

        public static int SYNC_DO_MOVE_AREA_INTERNAL = 8210;

        public static int SYNC_DO_MOVEEND_AREA_INTERNAL = 8211;

        public static int SYNC_DO_TALK_AREA_INTERNAL = 8212;

        public static int GET_WAITING_ROOM = 8213;

        public static int GET_WAITING_ROOM_RESULT = 8214;

        public static int SYNC_LEAVE_USER_AREA_INTERNAL = 8215;

        public static int SYNC_ROOM_ACTION_AREA_INTERNAL = 8216;

        public static int CASINO_ACCEPT_TERM_REQUEST = 8448;

        public static int CASINO_ACCEPT_TERM = 8449;

        public static int CASINO_GET_BALANCE = 8450;

        public static int CASINO_GET_BALANCE_RESULT = 8451;

        public static int CASINO_BUY_POINT_PREPARE = 8452;

        public static int CASINO_BUY_POINT_PREPARE_RESULT = 8453;

        public static int CASINO_BUY_POINT_EXECUTE = 8454;

        public static int CASINO_BUY_POINT_EXECUTE_RESULT = 8455;

        public static int CASINO_FREE_LOT = 8456;

        public static int CASINO_FREE_LOT_RESULT = 8457;

        public static int CASINO_LUCKY_ITEM_RESULT = 8464;

        public static int CASINO_LUCKY_ITEM_SELECT_REQUEST = 8467;

        public static int CASINO_LUCKY_ITEM_SELECT_RESULT = 8468;

        public static int CASINO_POCKET_ITEM_LIST_REQUEST = 8469;

        public static int CASINO_POCKET_ITEM_LIST_RESULT = 8470;

        public static int CASINO_LUCKY_ITEM_AVAILABLE_LIST_REQUEST = 8471;

        public static int CASINO_LUCKY_ITEM_AVAILABLE_LIST_RESULT = 8472;

        public static int CASINO_CUMULATIVE_INCENTIVE_REQUEST = 8473;

        public static int CASINO_CUMULATIVE_INCENTIVE_RESULT = 8480;

        public static int CASINO_CHALLENGE_CHECK_REQUEST = 8481;

        public static int CASINO_SHORT_TERM_CHALLENGE_GIVE_ITEM_RESULT = 8482;

        public static int CASINO_MINNA_TERM_REQUEST = 8483;

        public static int CASINO_MINNA_TERM_RESULT = 8484;

        public static int CASINO_MINNA_PARTICIPATE_REQUEST = 8485;

        public static int CASINO_MINNA_PARTICIPATE_RESULT = 8486;

        public static int CASINO_MINNA_MOVE_PLAYAREA_REQUEST = 8487;

        public static int CASINO_MINNA_MOVE_PLAYAREA_RESULT = 8488;

        public static int CASINO_MINNA_RANK_IN_TEAM_REQUEST = 8489;

        public static int CASINO_MINNA_RANK_IN_TEAM_RESULT = 8496;

        public static int CASINO_MINNA_TEAM_RANK_AROUND5_REQUEST = 8497;

        public static int CASINO_MINNA_TEAM_RANK_AROUND5_RESULT = 8498;

        public static int CASINO_MINNA_TEAM_RANK_TOP5_REQUEST = 8499;

        public static int CASINO_MINNA_TEAM_RANK_TOP5_RESULT = 8500;

        public static int CASINO_MINNA_IS_AVAILABLE_REQUEST = 8501;

        public static int CASINO_MINNA_IS_AVAILABLE_RESULT = 8502;

        public static int CASINO_MINNA_IS_END_RESULT = 8504;

        public static int CASINO_MINNA_RECORD_REQUEST = 8505;

        public static int CASINO_MINNA_RECORD_RESULT = 8512;

        public static int CASINO_MINNA_REMAINING_TIME_REQUEST = 8514;

        public static int CASINO_MINNA_REMAINING_TIME_RESULT = 8515;

        public static int CASINO_INCENTIVE_RESULT = 8516;

        public static int CASINO_MINNA_TOP_REQUEST = 8517;

        public static int CASINO_MINNA_TOP_RESULT = 8518;

        public static int CASINO_MINNA_TEAM_REQUEST = 8519;

        public static int CASINO_MINNA_TEAM_RESULT = 8520;

        public static int CASINO_CHALLENGE_SHOW_MODULE_REQUEST = 8533;

        public static int CASINO_CHALLENGE_SHOW_MODULE_RESULT = 8534;

        public static int CASINO_CHALLENGE_NUM_ITEMS_AND_TIME_REMAIN_REQUEST = 8535;

        public static int CASINO_CHALLENGE_NUM_ITEMS_AND_TIME_REMAIN_RESULT = 8536;

        public static int CASINO_CHALLENGE_NEXT_EARN = 8537;

        public static int CASINO_JEWELRY_WINDOW_TOP_REQUEST = 8538;

        public static int CASINO_JEWELRY_WINDOW_TOP_RESULT = 8539;

        public static int CASINO_JEWELRY_WINDOW_RANKING_REQUEST = 8540;

        public static int CASINO_JEWELRY_WINDOW_RANKING_RESULT = 8541;

        public static int CASINO_JEWELRY_WINDOW_TOP5_REQUEST = 8542;

        public static int CASINO_JEWELRY_WINDOW_TOP5_RESULT = 8543;

        public static int CASINO_JEWELRY_INCENTIVE_REQUEST = 8544;

        public static int CASINO_JEWELRY_SHOW_RANK_WINDOW_RESULT = 8545;

        public static int CASINO_JEWELRY_WINDOW_TOP_GAMEEND_RESULT = 8546;

        public static int CASINO_SLOT_DE_GACHA_SHOW_MODULE_REQUEST = 8561;

        public static int CASINO_SLOT_DE_GACHA_SHOW_MODULE_RESULT = 8562;

        public static int CASINO_SLOT_DE_GATHA_TIME_REMAIN_REQUEST = 8563;

        public static int CASINO_SLOT_DE_GATHA_TIME_REMAIN_RESULT = 8564;

        public static int CASINO_MISSION_MIDDLE_PANEL_REQUEST = 8576;

        public static int CASINO_MISSION_MIDDLE_PANEL_RESULT = 8577;

        public static int CASINO_MISSION_START_PANEL_RESULT = 8578;

        public static int CASINO_MISSION_STATUS_PANEL_REQUEST = 8579;

        public static int CASINO_MISSION_STATUS_PANEL_RESULT = 8580;

        public static int CASINO_MISSION_CLEAR_PANEL_RESULT = 8581;

        public static int CASINO_MISSION_TIME_REMAIN_REQUEST = 8582;

        public static int CASINO_MISSION_TIME_REMAIN_RESULT = 8583;

        public static int CASINO_MISSION_SMALL_MISSION_RESULT = 8584;

        public static int CASINO_SLOT_ROYALE_USERMODULE_TOP_REQUEST = 8585;

        public static int CASINO_SLOT_ROYALE_USERMODULE_TOP_RESULT = 8586;

        public static int CASINO_SLOT_ROYALE_USERMODULE_RANKING_REQUEST = 8587;

        public static int CASINO_SLOT_ROYALE_USERMODULE_RANKING_RESULT = 8588;

        public static int CASINO_SLOT_ROYALE_REMAINTIME_REQUEST = 8589;

        public static int CASINO_SLOT_ROYALE_REMAINTIME_RESULT = 8590;

        public static int CASINO_SLOT_ROYALE_AREAMODULE_CHALLENGE_REQUEST = 8591;

        public static int CASINO_SLOT_ROYALE_AREAMODULE_CHALLENGE_RESULT = 8592;

        public static int CASINO_SLOT_ROYALE_AREAMODULE_RANK_REQUEST = 8593;

        public static int CASINO_SLOT_ROYALE_AREAMODULE_RANK_RESULT = 8594;

        public static int CASINO_SLOT_ROYALE_START_POPUP_RESULT = 8595;

        public static int CASINO_SLOT_ROYALE_PRE_ENTRY_REQUEST = 8596;

        public static int CASINO_SLOT_ROYALE_PRE_ENTRY_RESULT = 8597;

        public static int CASINO_SLOT_ROYALE_PRE_ENTRY_MODULE_RESULT = 8598;

        public static int CASINO_SLOT_ROYALE_JACKPOT_MODULE_REQUEST = 8599;

        public static int CASINO_SLOT_ROYALE_JACKPOT_MODULE_RESULT = 8600;

        public static int CASINO_SLOT_ROYALE_JACKPOT_LAUNCHED_MODULE_RESULT = 8601;

        public static int CASINO_SLOT_ROYALE_BUNDLELIST_REQUEST = 8720;

        public static int CASINO_SLOT_ROYALE_BUNDLELIST_RESULT = 8721;

        public static int SEARCH_NOTICE_BOARD_MESSAGE = 8960;

        public static int SEARCH_NOTICE_BOARD_MESSAGE_RESULT = 8961;

        public static int CREATE_NOTICE_BOARD_MESSAGE = 8962;

        public static int CREATE_NOTICE_BOARD_MESSAGE_RESULT = 8963;

        public static int GET_NOTICE_BOARD_MESSAGE = 8964;

        public static int GET_NOTICE_BOARD_MESSAGE_RESULT = 8965;

        public static int UPDATE_NOTICE_BOARD_MESSAGE = 8966;

        public static int UPDATE_NOTICE_BOARD_MESSAGE_RESULT = 8967;

        public static int DELETE_NOTICE_BOARD_MESSAGE = 8968;

        public static int DELETE_NOTICE_BOARD_MESSAGE_RESULT = 8969;

        public static int GET_NOTICE_BOARD_MESSAGE_OF_AREA = 8970;

        public static int GET_NOTICE_BOARD_MESSAGE_OF_AREA_RESULT = 8971;

        public static int LIST_NOTICE_BOARD_MESSAGE_SUMMARY = 8972;

        public static int LIST_NOTICE_BOARD_MESSAGE_SUMMARY_RESULT = 8973;

        public static int AGREE_NOTICE_BOARD_PENALTY = 8974;

        public static int AGREE_NOTICE_BOARD_PENALTY_RESULT = 8975;

        public static int LIKE_NOTICE_BOARD_MESSAGE = 8976;

        public static int LIKE_NOTICE_BOARD_MESSAGE_RESULT = 8977;

        public static int GET_NOTICE_BOARD_RANKING = 8978;

        public static int GET_NOTICE_BOARD_RANKING_RESULT = 8979;

        public static int LIST_NOTICE_BOARD_RANKING = 8980;

        public static int LIST_NOTICE_BOARD_RANKING_RESULT = 8981;

        public static int CHECK_NOTICE_BOARD_RANKING = 8982;

        public static int CHECK_NOTICE_BOARD_RANKING_RESULT = 8983;

        public static int SEND_RECEIVED_APPROVAL = 8984;

        public static int OPEN_NOTICE_BOARD_CREATE_PANEL = 8994;

        public static int OPEN_NOTICE_BOARD_CREATE_PANEL_RESULT = 8995;

        public static int GET_COLLECTION_STATUS = 9984;

        public static int GET_COLLECTION_STATUS_RESULT = 9985;

        public static int RECYCLE_DARATS_DATA = 9986;

        public static int RECYCLE_DARATS_DATA_RESULT = 9987;

        public static int RECYCLE_DARATS_PRIZE_DATA = 6405;

        public static int RECYCLE_DARATS_PRIZE_DATA_RESULT = 6406;

        public static int RECYCLE_DARATS_PRIZE_LIST_DATA = 6407;

        public static int RECYCLE_DARATS_PRIZE_LIST_DATA_RESULT = 6408;

        public static int VOTE_GET = 9216;

        public static int VOTE_GET_RESULT = 9217;

        public static int VOTE_GET_QUESTION = 9218;

        public static int VOTE_GET_QUESTION_RESULT = 9219;

        public static int VOTE_GET_SUMMARY = 9220;

        public static int VOTE_GET_SUMMARY_RESULT = 9221;

        public static int VOTE_SEND = 9222;

        public static int VOTE_SEND_RESULT = 9223;

        public static int VOTE_SEND_IMPRESSION = 9232;

        public static int TREASURE_GET = 9472;

        public static int TREASURE_RESULT = 9473;

        public static int GET_MINITALK_CONFIG = 16384;

        public static int GET_MINITALK_CONFIG_RESULT = 16385;

        public static int CHECK_MINITALK_CONFIG = 16386;

        public static int CHECK_MINITALK_CONFIG_RESULT = 16387;

        public static int SEARCH_MINITALK_BUDDY = 16388;

        public static int SEARCH_MINITALK_BUDDY_RESULT = 16389;

        public static int STOP_MINITALK_SEARCH = 16390;

        public static int STOP_MINITALK_SEARCH_RESULT = 16391;

        public static int START_MINITALK = 16392;

        public static int GET_MINITALK_PROFILE = 16393;

        public static int GET_MINITALK_PROFILE_RESULT = 16400;

        public static int STOP_MINITALK = 16401;

        public static int STOP_MINITALK_RESULT = 16402;

        public static int FINISH_MINITALK = 16403;

        public static int GET_MINITALK_NPC_WORDS = 16404;

        public static int GET_MINITALK_NPC_WORDS_RESULT = 16405;

        public static int FINISH_MINITALK_TO_ROOM = 16406;

        public static int FINISH_MINITALK_TO_ROOM_RESULT = 16407;

        public static int CHECK_MINITALK_FRIENDSHIP_REQUESTABLE = 16408;

        public static int CHECK_MINITALK_FRIENDSHIP_REQUESTABLE_RESULT = 16409;

        public static int CHECK_ADMINMODE = 368;

        public static int CHECK_ADMINMODE_RESULT = 369;

        public static int LIST_GROUPMESSAGE_GROUP = 10241;

        public static int LIST_GROUPMESSAGE_GROUP_RESULT = 10242;

        public static int CREATE_GROUPMESSAGE_GROUP = 10243;

        public static int CREATE_GROUPMESSAGE_GROUP_RESULT = 10244;

        public static int UPDATE_GROUPMESSAGE_GROUP = 10245;

        public static int UPDATE_GROUPMESSAGE_GROUP_RESULT = 10246;

        public static int LIST_GROUPMESSAGE_MEMBER = 10247;

        public static int LIST_GROUPMESSAGE_MEMBER_RESULT = 10248;

        public static int LIST_GROUPMESSAGE_GROUP_MEMBER = 10249;

        public static int LIST_GROUPMESSAGE_GROUP_MEMBER_RESULT = 10250;

        public static int ADD_GROUPMESSAGE_GROUP_MEMBER = 10251;

        public static int ADD_GROUPMESSAGE_GROUP_MEMBER_RESULT = 10252;

        public static int REMOVE_GROUPMESSAGE_GROUP_MEMBER = 10253;

        public static int REMOVE_GROUPMESSAGE_GROUP_MEMBER_RESULT = 10254;

        public static int ADD_GROUPMESSAGE_MESSAGE = 10255;

        public static int ADD_GROUPMESSAGE_MESSAGE_RESULT = 10256;

        public static int LIST_GROUPMESSAGE_MESSAGE = 10257;

        public static int LIST_GROUPMESSAGE_MESSAGE_RESULT = 10258;

        public static int CHECK_GROUPMESSAGE_MESSAGE = 10259;

        public static int BAN_GROUPMESSAGE = 10260;

        public static int CONFIRM_GROUPMESSAGE_ALERT = 10261;

        public static int MENKO_BUNDLE_GET = 10510;

        public static int MENKO_BUNDLE_GET_RESULT = 10511;

        public static int GET_MENKO_GACHA_RESULT = 10513;

        public static int PLAY_MENKO_GACHA = 10514;

        public static int PLAY_MENKO_GACHA_RESULT = 10515;

        public static int MENKO_COLLECTION_GET = 10496;

        public static int MENKO_COLLECTION_GET_RESULT = 10497;

        public static int MENKO_COLLECTION_GET_RESULT_NOTE = 10500;

        public static int GET_MENKO_NOTE = 10498;

        public static int GET_MENKO_NOTE_RESULT = 10499;

        public static int MENKO_TUTORIAL_GET = 10518;

        public static int MENKO_TUTORIAL_GET_RESULT = 10519;

        public static int PLAY_MENKO_TUTORIAL = 10520;

        public static int MENKO_INSENTIVE_GET = 10516;

        public static int MENKO_INSENTIVE_GET_RESULT = 10517;

        public static int CHECK_PIGGDOME_TERM = 8202;

        public static int CHECK_PIGGDOME_TERM_RESULT = 8203;

        public static int AGREE_PIGGDOME_TERM = 8204;

        public static int NOTIFY_MAGAZINE_SEEN = 12544;

        public static int NOTIFY_LUCKY_ICON = 12800;

        public static int GET_LUCKY_CONTENT = 12801;

        public static int GET_LUCKY_CONTENT_RESULT = 12802;

        public static int OPEN_LUCKY_PIECE = 12803;

        public static int OPEN_LUCKY_PIECE_RESULT = 12804;

        public static int GET_LOGIN_INCENTIVE_ICON = 13056;

        public static int GET_LOGIN_INCENTIVE_ICON_RESULT = 13057;

        public static int PROVIDE_LOGIN_INCENTIVE_ITEM = 13058;

        public static int PROVIDE_LOGIN_INCENTIVE_ITEM_RESULT = 13059;

        public static int LIST_CLUB_FURNITURE = 4675;

        public static int LIST_CLUB_FURNITURE_RESULT = 4676;

        public static int CHECK_CONTRIBUTE_CLUB_FURNITURE = 4677;

        public static int CHECK_CONTRIBUTE_CLUB_FURNITURE_RESULT = 4678;

        public static int CONTRIBUTE_CLUB_FURNITURE = 4679;

        public static int CONTRIBUTE_CLUB_FURNITURE_RESULT = 4680;

        public static int NOTIFY_CLUB_CONTRIBUTION = 1542;

        public static int REMODEL_ROOM = 1540;

        public static int REMODEL_ROOM_RESULT = 1541;

        public static int GET_TICKET_SHOP = 13312;

        public static int GET_TICKET_SHOP_RESULT = 13313;

        public static int BUY_TICKET = 13314;

        public static int BUY_TICKET_RESULT = 13315;

        public static int COMMAND_TYPE_DRESSUP = 0;

        public static int COMMAND_TYPE_BODY = 1;

        public static int COMMAND_TYPE_COSME = 2;

        public static int COMMAND_TYPE_INVITE = 3;

        public static int COMMAND_TYPE_SNAPSHOT = 4;

        public static int COMMAND_TYPE_CONTEST = 5;

        public static int COMMAND_TYPE_DIARY = 6;

        public static int CHECK_TWITTER_TOKEN_AVAILABLE = 12288;

        public static int CHECK_TWITTER_TOKEN_AVAILABLE_RESULT = 12289;

        public static int UPDATE_TWITTER_PROFILE_IMAGE = 12290;

        public static int UPDATE_TWITTER_PROFILE_IMAGE_RESULT = 12291;

        public static int SEND_TWITTER_DIRECT_MESSAGE = 17664;

        public static int SEND_TWITTER_DIRECT_MESSAGE_RESULT = 17665;

        public static int RESULT_SUCCESS = 0;

        public static int RESULT_FAILED = 1;

        public static int CHECK_FACEBOOK_TOKEN_AVAILABLE = 17152;

        public static int CHECK_FACEBOOK_TOKEN_AVAILABLE_RESULT = 17153;

        public static int LIST_SNS_FRIEND = 17408;

        public static int LIST_SNS_FRIEND_RESULT = 17409;

        public static int LIST_COSMETIC = 13568;

        public static int LIST_COSMETIC_RESULT = 13569;

        public static int MAKEUP = 13570;

        public static int MAKEUP_RESULT = 13571;

        public static int UPDATE_USER_SWF = 13572;

        public static int GET_RANKING = 13824;

        public static int GET_MAHJONG_RANKING_RESULT = 13825;

        public static int GET_MAHJONG_RANKING_MORE = 13826;

        public static int GET_MAHJONG_RANKING_MORE_RESULT = 13827;

        public static int GET_MAHJONG_USER_RANKING = 13828;

        public static int GET_MAHJONG_USER_RANKING_RESULT = 13829;

        public static int GET_LR_CAMPAIGN = 14336;

        public static int GET_LR_CAMPAIGN_RESULT = 14337;

        public static int GET_LR_CAMPAIGN_QUEST_CLEAR_RESULT = 14338;

        public static int GET_LR_CAMPAIGN_TIME_REMAIN = 14339;

        public static int GET_LR_CAMPAIGN_TIME_REMAIN_RESULT = 14340;

        public static int TAKEOFF_AKIBA_ONLY_ITEM = 544;

        public static int TAKEOFF_AKIBA_ONLY_ITEM_RESULT = 545;

        public static int GET_SNAPSHOT_TOKEN = 16640;

        public static int GET_SNAPSHOT_TOKEN_RESULT = 16641;

        public static int LIST_CHANNEL = 20480;

        public static int LIST_CHANNEL_DATA = 20481;

        public static int LINK_AREA_BUNDLE = 1328;

        public static int LINK_AREA_BUNDLE_RESULT = 1329;

        public static int LIST_CHANNEL_NEWS = 20482;

        public static int LIST_CHANNEL_NEWS_RESULT = 20483;

        public static int VJ_CHANNEL_USER_AREA = 20545;

        public static int VJ_CHANNEL_USER_AREA_RESULT = 20546;

        public static int BRAODCAST_CONFIG__REQUEST = 9728;

        public static int BRAODCAST_CONFIG_RESULT = 9729;

        public static int LIST_CHANNEL_PROGRAM = 20501;

        public static int LIST_CHANNEL_PROGRAM_RESULT = 20502;

        public static int VJ_FANLIST_REQUEST = 20484;

        public static int VJ_FANLIST_RESULT = 20485;

        public static int VJ_QUITFAN_REQUEST = 20997;

        public static int VJ_QUITFAN_RESULT = 20998;

        public static int VJ_SEARCH_KEYWORD_REQUEST = 20486;

        public static int VJ_SEARCH_KEYWORD_RESULT = 20487;

        public static int VJ_FAN_REMIND_REQUEST = 20488;

        public static int VJ_LISTEN_FAN_NOTIFICATION_REQUEST = 20499;

        public static int VJ_LISTEN_FAN_NOTIFICATION_RESULT = 20500;

        public static int VJ_CHANGE_FAN_REMIND_REQUEST = 20489;

        public static int VJ_CHANGE_FAN_REMIND_RESULT = 20496;

        public static int VJ_FAN_REMIND_CONFIG_REQUEST = 20497;

        public static int VJ_FAN_REMIND_CONFIG_RESULT = 20498;

        public static int GET_HOT_VJ_REQUEST = 20503;

        public static int GET_HOT_VJ_RESULT = 20504;

        public static int GET_NEW_PARTY_REQUEST = 20505;

        public static int GET_NEW_PARTY_RESULT = 20512;

        public static int GET_HOT_PARTY_REQUEST = 20513;

        public static int GET_HOT_PARTY_RESULT = 20514;

        public static int GET_RECOMMEND_PARTY_REQUEST = 20515;

        public static int GET_RECOMMEND_PARTY_RESULT = 20516;

        public static int GET_THEME_PARTY_REQUEST = 20517;

        public static int GET_THEME_PARTY_RESULT = 20518;

        public static int GET_PARTY_HISTORY_REQUEST = 20537;

        public static int GET_PARTY_HISTORY_RESULT = 20544;

        public static int GET_PARTY_THEMES_REQUEST = 20519;

        public static int GET_PARTY_THEMES_RESULT = 20520;

        public static int GET_COMMENT_VISIBLE_REQUEST = 20521;

        public static int GET_COMMENT_VISIBLE_RESULT = 20528;

        public static int GET_CHANGE_COMMENT_VISIBLE_REQUEST = 20529;

        public static int GET_CHANGE_COMMENT_VISIBLE_RESULT = 20530;

        public static int GET_PARTY_BUNDLE_REQUEST = 20531;

        public static int GET_PARTY_BUNDLE_RESULT = 20532;

        public static int GET_SELF_PARTY_REQUEST = 20547;

        public static int GET_SELF_PARTY_RESULT = 20548;

        public static int CHANNEL_PARTY_POPULAR_THEMES_REQUEST = 21783;

        public static int CHANNEL_PARTY_POPULAR_THEMES_RESULT = 21784;

        public static int CHANNEL_PARTY_CREATE_PARTY_REQUEST = 21785;

        public static int CHANNEL_PARTY_CREATE_PARTY_RESULT = 21798;

        public static int CHANNEL_PARTY_MASTER_THEMES_REQUEST = 21799;

        public static int CHANNEL_PARTY_MASTER_THEMES_RESULT = 21800;

        public static int CHANNEL_PARTY_CHECK_PARTY_CREATEABLE_REQUEST = 20533;

        public static int CHANNEL_PARTY_CHECK_PARTY_CREATEABLE_RESULT = 20534;

        public static int CHANNEL_PARTY_GET_USER_INFOMATION_REQUEST = 20535;

        public static int CHANNEL_PARTY_GET_USER_INFOMATION_RESULT = 20536;

        public static int CHANNEL_PARTY_GET_AREA_DESIGN_REQUEST = 20549;

        public static int CHANNEL_PARTY_GET_AREA_DESIGN_RESULT = 20550;

        public static int GET_PARTY_SKILL_REQUEST = 20553;

        public static int GET_PARTY_SKILL_RESULT = 20560;

        public static int CHANNEL_PARTY_GET_EVENT_REQUEST = 20551;

        public static int CHANNEL_PARTY_GET_EVENT_RESULT = 20552;

        public static int GET_PARTY_SKILL_EXECUTE_REQUEST = 20553;

        public static int GET_PARTY_SKILL_EXECUTE_RESULT = 20560;

        public static int NOTIFY_MYGAME_STATUS = 16896;

        public static int GET_MYGAME = 16897;

        public static int GET_MYGAME_RESULT = 16898;

        public static int GET_MYGAME_BUNDLE = 16899;

        public static int GET_MYGAME_BUNDLE_RESLUT = 16900;

        public static int SET_BIGG_EVENT_STATUS = 17920;

        public static int SET_BIGG_EVENT_STATUS_RESULT = 17921;

        public static int GET_BIGG_EVENT_STATUS = 17922;

        public static int GET_BIGG_EVENT_STATUS_RESULT = 17923;

        public static int GET_BIGG_EVENT_CONF_STATUS = 17924;

        public static int GET_BIGG_EVENT_CONF_STATUS_RESULT = 17925;

        public static int SET_BIGG_EVENT_RECORD = 17926;

        public static int SET_BIGG_EVENT_RECORD_RESULT = 17927;

        public static int GET_BIGG_EVENT_RECORD = 17928;

        public static int GET_BIGG_EVENT_RECORD_RESULT = 17929;

        public static int USER_SEEN_BEGINNER_HELP = 18176;

        public static int PPOINT_CAMPAIGN_LIST = 18432;

        public static int PPOINT_CAMPAIGN_LIST_RESULT = 18433;

        public static int PPOINT_CLEAR_CONDITION_INFO_RESULT = 18434;

        public static int PPOINT_PROVIDE_ITEM_LIST = 18435;

        public static int PPOINT_PROVIDE_ITEM_LIST_RESULT = 18436;

        public static int PPOINT_EXCHANGE_LIST = 18437;

        public static int PPOINT_EXCHANGE_LIST_RESULT = 18438;

        public static int PPOINT_DO_EXCHANGE = 18439;

        public static int PPOINT_DO_EXCHANGE_RESULT = 18440;

        public static int PPOINT_SEND_PROVISION_ID = 18441;

        public static int PPOINT_SEND_PROVISION_ID_RESULT = 18442;

        public static int UNREAD_CROSS_ANNOUNCE_RESULT = 18443;

        public static int CHECK_CROSS_ANNOUNCE = 18444;

        public static int CHECK_CROSS_ANNOUNCE_RESULT = 18445;

        public static int PPOINT_CAMPAIGN_CLEAR = 18446;

        public static int ONE_MESSAGE_SAVE = 370;

        public static int LIST_STAMP = 18688;

        public static int LIST_STAMP_RESULT = 18689;

        public static int ANNOUNCE_GAME_BAR_RESULT = 8985;

        public static int CHECK_ANNOUNCE_GAME_BAR = 8992;

        public static int END_ANNOUNCE_GAME_BAR = 8993;

        public static int CHECK_COMEBACK_CAMPAIGN = 20736;

        public static int CHECK_COMEBACK_CAMPAIGN_RESULT = 20737;

        public static int GET_COMEBACK_CAMPAIGN = 20738;

        public static int GET_COMEBACK_CAMPAIGN_RESULT = 20739;

        public static int LIST_COMEBACK_CAMPAIGN_TARGET_USERS = 20740;

        public static int LIST_COMEBACK_CAMPAIGN_TARGET_USERS_RESULT = 20741;

        public static int SEND_COMEBACK_CAMPAIGN = 20742;

        public static int SEND_COMEBACK_CAMPAIGN_RESULT = 20743;

        public static int LIST_COMEBACK_CAMPAIGN_SENT_USERS = 20744;

        public static int LIST_COMEBACK_CAMPAIGN_SENT_USERS_RESULT = 20745;

        public static int GET_COMEBACK_CAMPAIGN_REWARDS = 20752;

        public static int GET_COMEBACK_CAMPAIGN_REWARDS_RESULT = 20753;

        public static int OPEN_CONTEST_PANEL = 20754;

        public static int OPEN_CONTEST_PANEL_RESULT = 20755;

        public static int GET_CONTEST_LIST_PAGE = 20756;

        public static int GET_CONTEST_LIST_PAGE_REUSLT = 20757;

        public static int OPEN_CONTEST_USER_PANEL = 20758;

        public static int OPEN_CONTEST_USER_PANEL_RESULT = 20759;

        public static int SEND_NICE = 20762;

        public static int SEND_NICE_RESULT = 20763;

        public static int SEND_USER_POST = 20764;

        public static int SEND_USER_POST_RESULT = 20765;

        public static int UPDATE_CONTEST_OPEN_SETTING = 20766;

        public static int UPDATE_CONTEST_OPEN_SETTING_RESULT = 20767;

        public static int SHOW_CONTEST_ICON = 20768;

        public static int GET_CONTEST_ARCHIVE = 20769;

        public static int GET_CONTEST_ARCHIVE_RESULT = 20770;

        public static int NOTIFY_GATHER_TIME = 21506;

        public static int LIST_TRAINING = 20992;

        public static int LIST_TRAINING_RESULT = 20993;

        public static int GET_TRAINING_ICON = 20994;

        public static int GET_TRAINING_ICON_RESULT = 20995;

        public static int CLEAR_TRAINING = 20996;

        public static int SEND_GIFT_LOG = 156;

        public static int CHECK_AMEGOLD_EXCHANGEABLE_FOR_AS_COIN = 21248;

        public static int CHECK_AMEGOLD_EXCHANGEABLE_FOR_AS_COIN_RESULT = 21249;

        public static int EXCHANGE_AMEGOLD_FOR_AS_COIN = 21250;

        public static int EXCHANGE_AMEGOLD_FOR_AS_COIN_RESULT = 21251;

        public static int LIMIT_COIN_NOTIFICATION_RESULT = 21265;

        public static int GET_AMEBA_SOCIAL_MAINTENANCE = 21760;

        public static int AMEBA_SOCIAL_MAINTENANCE_RESULT = 21761;

        public static int GET_STORAGE_ARCHIVE_LIST = 22016;

        public static int GET_STORAGE_ARCHIVE_LIST_RESULT = 22017;

        public static int UPDATE_STORAGE_ARCHIVE_TITLE = 22018;

        public static int UPDATE_STORAGE_ARCHIVE_TITLE_RESULT = 22019;

        public static int GET_BEGINNER_SHOP = 22528;

        public static int GET_BEGINNER_SHOP_RESULT = 22529;

        public static int BEGINNER_SHOP_ICON = 22530;

        public static int GET_BEGINNER_SHOP_ANNOUNCE_RESULT = 22531;

        public static int BUY_BEGINNER_SHOP_ITEM = 22532;

        public static int BUY_BEGINNER_SHOP_ITEM_RESULT = 22533;

        public static int PROVIDE_DIARY = 22272;

        public static int PROVIDE_DIARY_RESULT = 22273;

        public static int GET_DIARY = 22274;

        public static int GET_DIARY_RESULT = 22275;

        public static int GET_DIARY_PAGE_MORE = 22276;

        public static int GET_DIARY_PAGE_MORE_RESULT = 22277;

        public static int GET_DIARY_CONFIG = 22278;

        public static int GET_DIARY_CONFIG_RESULT = 22279;

        public static int SAVE_DIARY_CONFIG = 22280;

        public static int SAVE_DIARY_CONFIG_RESULT = 22281;

        public static int SEND_DIARY_MITAYO = 22282;

        public static int SEND_DIARY_MITAYO_RESULT = 22283;

        public static int GET_DIARY_COMMENT_MORE = 22284;

        public static int GET_DIARY_COMMENT_MORE_RESULT = 22285;

        public static int REMOVE_DIARY_COMMENT = 22286;

        public static int REMOVE_DIARY_COMMENT_RESULT = 22287;

        public static int SAVE_DIARY_COMMENT = 22288;

        public static int SAVE_DIARY_COMMENT_RESULT = 22289;

        public static int SAVE_DIARY_PAGE = 22290;

        public static int SAVE_DIARY_PAGE_RESULT = 22291;

        public static int EDIT_DIARY_PAGE = 22292;

        public static int EDIT_DIARY_PAGE_RESULT = 22293;

        public static int REMOVE_DIARY_PAGE = 22294;

        public static int REMOVE_DIARY_PAGE_RESULT = 22295;

        public static int GET_DIARY_NOTIFICATION = 22296;

        public static int GET_DIARY_NOTIFICATION_RESULT = 22297;

        public static int GET_DIARY_MITAYO_USER = 22304;

        public static int GET_DIARY_MITAYO_USER_RESULT = 22305;

        public static int GET_DIARY_IMAGE_LIST = 22306;

        public static int GET_DIARY_IMAGE_LIST_RESULT = 22307;

        public static int UPDATE_READ_DIARY_NOTIFICATION = 22308;

        public static int UPDATE_READ_DIARY_NOTIFICATION_RESULT = 22309;

        public static int UPDATE_READ_ALL_DIARY_NOTIFICATION = 22310;

        public static int UPDATE_READ_ALL_DIARY_NOTIFICATION_RESULT = 22311;

        public static int GET_DIARY_PAGE_FROM_NOTIFICATION = 22312;

        public static int GET_DIARY_PAGE_FROM_NOTIFICATION_RESULT = 22313;

        public static int REMOVE_DIARY_IMAGE = 22314;

        public static int REMOVE_DIARY_IMAGE_RESULT = 22315;
    }
}
