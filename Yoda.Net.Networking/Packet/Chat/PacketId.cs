using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Packet.Chat
{
    class PacketId
    {
        public static int ERROR = -255;

        public static int CHECK_AREA = 16;

        public static int CHECK_AREA_RESULT = 17;

        public static int LOGIN_CHAT = 32;

        public static int LOGIN_CHAT_RESULT = 33;

        public static int UPDATE_POINT_RESULT = 47;

        public static int NOTIFICATION = 144;

        public static int ALERT_RESULT = 149;

        public static int ENTER_ROOM = 256;

        public static int ENTER_AREA_RESULT = 257;

        public static int ENTER_QUEUE_RESULT = 258;

        public static int ENTER_QUEUE_START_RESULT = 259;

        public static int ENTER_ROOM_FULL_RESULT = 260;

        public static int ENTER_ROOM_READY_RESULT = 261;

        public static int ENTER_ROOM_EXECUTE = 262;

        public static int ENTER_USER_ROOM_RESULT = 273;

        public static int ENTER_USER_GARDEN_RESULT = 274;

        public static int MOVE_USER_ROOM = 275;

        public static int ENTER_QUEUE_CANCEL = 276;

        public static int ENTER_QUEUE_CANCEL_RESULT = 277;

        public static int FORCE_MOVE = 263;

        public static int FORCE_MOVE_RESULT = 264;

        public static int MOVE = 512;

        public static int MOVE_RESULT = 513;

        public static int MOVE_END = 514;

        public static int MOVE_END_RESULT = 515;

        public static int TIRED = 516;

        public static int TIRED_RESULT = 517;

        public static int APPEAR_USER = 528;

        public static int LEAVE_USER = 544;

        public static int APPEAR_FRIEND_USER = 545;

        public static int MOVE_FROM_TO = 546;

        public static int MOVE_FROM_TO_RESULT = 547;

        public static int PLACE_FURNITURE = 768;

        public static int PLACE_FURNITURE_RESULT = 769;

        public static int MOVE_FURNITURE = 784;

        public static int MOVE_FURNITURE_RESULT = 785;

        public static int REMOVE_FURNITURE = 800;

        public static int REMOVE_FURNITURE_RESULT = 801;

        public static int CHANGE_ROOM = 816;

        public static int CHANGE_ROOM_RESULT = 817;

        public static int RESET_ROOM = 818;

        public static int CHANGE_WINDOW_AQUARIUM = 825;

        public static int CAHNGE_WINDOW_AQUARIUM_RESULT = 826;

        public static int CHANGE_ROOM_SIZE = 819;

        public static int CHANGE_ROOM_SIZE_RESULT = 820;

        public static int CHANGE_ROOM_SIZE_RESULT_POINT = 821;

        public static int ADD_SUB_ROOM = 822;

        public static int ADD_SUB_ROOM_RESULT = 823;

        public static int ADD_SUB_ROOM_RESULT_POINT = 824;

        public static int CHANGE_GARDEN_SIZE_RESULT = 829;

        public static int PLACE_ACTION_ITEM = 928;

        public static int PLACE_ACTION_ITEM_RESULT = 929;

        public static int REMOVE_ACTION_ITEM = 930;

        public static int REMOVE_ACTION_ITEM_RESULT = 931;

        public static int UPDATE_ACTION_ITEM_RESULT = 932;

        public static int MOVE_ACTION_ITEM = 933;

        public static int MOVE_ACTION_ITEM_RESULT = 934;

        public static int USE_ACTION_ITEM = 935;

        public static int USE_ACTION_ITEM_RESULT = 936;

        public static int OPEN_GIFT_ITEM = 937;

        public static int OPEN_GIFT_ITEM_RESULT = 938;

        public static int OPEN_ALL_ACTION_ITEM = 939;

        public static int OPEN_ALL_ACTION_ITEM_RESULT = 940;

        public static int PLACE_GIFT = 941;

        public static int GIFT_USER_ACTION = 942;

        public static int TALK = 1024;

        public static int TALK_RESULT = 1025;

        public static int ECHO = 1026;

        public static int ECHO_RESULT = 1027;

        public static int ECHO_CLEAR = 1028;

        public static int TALKLOG_RESULT = 1029;

        public static int TYPING = 1030;

        public static int TYPING_RESULT = 1031;

        public static int CANCEL_TYPING = 1032;

        public static int CANCEL_TYPING_RESULT = 1033;

        public static int STAMP = 1088;

        public static int STAMP_RESULT = 1089;

        public static int ACTION = 1040;

        public static int ACTION_RESULT = 1041;

        public static int ROOM_ACTION = 1042;

        public static int ROOM_ACTION_RESULT = 1043;

        public static int SYSTEM_ACTION = 1044;

        public static int SYSTEM_ACTION_RESULT = 1045;

        public static int ADD_CONDITION_RESULT = 1050;

        public static int REMOVE_CONDITION_RESULT = 1051;

        public static int USER_EFFECT_RESULT = 1052;

        public static int START_DRESSUP = 1056;

        public static int START_DRESSUP_RESULT = 1057;

        public static int FINISH_DRESSUP = 1058;

        public static int FINISH_DRESSUP_RESULT = 1058;

        public static int START_DRESSUP_MANNEQUIN = 1059;

        public static int START_DRESSUP_MANNEQUIN_RESULT = 1060;

        public static int FINISH_DRESSUP_MANNEQUIN = 1061;

        public static int FINISH_DRESSUP_MANNEQUIN_RESULT = 1062;

        public static int BAN_USER = 1071;

        public static int BALLOON_CHANGE = 1072;

        public static int BALLOON_CHANGE_RESULT = 1073;

        public static int USE_FURNITURE = 1536;

        public static int USE_FURNITURE_RESULT = 1537;

        public static int GAME_JOIN = 2048;

        public static int GAME_JOIN_RESULT = 2049;

        public static int GAME_READY = 2050;

        public static int GAME_READY_RESULT = 2051;

        public static int GAME_LEAVE = 2052;

        public static int GAME_LEAVE_RESULT = 2053;

        public static int GAME_DATA = 2054;

        public static int GAME_RESULT_DATA = 2055;

        public static int TABLE_GAME = 2064;

        public static int TABLE_GAME_RESULT = 2065;

        public static int TABLE_GAME_SHOW_RESULT = 2066;

        public static int TABLE_GAME_TALK = 2067;

        public static int TABLE_GAME_TALK_RESULT = 2068;

        public static int TABLE_GAME_ACTION = 2069;

        public static int TABLE_GAME_ACTION_RESULT = 2070;

        public static int TABLE_GAME_ABORT_RESULT = 2071;

        public static int TABLE_GAME_HIDE = 2072;

        public static int CASINO_UPDATE_BALANCE_RESULT = 2096;

        public static int CASINO_GAME_JOIN_REQUEST = 2097;

        public static int CASINO_USE_LUCKY_ITEM_RESULT = 2100;

        public static int CASINO_GAME_LEAVE = 2101;

        public static int CASINO_FEVER_TIME_MODULE_UPDATE_RESULT = 2102;

        public static int CASINO_FEVER_TIME_MODULE_SHOW_REQUEST = 2103;

        public static int CASINO_ROYALE_FEVERTIME_DATA_REQUEST = 2104;

        public static int CASINO_ROYALE_FEVERTIME_DATA_RESULT = 2105;

        public static int CASINO_ROYALE_FEVERTIME_NOTIFY_RESULT = 2112;

        public static int CASINO_ROYALE_JACKPOT_INCENTIVE_RESULT = 2113;

        public static int GIVE_GOOD = 1792;

        public static int UPDATE_GOOD_RESULT = 1794;

        public static int GOOD_PIGG_RESULT = 1795;

        public static int PET_PLACE_RESULT = 2305;

        public static int PET_LEAVE_RESULT = 2306;

        public static int PET_ACTION_RESULT = 2307;

        public static int PET_MOVE = 2308;

        public static int PET_MOVE_RESULT = 2309;

        public static int PET_MOVE_END = 2310;

        public static int PET_MOVE_END_RESULT = 2311;

        public static int PET_PREPARE_BUY = 2312;

        public static int PET_PREPARE_BUY_RESULT = 2313;

        public static int PET_APPEAR_RESULT = 2314;

        public static int PET_PLACE = 2315;

        public static int PET_ACTION = 2316;

        public static int PET_TALK_RESULT = 2317;

        public static int PET_FURNITURE_ACTION = 2318;

        public static int PET_TREASURE_PROFILE = 2319;

        public static int PET_TREASURE_PROFILE_RESULT = 2320;

        public static int UPDATE_NUM_FOOTPRINT_TODAY = 4097;

        public static int MISSION_COMPLETE = 2560;

        public static int MISSION_COMPLETE_RESULT = 2561;

        public static int STREAMING_SCHEDULER_RESULT = 2576;

        public static int STREAMING_SCHEDULER_USER = 2577;

        public static int STREAMING_SCHEDULER_USER_RESULT = 2578;

        public static int CAMPAIGN_PONTA_GIVE_POINT = 1808;

        public static int CAMPAIGN_PONTA_GIVE_POINT_RESULT = 1809;

        public static int CAMPAIGN_PONTA_CHECK_POINT = 1810;

        public static int CAMPAIGN_PONTA_CHECK_POINT_RESULT = 1811;

        public static int MOVE_NPC = 3072;

        public static int FRIEND_REQUEST_SEND = 3123;

        public static int START_SOCIAL_GAME = 1098;

        public static int START_SOCIAL_GAME_RESULT = 1099;

        public static int FINISH_SOCIAL_GAME = 1100;

        public static int FINISH_SOCIAL_GAME_RESULT = 1101;

        public static int START_SHOP = 1066;

        public static int START_SHOP_RESULT = 1067;

        public static int FINISH_SHOP = 1068;

        public static int FINISH_SHOP_RESULT = 1069;

        public static int START_GACHA = 1082;

        public static int START_GACHA_RESULT = 1083;

        public static int FINISH_GACHA = 1084;

        public static int FINISH_GACHA_RESULT = 1085;

        public static int START_MENKOGACHA = 1114;

        public static int START_MENKOGACHA_RESULT = 1115;

        public static int FINISH_MENKOGACHA = 1116;

        public static int FINISH_MENKOGACHA_RESULT = 1117;

        public static int START_CINEMA_BALLOON = 1130;

        public static int START_CINEMA_BALLOON_RESULT = 1131;

        public static int FINISH_CINEMA_BALLOON = 1132;

        public static int FINISH_CINEMA_BALLOON_RESULT = 1133;

        public static int CHANNEL_CONFIG_RESULT = 2592;

        public static int PIGG_CHANNEL_PROGRAM_INFO_RESULT = 2594;

        public static int AKIBA_MONITOR_DATA = 3088;

        public static int SEND_GAME_ACTIVITY_DATA = 3104;

        public static int CHANNEL_FLOOR_ENTER_ROOM = 2598;

        public static int CHANNEL_FLOOR_UPDATE_NICO_REQUEST = 2599;

        public static int CHANNEL_FLOOR_UPDATE_NICO_RESULT = 2600;

        public static int CHANNEL_FLOOR_UPDATE_MOYA_REQUEST = 2604;

        public static int CHANNEL_FLOOR_UPDATE_MOYA_RESULT = 2605;

        public static int CHANNEL_FLOOR_UPDATE_FAN_REQUEST = 2602;

        public static int CHANNEL_FLOOR_UPDATE_FAN_RESULT = 2603;

        public static int CHANNEL_FLOOR_TUTORIAL = 2614;

        public static int CHANNEL_FLOOR_TUTORIAL_END = 2613;

        public static int CHANNEL_FLOOR_UPDATE_BOOTH_STATE_REQUEST = 24579;

        public static int CHANNEL_FLOOR_UPDATE_BOOTH_STATE_RESULT = 2596;

        public static int CHANNEL_FLOOR_UPDATE_PROGRAM_REQUEST = 24836;

        public static int CHANNEL_FLOOR_UPDATE_PROGRAM_RESULT = 2597;

        public static int CHANNEL_FLOOR_NOTIFY_SKIP_PROGRAM = 24835;

        public static int CHANNEL_FLOOR_PLAYER_INFO_REQUEST = 2611;

        public static int CHANNEL_FLOOR_PLAYER_INFO_RESULT = 2612;

        public static int CHANNEL_FLOOR_UPDATE_PLAYLIST_REQUEST = 2624;

        public static int CHANNEL_FLOOR_UPDATE_PLAYLIST_RESULT = 2625;

        public static int CHANNEL_FLOOR_NEXT_PROGRAM_REQUEST = 2626;

        public static int CHANNEL_FLOOR_NEXT_PROGRAM_RESULT = 2627;

        public static int CHANNEL_FLOOR_ROOM_HISTORY_REQUEST = 24837;

        public static int CHANNEL_FLOOR_ROOM_HISTORY_RESULT = 24838;

        public static int CHANNEL_PARTY_AVATAR_DATA_REQUEST = 25089;

        public static int CHANNEL_PARTY_AVATAR_DATA_RESULT = 25090;

        public static int CHANNEL_PARTY_SYNC_REQUEST = 25091;

        public static int CHANNEL_PARTY_SYNC_CLEAR_REQUEST = 1028;

        public static int CHANNEL_PARTY_SYNC_RESULT = 25092;

        public static int CHANNEL_PARTY_ENTER_ROOM = 25093;

        public static int CHANNEL_PARTY_UPDATE_PROGRAM_REQUEST = 2628;

        public static int CHANNEL_PARTY_UPDATE_PROGRAM_RESULT = 2629;

        public static int CHANNEL_PARTY_UPDATE_BOOTH_STATUS_REQUEST = 2632;

        public static int CHANNEL_PARTY_UPDATE_BOOTH_STATUS_RESULT = 2633;

        public static int CHANNEL_PARTY_UPDATE_PLAYLIST_REQUEST = 2641;

        public static int CHANNEL_PARTY_UPDATE_PLAYLIST_RESULT = 2642;

        public static int CHANNEL_PARTY_NOTIFY_SKIP_PROGRAM = 2657;

        public static int CHANNEL_PARTY_UPDATE_NICO_REQUEST = 2659;

        public static int CHANNEL_PARTY_UPDATE_NICO_RESULT = 2660;

        public static int CHANNEL_PARTY_UPDATE_MOYA_REQUEST = 0;

        public static int CHANNEL_PARTY_UPDATE_MOYA_RESULT = 0;

        public static int CHANNEL_PARTY_GET_BOOTHCATALOG_REQUEST = 2661;

        public static int CHANNEL_PARTY_GET_BOOTHCATALOG_RESULT = 2662;

        public static int CHANNEL_PARTY_UPDATE_SELECT_BOOTH_REQUEST = 2663;

        public static int CHANNEL_PARTY_UPDATE_SELECT_BOOTH_RESULT = 2664;

        public static int CHANNEL_PARTY_NEXT_PROGRAM_REQUEST = 2673;

        public static int CHANNEL_PARTY_NEXT_PROGRAM_RESULT = 2674;

        public static int CHANNEL_PARTY_FORCE_MOVE_REQUEST = 2665;

        public static int CHANNEL_PARTY_FORCE_MOVE_RESULT = 2672;

        public static int CHANNEL_PARTY_FORCE_CLOSE_RESULT = 2677;

        public static int CHANNEL_PARTY_REMOVE_FURNITURE = 2675;

        public static int SEND_PENALTY_WEAK = 266;

        public static int SEND_PENALTY_MIDDLE = 267;

        public static int SEND_PENALTY_STRONG = 268;

        public static int SEND_PENALTY_RESULT = 271;

        public static int RECEIVE_PENALTY_RESULT = 272;

        public static int ENTER_ROOM_CHECK_RESULT = 278;

        public static int CREATE_GARDEN = 827;

        public static int CREATE_GARDEN_RESULT = 828;

        public static int FLASH_OVERREACTION_RESULT = 1046;

        public static int ROOM_LOGIC_SET_MOVE = 2817;

        public static int ROOM_LOGIC_SET_MOVE_RESULT = 2818;

        public static int ROOM_LOGIC_SET_MOVE_BROADCAST = 2819;

        public static int ROOM_LOGIC_GET_MOVE = 2820;

        public static int ROOM_LOGIC_GET_MOVE_RESULT = 2821;

        public static int ROOM_LOGIC_SET_MOVE_AND_TIME = 2822;

        public static int ROOM_LOGIC_SET_MOVE_AND_TIME_RESULT = 2823;

        public static int ROOM_LOGIC_SET_MOVE_AND_TIME_BROADCAST = 2824;

        public static int ROOM_LOGIC_UPDATE_MOVE_AND_TIME = 2825;

        public static int ROOM_LOGIC_UPDATE_MOVE_AND_TIME_RESULT = 2826;

        public static int ROOM_LOGIC_UPDATE_MOVE_AND_TIME_BROADCAST = 2827;

        public static int ROOM_LOGIC_GET_MOVE_AND_TIME = 2828;

        public static int ROOM_LOGIC_GET_MOVE_AND_TIME_RESULT = 2829;

        public static int UPDATE_FRIEND_REQUESTABLE = 3120;

        public static int LIST_FRIEND_REQUESTABLE = 3121;

        public static int LIST_FRIEND_REQUESTABLE_RESULT = 3122;

        public static int FRIEND_ALLOW_UPDATE = 3124;

        public static int CHECK_RESTORE_STORAGE_ARCHIVE = 3328;

        public static int CHECK_RESTORE_STORAGE_ARCHIVE_RESULT = 3329;

        public static int RESTORE_STORAGE_ARCHIVE = 3330;

        public static int RESTORE_STORAGE_ARCHIVE_RESULT = 3331;

        public static int RE_ENTER_ROOM_AFTER_STORAGE_ARCHIVE = 3332;

        public static int SAVE_STORAGE_ARCHIVE = 3333;

        public static int SAVE_STORAGE_ARCHIVE_RESULT = 3334;

        public static int RESTORE_STORAGE_WITH_MANNEQUIN_RESULT = 3335;

        public static int START_MAKEUP = 9472;

        public static int START_MAKEUP_RESULT = 9473;

        public static int FINISH_MAKEUP = 9474;

        public static int FINISH_MAKEUP_RESULT = 9475;

        public static int CHECK_PLACE_COSMETIC_ITEM = 9482;

        public static int CHECK_PLACE_COSMETIC_ITEM_RESULT = 9483;

        public static int PLACE_COSMETIC_ITEM = 9476;

        public static int PLACE_COSMETIC_ITEM_RESULT = 9477;

        public static int MOVE_COSMETIC_ITEM = 9478;

        public static int MOVE_COSMETIC_ITEM_RESULT = 9479;

        public static int REMOVE_COSMETIC_ITEM = 9480;

        public static int REMOVE_COSMETIC_ITEM_RESULT = 9481;

        public static int MENKO_NOTE_RESULT = 9728;

        public static int PPOINT_CLEAR_CONDITION_CHAT_RESULT = 9984;

        public static int CLEAR_TRAINING_CHAT = 10000;

        public static int CHECK_AREA_GAME = 12288;

        public static int CHECK_AREA_GAME_RESULT = 12289;

        public static int AREA_GAME_JOIN = 12290;

        public static int AREA_GAME_JOIN_RESULT = 12291;

        public static int AREA_GAME_LEAVE = 12292;

        public static int AREA_GAME_LEAVE_RESULT = 12293;

        public static int AREA_GAME_PLAY = 12294;

        public static int AREA_GAME_PLAY_RESULT = 12295;

        public static int AREA_GAME_FIELD = 12296;

        public static int AREA_GAME_FIELD_RESULT = 12297;

        public static int AMEBA_SOCIAL_MAINTENANCE_RESULT = 21760;
        public static readonly int POYON_FINISH_DRESSUP = 3152;
        public static readonly int POYON_LOGIN_CHAT = 2000;
        public static readonly int POYON_PROVIDE_DEFINE = 9871;

    }
}

