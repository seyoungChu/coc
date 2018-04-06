using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;


// global enum,상수들을 모아 놓는 스크립트.
#region //++Data Class Definition

#region Building_Normal Xml Serialize Class
[XmlRoot(ElementName = "root")]
public class BuildingNormalXmlRootData
{
    [XmlElement("BuildingNormal")]
    public List<BuildingNormalXmlData> BuildingNormalDataList { get; set; }

    public BuildingNormalXmlRootData()
    {
        BuildingNormalDataList = new List<BuildingNormalXmlData>();
    }
}

public class BuildingNormalXmlData
{
    [XmlElement("ID")]
    public int ID { get; set; }

    [XmlElement("bd_group_ID")]
    public int GroupID { get; set; }

    [XmlElement("level")]
    public int Level { get; set; }

    [XmlElement("HP")]
    public int Hp { get; set; }

    [XmlElement("area")]
    public int Area { get; set; }

    [XmlElement("bd_type")]
    public string Type { get; set; }

    [XmlElement("bd_group_type")]
    public string Group_Type { get; set; }

    [XmlElement("upgrade_resource_type")]
    public int Upgrade_Resource_Type { get; set; }

    [XmlElement("upgrade_resource_value")]
    public int Upgrade_Resource_Value { get; set; }

    [XmlElement("building_time")]
    public int Building_Time { get; set; }

    [XmlElement("upgrade_user_lv_limit")]
    public int Upgrade_User_Lv_Limit { get; set; }

    [XmlElement("upgrade_cp_lv_limit")]
    public int Upgrade_Cp_Lv_Limit { get; set; }

    [XmlElement("ame_max_capacity")]
    public int Ame_Capacity { get; set; }

    [XmlElement("acid_max_capacity")]
    public int Acid_Capacity { get; set; }

    [XmlElement("aqua_max_capacity")]
    public int Aqua_Capacity { get; set; }

    [XmlElement("gain_type")]
    public int Gain_Type { get; set; }

    [XmlElement("gain_quantity")]
    public int Gain_Quantity { get; set; }

    [XmlElement("gain_icon_quantity")]
    public int Gain_Icon_Quantity { get; set; }

    [XmlElement("human_limit")]
    public int Human_Limit { get; set; }

    [XmlElement("sight_range")]
    public int Sight_Range { get; set; }

    [XmlElement("is_moveable")]
    public int IsMoveable { get; set; }

    [XmlElement("icon")]
    public string Icon { get; set; }

    [XmlElement("prefabs")]
    public string Prefabs { get; set; }

    [XmlElement("mainidle_ani")]
    public int mainIdle_ani { get; set; }

    [XmlElement("headidle_ani")]
    public int headidle_ani { get; set; }

    [XmlElement("operation_ani")]
    public int operation_ani { get; set; }

    [XmlElement("rs_ani")]
    public int rs_ani { get; set; }

    [XmlElement("animation_level_bottom")]
    public int animation_level_bottom { get; set; }

    [XmlElement("animation_level_top")]
    public int animation_level_top { get; set; }

    [XmlElement("animation_level_resource")]
    public int animation_level_resource { get; set; }

    [XmlElement("text_key")]
    public int Text_Key { get; set; }

    [XmlElement("building_time_type")]
    public string building_time_type { get; set; }

    [XmlElement("gain_quantity_type")]
    public string gain_quantity_type { get; set; }

}
#endregion

#region Building_Defence Xml Serialize Class

//일반건물 데이터
[XmlRoot(ElementName = "root")]
public class BuildingDefenceXmlRootData
{
    [XmlElement("BuildingDefence")]
    public List<BuildingDefenceXmlData> BuildingDefenceData { get; set; }

    public BuildingDefenceXmlRootData()
    {
        BuildingDefenceData = new List<BuildingDefenceXmlData>();
    }
}

//방어건물 데이터
public class BuildingDefenceXmlData
{
    [XmlElement("ID")]
    public int ID { get; set; }

    [XmlElement("bd_group_ID")]
    public int GroupID { get; set; }

    [XmlElement("level")]
    public int Level { get; set; }

    [XmlElement("HP")]
    public int Hp { get; set; }

    [XmlElement("area")]
    public int Area { get; set; }

    [XmlElement("bd_type")]
    public string Type { get; set; }

    [XmlElement("bd_group_type")]
    public string Group_Type { get; set; }

    [XmlElement("upgrade_resource_type")]
    public int Upgrade_Resource_Type { get; set; }

    [XmlElement("upgrade_resource_value")]
    public int Upgrade_Resource_Value { get; set; }

    [XmlElement("building_time")]
    public int Building_Time { get; set; }

    [XmlElement("upgrade_cp_lv_limit")]
    public int Upgrade_Cp_Lv_Limit { get; set; }

    [XmlElement("target_type")]
    public int Target_Type { get; set; }

    [XmlElement("first_target")]
    public int first_target { get; set; }

    [XmlElement("target_site")]
    public int Target_Site { get; set; }

    [XmlElement("first_atk_delay")]
    public float First_Atk_Delay { get; set; }

    [XmlElement("attack_speed")]
    public float Attack_Speed { get; set; }

    [XmlElement("sight_range")]
    public float Sight_Range { get; set; }

    [XmlElement("attack_range_min")]
    public float Attack_Range_Min { get; set; }

    [XmlElement("attack_range_max")]
    public float Attack_Range_Max { get; set; }

    [XmlElement("attack_type")]
    public string Attack_Type { get; set; }

    [XmlElement("attack_power")]
    public float attack_power { get; set; }

    [XmlElement("bullet_ID")]
    public int bullet_ID { get; set; }

    [XmlElement("barrel_trace")]
    public int Barrel_Trace { get; set; }

    [XmlElement("offset")]
    public int Offset { get; set; }

    [XmlElement("icon")]
    public string Icon { get; set; }

    [XmlElement("prefabs")]
    public string Prefabs { get; set; }

    [XmlElement("mainidle_ani")]
    public int mainidle_ani { get; set; }

    [XmlElement("headidle_ani")]
    public int headidle_ani { get; set; }

    [XmlElement("operation_ani")]
    public int operation_ani { get; set; }

    [XmlElement("animation_level_bottom")]
    public int animation_level_bottom { get; set; }

    [XmlElement("animation_level_top")]
    public int animation_level_top { get; set; }

    [XmlElement("hit_timing")]
    public int hit_timing { get; set; }

    [XmlElement("hit_timing_bullet")]
    public int hit_timing_bullet { get; set; }

    [XmlElement("text_key")]
    public int Text_Key { get; set; }

    [XmlElement("time_type")]
    public string time_type { get; set; }

}

#endregion

#region Building_Maxquantity Xml Serialize Class

//cp레벨에 따른 건물 수량 제한 데이터
[XmlRoot(ElementName = "root")]
public class Building_MaxQuantityRootData
{
    [XmlElement("Building_MaxQuantity")]
    public List<Building_MaxQuantity> BuildingMaxquantityDataList { get; set; }

    public Building_MaxQuantityRootData()
    {
        BuildingMaxquantityDataList = new List<Building_MaxQuantity>();
    }
}

//건물 수량 제한 데이터
public class Building_MaxQuantity
{
    [XmlElement("bd_group_ID")]
    public int GroupID { get; set; }

    [XmlElement("CP_level_1")]
    public int CP_level_1 { get; set; }

    [XmlElement("CP_level_2")]
    public int CP_level_2 { get; set; }

    [XmlElement("CP_level_3")]
    public int CP_level_3 { get; set; }

    [XmlElement("CP_level_4")]
    public int CP_level_4 { get; set; }

    [XmlElement("CP_level_5")]
    public int CP_level_5 { get; set; }

    [XmlElement("CP_level_6")]
    public int CP_level_6 { get; set; }

    [XmlElement("CP_level_7")]
    public int CP_level_7 { get; set; }

    [XmlElement("CP_level_8")]
    public int CP_level_8 { get; set; }

    [XmlElement("CP_level_9")]
    public int CP_level_9 { get; set; }
}

#endregion

#region buildingMaxQuantityData
public struct buildingMaxQuantityData
{
    public List<int> quantityListbyCpLevel;
}

#endregion

#region Building_Text Xml Serialize Class

//빌딩 이름 및 설명 텍스트데이터 묶음
[XmlRoot(ElementName = "root")]
public class Building_TextRootData
{
    [XmlElement("Building_Text")]
    public List<Building_Text> BuildingTextDataList { get; set; }

    public Building_TextRootData()
    {
        BuildingTextDataList = new List<Building_Text>();
    }
}

//빌딩 이름 및 설명 텍스트데이터
public class Building_Text
{
    [XmlElement("text_key")]
    public int textKey { get; set; }

    [XmlElement("name")]
    public string name { get; set; }

    [XmlElement("desc")]
    public string desc { get; set; }

}

#endregion

#region BuildingData class

//전체 건물 데이터 클래스
public class BuildingData
{
    //레벨이 포함된 id
    public int ID { get; set; }
    //건물종류 id - 숫자
    public int GroupID { get; set; }
    //레벨
    public int Level { get; set; }
    //체력
    public int Hp { get; set; }
    //건물의 타일사이즈 (2,3,5)
    public int Area { get; set; }
    //건물의 종류-문자
    public string Type { get; set; }
    //건물의 그룹타입
    public BuildingGroupType Group_Type { get; set; }
    //업그레이드 자원수치.
    public int Upgrade_Resource_Type { get; set; }
    /// <summary>
    /// 업그레이드시 소요되는 자원양.
    /// </summary>
    public int Upgrade_Resource_Value { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int Upgrade_User_Lv_Limit { get; set; }
    public int Ame_Capacity { get; set; }
    public int Acid_Capacity { get; set; }
    public int Aqua_Capacity { get; set; }
    public int Gain_Type { get; set; }
    public int Gain_Quantity { get; set; }
    public int Gain_Icon_Quantity { get; set; }
    public int Human_Limit { get; set; }
    public int IsMoveable { get; set; }
    public string Icon { get; set; }
    public int rs_ani { get; set; }
    public int animation_level_bottom { get; set; }
    public int animation_level_top { get; set; }
    public int animation_level_resource { get; set; }
    public string building_time_type { get; set; } //빌딩 업그레이드 시간 타입
    public string gain_quantity_type { get; set; } //시간당 획득량 시간 타입

    /// <summary>
    /// 타겟 형식. 0 = 범위내 전체적용 1 = 싱글 타겟 n = 범위내 최대 n 까지.
    /// </summary>
    public int Target_Type { get; set; }
    /// <summary>
    /// 선호타겟, unit_groud_ID로 구분.
    /// </summary>
    public int first_target { get; set; }
    /// <summary>
    /// 0 = ground, 1 = air, 2 = ground, air
    /// </summary>
    public int Target_Site { get; set; }
    /// <summary>
    /// 최초 공격 전 선 딜레이.
    /// </summary>
    public float First_Atk_Delay { get; set; }
    /// <summary>
    /// 공격간 인터벌.
    /// </summary>
    public float Attack_Speed { get; set; }
    /// <summary>
    /// 공격 거리 최소.
    /// </summary>
    public float Attack_Range_Min { get; set; }
    /// <summary>
    /// 공격 거리 최대.
    /// </summary>
    public float Attack_Range_Max { get; set; }
    /// <summary>
    /// 공격 타입. range, artillary, beam, flame, vls, paralyze.
    /// </summary>
    public string Attack_Type { get; set; }
    /// <summary>
    /// 공격력
    /// </summary>
    public float attack_power { get; set; }
    /// <summary>
    /// 투사체 리소스.
    /// </summary>
    public string Bullet_Resource { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int Barrel_Trace { get; set; }

    public int bullet_ID { get; set; }

    /// <summary>
    /// 발사 이펙트 관련 중심점에 대한 포구 오프셋.
    /// </summary>
    public int Offset { get; set; }
    public int headidle_ani { get; set; }
    public int Building_Time { get; set; }
    public int Upgrade_Cp_Lv_Limit { get; set; }
    /// <summary>
    /// 인식 범위.
    /// </summary>
    public float Sight_Range { get; set; }

    //타격타이밍
    public int hit_timing { get; set; }

    // 타격판정 타입
    public int hit_timing_bullet { get; set; }

    public int Text_Key { get; set; }
    /// <summary>
    /// 프리팹.
    /// </summary>
    public string Prefabs { get; set; }
    public int mainIdle_ani { get; set; }
    public int operation_ani { get; set; }
    /// <summary>
    /// 모드 체인지 된 건물의 경우 true, 그렇지 않은 경우 false.
    /// </summary>
    public bool isMode_Change { get; set; }
}
#endregion

#region shopData Class
//상점건물 데이터
public class ShopData
{
    //상점ID
    [XmlElement("shop_ID")]
    public int shop_ID { get; set; }

    //빌딩그룹ID
    [XmlElement("bd_group_ID")]
    public int bd_group_ID { get; set; }

    //빌딩의 가격 종류(ame acid aqua topaz)
    [XmlElement("building_cost_type")]
    public int costType { get; set; }

    //빌딩 가격
    [XmlElement("building_cost")]
    public int cost { get; set; }

    //건설시간
    [XmlElement("building_time")]
    public int time { get; set; }

    //가격증가(%합연산)
    [XmlElement("cost_increase")]
    public int cost_increase { get; set; }

    //초기 제공 수량(ex cp는 1개)
    [XmlElement("default_quantity")]
    public int defaultQuantity { get; set; }

    //UI 아이콘
    [XmlElement("icon")]
    public string icon { get; set; }

    //텍스트키  - 설명텍스트값을 찾아올 키
    [XmlElement("text_key")]
    public int textKey { get; set; }

    //상점 종류
    [XmlElement("shop_type")]
    public string shop_type { get; set; }

    //시간 종류
    [XmlElement("time_type")]
    public string time_type { get; set; }
}
#endregion

#region shop_Building Xml Serialize Class

//일반건물 데이터
[XmlRoot(ElementName = "root")]
public class ShopBuildingRootData
{
    [XmlElement("shop_building")]
    public List<ShopData> ShopBuildingDataList { get; set; }

    public ShopBuildingRootData()
    {
        ShopBuildingDataList = new List<ShopData>();
    }
}

#endregion

#region Shop_Text Xml Serialize Class

//상점빌딩의 이름 및 설명 텍스트데이터 묶음
[XmlRoot(ElementName = "root")]
public class ShopTextRootData
{
    [XmlElement("Shop_Text")]
    public List<ShopTextData> ShopTextDataList { get; set; }

    public ShopTextRootData()
    {
        ShopTextDataList = new List<ShopTextData>();
    }
}

//빌딩 이름 및 설명 텍스트데이터
public class ShopTextData
{
    [XmlElement("text_key")]
    public int textKey { get; set; }

    [XmlElement("name")]
    public string name { get; set; }

    [XmlElement("desc")]
    public string desc { get; set; }
}

#endregion

#region Unit_Basic Xml Serialize Class
//유닛 기본 데이터
[XmlRoot(ElementName = "root")]
public class UnitBasicRootData
{
    [XmlElement("unit_basic")]
    public List<UnitBasicData> UnitBasicDataList { get; set; }

    public UnitBasicRootData()
    {
        UnitBasicDataList = new List<UnitBasicData>();
    }
}

public class UnitBasicData
{
    [XmlElement("unit_group_ID")]
    public int unit_group_ID { get; set; }

    [XmlElement("default_research")]
    public int default_research { get; set; }

    [XmlElement("target_type")]
    public int target_type { get; set; }

    [XmlElement("target_site")]
    public int target_site { get; set; }

    [XmlElement("factory_level")]
    public int factory_level { get; set; }

    [XmlElement("first_target")]
    public string first_target { get; set; }

    [XmlElement("human_capacity")]
    public int human_capacity { get; set; }

    [XmlElement("sight_range")]
    public int sight_range { get; set; }

    [XmlElement("unit_search_range")]
    public float unit_search_range { get; set; }

    [XmlElement("first_atk_delay")]
    public float first_atk_delay { get; set; }

    [XmlElement("attack_speed")]
    public float attack_speed { get; set; }

    [XmlElement("attack_range")]
    public float attack_range { get; set; }

    [XmlElement("attack_type")]
    public string attack_type { get; set; }

    [XmlElement("splash_range")]
    public float splash_range { get; set; }

    [XmlElement("bullet_speed")]
    public float bullet_speed { get; set; }

    [XmlElement("bullet_resource")]
    public string bullet_resource { get; set; }

    [XmlElement("move_type")]
    public int move_type { get; set; }

    [XmlElement("move_speed")]
    public float move_speed { get; set; }

    [XmlElement("resource_type")]
    public int resource_type { get; set; }

    [XmlElement("text_key")]
    public int text_key { get; set; }

    [XmlElement("icon")]
    public string icon { get; set; }

    [XmlElement("prefab")]
    public string prefab { get; set; }

    [XmlElement("idle_ani")]
    public int idle_ani { get; set; }

    [XmlElement("walk_ani")]
    public int walk_ani { get; set; }

    [XmlElement("attack_ani")]
    public int attack_ani { get; set; }

    [XmlElement("hit_timing")]
    public int hit_timing { get; set; }

    [XmlElement("hit_timing_bullet")]
    public int hit_timing_bullet { get; set; }

    [XmlElement("offset_x")]
    public int offset_x { get; set; }

    [XmlElement("offset_y")]
    public int offset_y { get; set; }
}
#endregion

#region unit_grow_up Xml Serialize Class
//유닛 기본 데이터
[XmlRoot(ElementName = "root")]
public class UnitGrowUpRootData
{
    [XmlElement("unit_basic")]
    public List<UnitGrowUpData> UnitGrowDataList { get; set; }

    public UnitGrowUpRootData()
    {
        UnitGrowDataList = new List<UnitGrowUpData>();
    }
}

public class UnitGrowUpData
{
    [XmlElement("ID")]
    public int ID { get; set; }

    [XmlElement("unit_group_ID")]
    public int unit_group_ID { get; set; }

    [XmlElement("level")]
    public int level { get; set; }

    [XmlElement("HP")]
    public int HP { get; set; }

    [XmlElement("attack_power")]
    public int attack_power { get; set; }

    [XmlElement("resource_value")]
    public int resource_value { get; set; }

    [XmlElement("training_time")]
    public int training_time { get; set; }

    [XmlElement("armory_level")]
    public int armory_level { get; set; }

    [XmlElement("animation_level")]
    public int animation_level { get; set; }

    [XmlElement("special_value")]
    public float special_value { get; set; }

    [XmlElement("time_type")]
    public string time_type { get; set; }

}
#endregion

#region upgrade_cost Xml Serialize Class
//업그레이드 가격 루트데이터
[XmlRoot(ElementName = "root")]
public class UpgradeCostRootData
{
    [XmlElement("upgrade_cost")]
    public List<UpgradeCostData> UpgradeCostDataList { get; set; }

    public UpgradeCostRootData()
    {
        UpgradeCostDataList = new List<UpgradeCostData>();
    }
}

//업그레이드 가격 데이터
public class UpgradeCostData
{
    [XmlElement("id")]
    public int upgrade_ID { get; set; }

    [XmlElement("group_id")]
    public int group_id { get; set; }

    [XmlElement("type")]
    public string type { get; set; }

    [XmlElement("level")]
    public int level { get; set; }

    [XmlElement("upgrade_armory_level_limit")]
    public int upgrade_armory_level_limit { get; set; }

    [XmlElement("upgrade_resource_type")]
    public int upgrade_resource_type { get; set; }

    [XmlElement("upgrade_resource_value")]
    public int upgrade_resource_value { get; set; }

    [XmlElement("research_time")]
    public int research_time { get; set; }

    [XmlElement("time_type")]
    public string time_type { get; set; }
}
#endregion

#region unit_Text Xml Serialize Class

//유닛 이름 및 설명 텍스트데이터 묶음
[XmlRoot(ElementName = "root")]
public class UnitTextRootData
{
    [XmlElement("unit_text")]
    public List<UnitText> UnitTextDataList { get; set; }

    public UnitTextRootData()
    {
        UnitTextDataList = new List<UnitText>();
    }
}

//유닛 이름 및 설명 텍스트데이터
public class UnitText
{
    [XmlElement("text_key")]
    public int textKey { get; set; }

    [XmlElement("name")]
    public string name { get; set; }

    [XmlElement("desc")]
    public string desc { get; set; }
}

#endregion

#region unittotaldata
/// <summary>
/// 유닛 통합데이터.
/// </summary>
public class UnitData
{
    public int ID { get; set; }

    public int unit_group_ID { get; set; }

    public int level { get; set; }

    public int HP { get; set; }

    public int attack_power { get; set; }

    public int resource_value { get; set; }

    public int training_time { get; set; }

    public int armory_level { get; set; }

    public int target_type { get; set; }

    public int target_site { get; set; }

    public int factory_level { get; set; }

    public string first_target { get; set; }

    public int human_capacity { get; set; }

    public int sight_range { get; set; }
    public float unit_search_range { get; set; }

    public float first_atk_delay { get; set; }

    public float attack_speed { get; set; }

    public float attack_range { get; set; }

    public string attack_type { get; set; }

    public float splash_range { get; set; }

    public float bullet_speed { get; set; }

    public string bullet_resource { get; set; }

    public int move_type { get; set; }

    public float move_speed { get; set; }

    public int resource_type { get; set; }

    public int text_key { get; set; }

    public string icon { get; set; }

    public string prefab { get; set; }

    public int idle_ani { get; set; }

    public int walk_ani { get; set; }

    public int attack_ani { get; set; }

    public int animation_level { get; set; }

    public float special_value { get; set; }

    public int hit_timing { get; set; }

    public int hit_timing_bullet { get; set; }

    public int offset_x { get; set; }

    public int offset_y { get; set; }

    public string time_type { get; set; } //유닛훈련 시간 타입
}
#endregion

#region userDataPreset Xml Serialize Class

//유저프리셋데이터 루트
[XmlRoot(ElementName = "root")]
public class UserDataPresetRootData
{
    [XmlElement("userdata_preset")]
    public List<UserDataPresetData> UserDataPresetList { get; set; }

    public UserDataPresetRootData()
    {
        UserDataPresetList = new List<UserDataPresetData>();
    }
}

//유저프리셋
public class UserDataPresetData
{
    //프리셋 종류
    [XmlElement("userdata_preset_type")]
    public string presetType { get; set; }

    //프리셋 값
    [XmlElement("userdata_preset_value")]
    public int presetValue { get; set; }
}

#endregion

#region start_user_building Xml Serialize Class

//시작유저 빌딩 데이터 루트
[XmlRoot(ElementName = "root")]
public class StartUserBuildingRootData
{
    [XmlElement("userdata_preset")]
    public List<StartUserBuilding> StartUserBuilndigList { get; set; }

    public StartUserBuildingRootData()
    {
        StartUserBuilndigList = new List<StartUserBuilding>();
    }
}

//시작유저 빌딩
public class StartUserBuilding
{
    //빌딩그룹아이디
    [XmlElement("building_group_id")]
    public int bd_group_id { get; set; }

    //빌딩레벨
    [XmlElement("building_level")]
    public int bd_level { get; set; }

    //빌딩위치(col)
    [XmlElement("building_grid_col")]
    public int grid_col { get; set; }

    //빌딩위치(row)
    [XmlElement("building_grid_row")]
    public int grid_row { get; set; }
}

#endregion

#region animationLis Xml Serialize Class

//애니메이션 리스트 루트 데이터
[XmlRoot(ElementName = "root")]
public class animationListRootData
{
    [XmlElement("animation_list")]
    public List<animationList> AnimationList { get; set; }

    public animationListRootData()
    {
        AnimationList = new List<animationList>();
    }
}

//애니메이션 데이터
public class animationList
{
    //애니아이디
    [XmlElement("ani_ID")]
    public int ani_ID { get; set; }

    //애니메이션 종류 - recharger,unit,building_normal,building_resource,building_defence
    [XmlElement("type")]
    public string type { get; set; }

    //애니메이션 프리팹 이름
    [XmlElement("tk2d_animation_prefab")]
    public string tk2d_animation_prefab { get; set; }

    //동작 키값 - idle,walk,attack,heal,rs,working
    [XmlElement("key")]
    public string key { get; set; }

    //방향성체크 - 1이면 방향이 있음, 0이면 방향이 없음.
    [XmlElement("directional")]
    public int directional { get; set; }
}

#endregion

#region animationData

//애니메이션 데이터 animationListRootData를 가지고 가공해서 만든다. 
//tk2d애니메이션의 정보를 가지고 있다.
public class Tk2dAniData
{
    //애니아이디
    public int ani_ID { get; set; }

    //애니메이션 종류 - recharger,unit,building_normal,building_resource,building_defence
    public string type { get; set; }

    //동작 키값 - idle,walk,attack,heal,rs,working
    public string key { get; set; }

    //방향성체크 - 1이면 방향이 있음, 0이면 방향이 없음.
    public int directional { get; set; }

    //tk2dSpriteAnimation 오브젝트.
    public tk2dSpriteAnimation animation { get; set; }
}

#endregion

#region InfoButton Xml Serialize Class

//정보버튼 루트 데이터
[XmlRoot(ElementName = "root")]
public class InfoButtonRootData
{
    [XmlElement("info_button")]
    public List<InfoButton> InfoButtonList { get; set; }

    public InfoButtonRootData()
    {
        InfoButtonList = new List<InfoButton>();
    }
}

//정보버튼 데이터
public class InfoButton
{
    //버튼 아이디
    [XmlElement("button id")]
    public int Button_ID { get; set; }

    //버튼 프리팹
    [XmlElement("button_prefab")]
    public string prefab { get; set; }

    //버튼 아이콘
    [XmlElement("icon")]
    public string icon { get; set; }
}



#endregion

#region CloneButton Xml Serialize Class

//클론버튼 루트 데이터
[XmlRoot(ElementName = "root")]
public class CloneButtonRootData
{
    [XmlElement("info_button")]
    public List<CloneButton> CloneButtonList { get; set; }

    public CloneButtonRootData()
    {
        CloneButtonList = new List<CloneButton>();
    }
}

//클론버튼 데이터
public class CloneButton
{
    //버튼 아이디
    [XmlElement("clone_button_id")]
    public int Button_ID { get; set; }

    //버튼 프리팹
    [XmlElement("Prefab")]
    public string prefab { get; set; }

    ////버튼 아이콘
    //[XmlElement("icon")]
    //public string icon { get; set; }
}

#endregion

#region AvatarHbody Xml Serialize Class

//아바타파츠아이디 루트 데이터
[XmlRoot(ElementName = "root")]
public class AvatarHbodyRootData
{
    [XmlElement("avatar_recharging_time")]
    public List<AvatarHbody> AvatarHbodyList { get; set; }

    public AvatarHbodyRootData()
    {
        AvatarHbodyList = new List<AvatarHbody>();
    }
}

//아바타파츠아이디 클래스
public class AvatarHbody
{
    //파츠 아이디
    [XmlElement("id")]
    public int id { get; set; }

    //파츠 그룹아이디
    [XmlElement("parts_group_id")]
    public int parts_group_id { get; set; }

    //파츠 종류
    [XmlElement("parts")]
    public string parts { get; set; }

    //파츠 랭크
    [XmlElement("rank")]
    public int rank { get; set; }

    //인챈트 레벨
    [XmlElement("enchant_lv")]
    public int enchant_lv { get; set; }

    //다크매터 요구량
    [XmlElement("need_darkmatter")]
    public int need_darkmatter { get; set; }

    //업그레이드 시간
    [XmlElement("upgrade_time")]
    public int upgrade_time { get; set; }

    //아바타연구소 레벨
    [XmlElement("avatarlab_level")]
    public int avatarlab_level { get; set; }

    //연구시간
    [XmlElement("recharging_time")]
    public int recharging_time { get; set; }

    //파츠 아이콘 이름
    [XmlElement("icon")]
    public string icon { get; set; }

    //스킨 이름
    [XmlElement("skin_name")]
    public string skin_name { get; set; }

    //공격애니
    [XmlElement("attack_ani")]
    public string attack_ani { get; set; }

    //인게임 아이들애니
    [XmlElement("idle_field_ani")]
    public string idle_field_ani { get; set; }

    //거라지 애니
    [XmlElement("idle_garage_ani")]
    public string idle_garage_ani { get; set; }

    //거라지 파츠 교체 애니
    [XmlElement("replace_garage_ani")]
    public string replace_garage_ani { get; set; }

    //이동 애니
    [XmlElement("walk_ani")]
    public string walk_ani { get; set; }

    //체력
    [XmlElement("hp")]
    public int hp { get; set; }

    //무게
    [XmlElement("weight")]
    public int weight { get; set; }

    //무게제한
    [XmlElement("weightcap")]
    public int weightcap { get; set; }

    //활동시간
    [XmlElement("optime")]
    public int optime { get; set; }

    //방어력
    [XmlElement("defence")]
    public int defence { get; set; }

    //텍스트키
    [XmlElement("text_key")]
    public int text_key { get; set; }

    //업그레이드 시간 타입
    [XmlElement("upgrade_time_type")]
    public string upgrade_time_type { get; set; }

    //연구시간 타입
    [XmlElement("recharging_time_type")]
    public string recharging_time_type { get; set; }

    //활동시간 타입
    [XmlElement("optime_type")]
    public string optime_type { get; set; }

    //피격포인트 오프셋 - 이값에 그리드타일을 곱해서 y축에 더해주면된다.
    [XmlElement("hit_point")]
    public float hit_point { get; set; }

}

#endregion

#region AvatarArm Xml Serialize Class

//아바타파츠아이디 루트 데이터
[XmlRoot(ElementName = "root")]
public class AvatarArmRootData
{
    [XmlElement("avatar_hb")]
    public List<AvatarArm> AvatarArmList { get; set; }

    public AvatarArmRootData()
    {
        AvatarArmList = new List<AvatarArm>();
    }
}

//아바타파츠아이디 클래스
public class AvatarArm
{
    //파츠 아이디
    [XmlElement("id")]
    public int id { get; set; }

    //파츠 그룹아이디
    [XmlElement("parts_group_id")]
    public int parts_group_id { get; set; }

    //파츠 종류
    [XmlElement("parts")]
    public string parts { get; set; }

    //파츠 랭크
    [XmlElement("rank")]
    public int rank { get; set; }

    //인챈트 레벨
    [XmlElement("enchant_lv")]
    public int enchant_lv { get; set; }

    //다크매터 요구량
    [XmlElement("need_darkmatter")]
    public int need_darkmatter { get; set; }

    //업그레이드 시간
    [XmlElement("upgrade_time")]
    public int upgrade_time { get; set; }

    //아바타연구소 레벨
    [XmlElement("avatarlab_level")]
    public int avatarlab_level { get; set; }

    //연구시간
    [XmlElement("recharging_time")]
    public int recharging_time { get; set; }

    //파츠 아이콘 이름
    [XmlElement("icon")]
    public string icon { get; set; }

    //스킨 이름
    [XmlElement("skin_name")]
    public string skin_name { get; set; }

    //공격애니
    [XmlElement("attack_ani")]
    public string attack_ani { get; set; }

    //근접 히트 판정 시간
    [XmlElement("hit_timing")]
    public int hit_timing { get; set; }
    //탄환 히트 판정 시간
    [XmlElement("hit_timing_bullet")]
    public int hit_timing_bullet { get; set; }

    //인게임 아이들애니
    [XmlElement("idle_field_ani")]
    public string idle_field_ani { get; set; }

    //거라지 애니
    [XmlElement("idle_garage_ani")]
    public string idle_garage_ani { get; set; }

    //거라지 파츠 교체 애니
    [XmlElement("replace_garage_ani")]
    public string replace_garage_ani { get; set; }

    //이동 애니
    [XmlElement("walk_ani")]
    public string walk_ani { get; set; }

    //체력
    [XmlElement("hp")]
    public int hp { get; set; }

    //무게
    [XmlElement("weight")]
    public int weight { get; set; }

    //공격사거리
    [XmlElement("attack_range")]
    public int attack_range { get; set; }

    //공격타입
    [XmlElement("attack_type")]
    public string attack_type { get; set; }

    //bulle ID
    [XmlElement("bullet_ID")]
    public int bullet_ID { get; set; }

    //공격선딜레이.
    [XmlElement("first_atk_delay")]
    public float first_atk_delay { get; set; }

    //공격속도
    [XmlElement("attack_speed")]
    public float attack_speed { get; set; }

    //공격력
    [XmlElement("attack_power")]
    public int attack_power { get; set; }

    //텍스트키
    [XmlElement("text_key")]
    public int text_key { get; set; }

    //업그레이드 타임 타입
    [XmlElement("upgrade_time_type")]
    public string upgrade_time_type { get; set; }

    //연구 타임 타입 
    [XmlElement("recharging_time_type")]
    public string recharging_time_type { get; set; }

}

#endregion

#region AvatarLeg Xml Serialize Class

//아바타파츠아이디 루트 데이터
[XmlRoot(ElementName = "root")]
public class AvatarLegRootData
{
    [XmlElement("avatar_hb")]
    public List<AvatarLeg> AvatarLegList { get; set; }

    public AvatarLegRootData()
    {
        AvatarLegList = new List<AvatarLeg>();
    }
}

//아바타파츠아이디 클래스
public class AvatarLeg
{
    //파츠 아이디
    [XmlElement("id")]
    public int id { get; set; }

    //파츠 그룹아이디
    [XmlElement("parts_group_id")]
    public int parts_group_id { get; set; }

    //파츠 종류
    [XmlElement("parts")]
    public string parts { get; set; }

    //파츠 랭크
    [XmlElement("rank")]
    public int rank { get; set; }

    //인챈트 레벨
    [XmlElement("enchant_lv")]
    public int enchant_lv { get; set; }

    //다크매터 요구량
    [XmlElement("need_darkmatter")]
    public int need_darkmatter { get; set; }

    //업그레이드 시간
    [XmlElement("upgrade_time")]
    public int upgrade_time { get; set; }

    //아바타연구소 레벨
    [XmlElement("avatarlab_level")]
    public int avatarlab_level { get; set; }

    //충전시간
    [XmlElement("recharging_time")]
    public int recharging_time { get; set; }

    //파츠 아이콘 이름
    [XmlElement("icon")]
    public string icon { get; set; }

    //스킨 이름
    [XmlElement("skin_name")]
    public string skin_name { get; set; }

    //공격애니
    [XmlElement("attack_ani")]
    public string attack_ani { get; set; }

    //인게임 아이들애니
    [XmlElement("idle_field_ani")]
    public string idle_field_ani { get; set; }

    //거라지 애니
    [XmlElement("idle_garage_ani")]
    public string idle_garage_ani { get; set; }

    //거라지 파츠 교체 애니
    [XmlElement("replace_garage_ani")]
    public string replace_garage_ani { get; set; }

    //이동 애니
    [XmlElement("walk_ani")]
    public string walk_ani { get; set; }

    //체력
    [XmlElement("hp")]
    public int hp { get; set; }

    //무게
    [XmlElement("weight")]
    public int weight { get; set; }

    //이동속도
    [XmlElement("move_speed")]
    public float move_speed { get; set; }

    //아바타의 타게팅 쿨타임
    [XmlElement("target_cooltime")]
    public int target_cooltime { get; set; }

    //텍스트키
    [XmlElement("text_key")]
    public int text_key { get; set; }

    //업그레이드 타임 타입
    [XmlElement("upgrade_time_type")]
    public string upgrade_time_type { get; set; }

    //연구 타임 타입
    [XmlElement("recharging_time_type")]
    public string recharging_time_type { get; set; }

    //타겟 쿨타임 타입
    [XmlElement("target_cooltime_type")]
    public string target_cooltime_type { get; set; }
}

#endregion

#region AvatarCircuit Xml Serialize Class

//아바타파츠아이디 루트 데이터
[XmlRoot(ElementName = "root")]
public class AvatarCircuitRootData
{
    [XmlElement("avatar_hb")]
    public List<AvatarCircuit> AvatarCircuitList { get; set; }

    public AvatarCircuitRootData()
    {
        AvatarCircuitList = new List<AvatarCircuit>();
    }
}

//아바타파츠아이디 클래스
public class AvatarCircuit
{
    //파츠 아이디
    [XmlElement("id")]
    public int id { get; set; }

    //파츠 그룹아이디
    [XmlElement("parts_group_id")]
    public int parts_group_id { get; set; }

    //파츠 종류
    [XmlElement("parts")]
    public string parts { get; set; }

    //파츠 랭크
    [XmlElement("rank")]
    public int rank { get; set; }

    //인챈트 레벨
    [XmlElement("enchant_lv")]
    public int enchant_lv { get; set; }

    //다크매터 요구량
    [XmlElement("need_darkmatter")]
    public int need_darkmatter { get; set; }

    //업그레이드 시간
    [XmlElement("upgrade_time")]
    public int upgrade_time { get; set; }

    //아바타연구소 레벨
    [XmlElement("avatarlab_level")]
    public int avatarlab_level { get; set; }

    //파츠 아이콘 이름
    [XmlElement("icon")]
    public string icon { get; set; }

    //스킬이펙트
    [XmlElement("skill_type")]
    public string skill_type { get; set; }

    //아바타 스킨 이름
    [XmlElement("skin_name")]
    public string skin_name { get; set; }

    //코어 교체 up애니메이션
    [XmlElement("circuit_replace_up")]
    public string circuit_replace_up { get; set; }

    //코어 교체 down애니메이션
    [XmlElement("circuit_replace_down")]
    public string circuit_replace_down { get; set; }

    //코어 idle 애니메이션
    [XmlElement("circuit_replace_idle")]
    public string circuit_replace_idle { get; set; }

    //스킬사거리
    [XmlElement("skill_range")]
    public float skill_range { get; set; }

    //스킬쿨타임
    [XmlElement("skill_time")]
    public float skill_time { get; set; }

    //스킬값
    [XmlElement("skill_value")]
    public float skill_value { get; set; }

    //텍스트키
    [XmlElement("text_key")]
    public int text_key { get; set; }

    //업그레이드 타임
    [XmlElement("upgrade_time_type")]
    public string upgrade_time_type { get; set; }

    //아바타 스킨 이름
    [XmlElement("recharging_time_type")]
    public string recharging_time_type { get; set; }

    //아바타 스킨 이름
    [XmlElement("skill_time_type")]
    public string skill_time_type { get; set; }

}

#endregion

#region avatarPartsPromotion Xml Serialize Class

//승급데이터 루트
[XmlRoot(ElementName = "root")]
public class AvatarPartsPromotionRootData
{
    [XmlElement("userdata_preset")]
    public List<AvatarPartsPromotion> AvatarPartsPromotionist { get; set; }

    public AvatarPartsPromotionRootData()
    {
        AvatarPartsPromotionist = new List<AvatarPartsPromotion>();
    }
}

//승급데이터
public class AvatarPartsPromotion
{
    //파츠랭크
    [XmlElement("parts_rank")]
    public int parts_rank { get; set; }

    //확정승급확율
    [XmlElement("promotion_probability")]
    public int promotion_probability { get; set; }

    //확정승급비용
    [XmlElement("fixed_probability_cost")]
    public int fixed_probability_cost { get; set; }
}

#endregion

#region AvatarColor Xml Serialize Class

//아바타파츠아이디 루트 데이터
[XmlRoot(ElementName = "root")]
public class AvatarColorRootData
{
    [XmlElement("avatar_color")]
    public List<AvatarColor> AvatarColorList { get; set; }

    public AvatarColorRootData()
    {
        AvatarColorList = new List<AvatarColor>();
    }
}

//아바타파츠아이디 클래스
public class AvatarColor
{
    //아바타파츠아이디
    [XmlElement("id")]
    public int id { get; set; }

    //아바타파츠 랭크
    [XmlElement("color_R")]
    public int color_R { get; set; }

    //아바타파츠 레벨
    [XmlElement("color_G")]
    public int color_G { get; set; }

    //아바타파츠 쿨타임
    [XmlElement("color_B")]
    public int color_B { get; set; }
}

#endregion

#region AvatarUiGaugeMax Xml Serialize Class

//아바타파츠아이디 루트 데이터
[XmlRoot(ElementName = "root")]
public class AvatarUiGaugeMaxRootData
{
    [XmlElement("avatar_color")]
    public List<AvatarUiGaugeMax> AvatarUiGaugeMaxList { get; set; }

    public AvatarUiGaugeMaxRootData()
    {
        AvatarUiGaugeMaxList = new List<AvatarUiGaugeMax>();
    }
}

//아바타파츠아이디 클래스
public class AvatarUiGaugeMax
{
    //아바타파츠아이디
    [XmlElement("CP_level")]
    public int CP_level { get; set; }

    //아바타파츠 랭크
    [XmlElement("weightcap_gauge_max")]
    public int weightcap_gauge_max { get; set; }

    //아바타파츠 레벨
    [XmlElement("dps_gauge_max")]
    public int dps_gauge_max { get; set; }

    //아바타파츠 쿨타임
    [XmlElement("speed_gauge_max")]
    public int speed_gauge_max { get; set; }

    //아바타파츠 쿨타임
    [XmlElement("optime_gauge_max")]
    public int optime_gauge_max { get; set; }

    //아바타파츠 쿨타임
    [XmlElement("target_cooltime_gauge_max")]
    public int target_cooltime_gauge_max { get; set; }

    //아바타파츠 쿨타임
    [XmlElement("skill_time_gauge_max")]
    public int skill_time_gauge_max { get; set; }

    //아바타파츠 쿨타임
    [XmlElement("atk_skill_value_gauge_max")]
    public int atk_skill_value_gauge_max { get; set; }

    //아바타파츠 쿨타임
    [XmlElement("def_skill_value_gauge_max")]
    public int def_skill_value_gauge_max { get; set; }

    //아바타파츠 쿨타임
    [XmlElement("mspd_skill_value_gauge_max")]
    public int mspd_skill_value_gauge_max { get; set; }


    //아바타 hp게이지 맥스
    [XmlElement("all_parts_hp_gauge_max")]
    public int all_parts_hp_gauge_max { get; set; }
}

#endregion

#region AvatarBullet Xml Serialize Class

//아바타 Bullet  루트 데이터
[XmlRoot(ElementName = "root")]
public class AvatarBulletRootData
{
    [XmlElement("avatar_bullet")]
    public List<AvatarBullet> AvatarBulletList { get; set; }

    public AvatarBulletRootData()
    {
        AvatarBulletList = new List<AvatarBullet>();
    }
}

//아바타 Bullet 데이터 클래스
public class AvatarBullet
{
    //bullet id
    [XmlElement("bullet_ID")]
    public int bullet_ID { get; set; }

    //스플래쉬 범위
    [XmlElement("splash_range")]
    public float splash_range { get; set; }

    //스플래쉬 데미지
    [XmlElement("splash_damage")]
    public float splash_damage { get; set; }

    //투사체 속도
    [XmlElement("bullet_speed")]
    public float bullet_speed { get; set; }

    //유도여부 1:유도 0:유도안함
    [XmlElement("homing")]
    public int homing { get; set; }

    //리소스 프리팹이름.
    [XmlElement("resource")]
    public string resource { get; set; }

}

#endregion

#region SupportWeaponBasic Xml Serialize Class

//지원무기기본 루트 데이터
[XmlRoot(ElementName = "root")]
public class SupportWeaponBasicRootData
{
    [XmlElement("support_weapon_basic")]
    public List<SupportWeaponBasicData> SupportWeaponBasicList { get; set; }

    public SupportWeaponBasicRootData()
    {
        SupportWeaponBasicList = new List<SupportWeaponBasicData>();
    }
}

//지원무기스킬 클래스
public class SupportWeaponBasicData
{
    //스킬그룹아이디
    [XmlElement("support_weapon_group_id")]
    public int support_weapon_group_id { get; set; }

    //기본연구 번호
    [XmlElement("default_research")]
    public int default_research { get; set; }

    //스킬랩 제한레벨
    [XmlElement("support_weapon_lab_level")]
    public int support_weapon_lab_level { get; set; }

    //스킬효과
    [XmlElement("skill_effect")]
    public string skill_effect { get; set; }

    //스킬인구수
    [XmlElement("skill_capacity")]
    public int skill_capacity { get; set; }

    //자원종류
    [XmlElement("resource_type")]
    public int resource_type { get; set; }

    //아이콘
    [XmlElement("icon")]
    public string icon { get; set; }

    //텍스트키
    [XmlElement("text_key")]
    public int text_key { get; set; }
}

#endregion

#region SupporteWeaponGrow Xml Serialize Class

//지원무기기본 루트 데이터
[XmlRoot(ElementName = "root")]
public class SupportWeaponGrowRootData
{
    [XmlElement("support_weapon_grow_up")]
    public List<SupporteWeaponGrowData> SupporteWeaponGrowList { get; set; }

    public SupportWeaponGrowRootData()
    {
        SupporteWeaponGrowList = new List<SupporteWeaponGrowData>();
    }
}

//지원무기스킬 클래스
public class SupporteWeaponGrowData
{
    //스킬아이디
    [XmlElement("ID")]
    public int ID { get; set; }

    //스킬그룹아이디
    [XmlElement("support_weapon_group_id")]
    public int support_weapon_group_id { get; set; }

    //스킬레벨
    [XmlElement("skill_level")]
    public int skill_level { get; set; }

    //스킬범위
    [XmlElement("skill_range")]
    public float skill_range { get; set; }

    //스킬지속시간
    [XmlElement("skill_time")]
    public float skill_time { get; set; }

    //스킬주기
    [XmlElement("skill_pulse")]
    public float skill_pulse { get; set; }

    //스킬값 1
    [XmlElement("skill_value_1")]
    public float skill_value_1 { get; set; }

    //스킬값 2
    [XmlElement("skill_value_2")]
    public float skill_value_2 { get; set; }

    //필요 아모리 레벨
    [XmlElement("armory_level")]
    public int armory_level { get; set; }

    //연구시간
    [XmlElement("training_time")]
    public int training_time { get; set; }

    //필요 리소스수량
    [XmlElement("resource_value")]
    public int resource_value { get; set; }

    //타임 타입
    [XmlElement("time_type")]
    public string time_type { get; set; }
}

#endregion

#region SupportWeaponBindingData

public class SupportWeaponData
{
    //스킬그룹아이디
    public int support_weapon_group_id { get; set; }

    //기본연구 번호
    public int default_research { get; set; }

    //스킬랩 제한레벨
    public int support_weapon_lab_level { get; set; }

    //스킬효과
    public string skill_effect { get; set; }

    //스킬인구수
    public int skill_capacity { get; set; }

    //자원종류
    public int resource_type { get; set; }

    //스킬아이디
    public int ID { get; set; }

    //스킬레벨
    public int skill_level { get; set; }

    //스킬범위
    public float skill_range { get; set; }

    //스킬지속시간
    public float skill_time { get; set; }

    //스킬주기
    public float skill_pulse { get; set; }

    //스킬값 1
    public float skill_value_1 { get; set; }

    //스킬값 2
    public float skill_value_2 { get; set; }

    //필요 아모리 레벨
    public int armory_level { get; set; }

    //연구시간
    public int training_time { get; set; }

    //필요 리소스수량
    public int resource_value { get; set; }

    //아이콘
    public string icon { get; set; }

    //텍스트키
    public int text_key { get; set; }

    //타임 타입
    public string time_type { get; set; }
}


#endregion

#region UiPanelPrefab Xml Serialize Class

//클론버튼 루트 데이터
[XmlRoot(ElementName = "root")]
public class UiPanelPrefabDataRootData
{
    [XmlElement("ui_panel_prefab")]
    public List<UiPanelPrefabData> UiPanelPrefabList { get; set; }

    public UiPanelPrefabDataRootData()
    {
        UiPanelPrefabList = new List<UiPanelPrefabData>();
    }
}

//클론버튼 데이터
public class UiPanelPrefabData
{
    //버튼 아이디
    [XmlElement("panel_id")]
    public int panel_id { get; set; }

    //버튼 프리팹
    [XmlElement("Prefab")]
    public string prefab { get; set; }

    ////버튼 아이콘
    //[XmlElement("icon")]
    //public string icon { get; set; }
}

#endregion

#region Explore Xml Serialize Class

//클론버튼 루트 데이터
[XmlRoot(ElementName = "root")]
public class ExporeDataRootData
{
    [XmlElement("explore")]
    public List<ExploreData> ExporeDataList { get; set; }

    public ExporeDataRootData()
    {
        ExporeDataList = new List<ExploreData>();
    }
}

//탐사 데이터
public class ExploreData
{
    //탐사 아이디
    [XmlElement("explore_id")]
    public int explore_id { get; set; }

    //탐사가 해금되기 위한 탐사건물 레벨
    [XmlElement("explore_building_lv")]
    public int explore_building_lv { get; set; }

    //탐사 시간
    [XmlElement("explore_time")]
    public int explore_time { get; set; }

    //탐사에 필요한 장인수
    [XmlElement("recharger")]
    public int recharger { get; set; }

    //획득자원 최소
    [XmlElement("darkmatter_count_min")]
    public int darkmatter_count_min { get; set; }

    //획득자원 최대 
    [XmlElement("darkmatter_count_max")]
    public int darkmatter_count_max { get; set; }

    //타임 타입
    [XmlElement("time_type")]
    public string time_type { get; set; }

}

#endregion

#region AvatarPartsText_Key Xml Serialize Class

//아바타파츠텍스트키 루트 데이터
[XmlRoot(ElementName = "root")]
public class Avatar_parts_textRootData
{
    [XmlElement("avatar_parts_text")]
    public List<Avatar_parts_text> Avatar_parts_text_List { get; set; }

    public Avatar_parts_textRootData()
    {
        Avatar_parts_text_List = new List<Avatar_parts_text>();
    }
}

//아바타파츠텍스트키
public class Avatar_parts_text
{
    //텍스트키
    [XmlElement("text_key")]
    public int text_key { get; set; }

    //파츠이름
    [XmlElement("name")]
    public string name { get; set; }

}

#endregion

#region SupportWeaponText Xml Serialize Class

//지원무기 이름 및 설명 텍스트데이터 묶음
[XmlRoot(ElementName = "root")]
public class SupportWeaponTextRootData
{
    [XmlElement("support_weapon_text")]
    public List<SupportWeaponText> SupportWeaponTextList { get; set; }

    public SupportWeaponTextRootData()
    {
        SupportWeaponTextList = new List<SupportWeaponText>();
    }
}

//지원무기 이름 및 설명 텍스트데이터
public class SupportWeaponText
{
    [XmlElement("text_key")]
    public int textKey { get; set; }

    [XmlElement("name")]
    public string name { get; set; }

    [XmlElement("desc")]
    public string desc { get; set; }
}

#endregion

#region space_platform_reference_point Xml Serialize Class

//스페이스플랫폼 위치 루트
[XmlRoot(ElementName = "root")]
public class SpacePlatformReferencePointRootData
{
    [XmlElement("reference_point_splatform")]
    public List<SpacePlatformReferencePoint> SpacePlatformReferencePointList { get; set; }

    public SpacePlatformReferencePointRootData()
    {
        SpacePlatformReferencePointList = new List<SpacePlatformReferencePoint>();
    }
}

//스페이스플랫폼 위치 
public class SpacePlatformReferencePoint
{
    //빌딩아이디
    [XmlElement("building_id")]
    public int building_id { get; set; }

    //빌딩그룹아이디
    [XmlElement("building_group_id")]
    public int building_group_id { get; set; }

    //레벨
    [XmlElement("level")]
    public int level { get; set; }

    //x좌표
    [XmlElement("point_x")]
    public int point_x { get; set; }

    //y좌표
    [XmlElement("point_y")]
    public int point_y { get; set; }
}

#endregion

#region single_stage_setting Xml Serialize Class

//싱글스테이지 세팅 루트 데이터
[XmlRoot(ElementName = "root")]
public class SingleStageSettingDataRootData
{
    [XmlElement("single_stage_setting")]
    public List<SingleStageSettingData> singleStageSettingDataList { get; set; }

    public SingleStageSettingDataRootData()
    {
        singleStageSettingDataList = new List<SingleStageSettingData>();
    }
}

//싱글스테이지 세팅 데이터.
public class SingleStageSettingData
{
    //스테이지 아이디
    [XmlElement("stageID")]
    public int stageID { get; set; }

    //텍스트키(스테이지이름,설명)
    [XmlElement("text_key")]
    public int text_key { get; set; }

    //해금레벨 - 스테이지ID로 구분 0이면(1레벨의경우) 바로 해금.
    [XmlElement("open_condition")]
    public int open_condition { get; set; }

    //아메 획득량
    [XmlElement("give_amethyst")]
    public int give_amethyst { get; set; }

    //애시드 획득량
    [XmlElement("give_acid")]
    public int give_acid { get; set; }

    //아쿠아젤리 획득량 
    [XmlElement("give_aquajelly")]
    public int give_aquajelly { get; set; }

    //토파즈 획득량 
    [XmlElement("give_topaz")]
    public int give_topaz { get; set; }

    //추천레벨
    [XmlElement("recommend_lv")]
    public int recommend_lv { get; set; }

}

#endregion

#region single_stage_building Xml Serialize Class

//싱글스테이지 빌딩 루트 데이터
[XmlRoot(ElementName = "root")]
public class SingleStageBuildingDataRootData
{
    [XmlElement("single_stage_building")]
    public List<SingleStageBuildingData> singleStageBuildingDataList { get; set; }

    public SingleStageBuildingDataRootData()
    {
        singleStageBuildingDataList = new List<SingleStageBuildingData>();
    }
}

//싱글스테이지 빌딩 데이터.
public class SingleStageBuildingData
{
    //오브젝트아이디 - 스테이지 존재하는 건물,구조물등의 고유번호 - 같은타입의 건물일 경우 구분됨.
    [XmlElement("object_ID")]
    public int object_ID { get; set; }

    //스테이지 ID
    [XmlElement("stage_ID")]
    public int stage_ID { get; set; }

    //빌딩 그룹아이디
    [XmlElement("building_group_ID")]
    public int building_group_ID { get; set; }

    //빌딩레벨
    [XmlElement("building_lv")]
    public int building_lv { get; set; }

    //빌딩 col좌표
    [XmlElement("building_grid_col")]
    public int building_grid_col { get; set; }

    //빌딩 row좌표
    [XmlElement("building_grid_row")]
    public int building_grid_row { get; set; }

    //해단 건물이 어떤 리소스를 지급하는 빌딩인지 체크.
    [XmlElement("resource_bd_flag")]
    public int resource_bd_flag { get; set; }

}

#endregion

#region single_stage_text Xml Serialize Class

//싱글스테이지 텍스트 루트 데이터
[XmlRoot(ElementName = "root")]
public class SingleStageTextDataRootData
{
    [XmlElement("single_stage_text")]
    public List<SingleStageTextData> singleStageTextDataRootDataList { get; set; }

    public SingleStageTextDataRootData()
    {
        singleStageTextDataRootDataList = new List<SingleStageTextData>();
    }
}

//싱글스테이지 텍스트 데이터.
public class SingleStageTextData
{
    //텍스트키
    [XmlElement("text_key")]
    public int textKey { get; set; }

    //이름
    [XmlElement("name")]
    public string name { get; set; }

    //설명
    [XmlElement("desc")]
    public string desc { get; set; }
}

#endregion

#region BuildingDefenceBullet Xml Serialize Class

//디펜스 빌딩 불렛 루트 데이터.
[XmlRoot(ElementName = "root")]
public class BuildingDefenceBulletRootData
{
    [XmlElement("building_defence_bullet")]
    public List<BuildingDefenceBulletData> BuildingDefenceBulletDataList { get; set; }

    public BuildingDefenceBulletRootData()
    {
        BuildingDefenceBulletDataList = new List<BuildingDefenceBulletData>();
    }
}

//디펜스 빌딩 불렛 
public class BuildingDefenceBulletData
{
    //불렛 id
    [XmlElement("bullet_ID")]
    public int bullet_ID { get; set; }

    //고각도 미사일 플래그.
    [XmlElement("highangle_fire")]
    public int highangle_fire { get; set; }

    //빔형태인가?
    [XmlElement("is_beam")]
    public int is_beam { get; set; }

    //타게팅 or 논타게팅
    [XmlElement("homing")]
    public int homing { get; set; }

    //총알속도
    [XmlElement("bullet_speed")]
    public float bullet_speed { get; set; }

    //투사체 연속 발사수
    [XmlElement("bullet_count")]
    public int bullet_count { get; set; }

    //투사체 연속 발사시의 발사간격
    [XmlElement("bullet_interval")]
    public float bullet_interval { get; set; }

    //투사체 최대 고도(곡사포에 적용)
    [XmlElement("bullet_max_height")]
    public int bullet_max_height { get; set; }

    //투사체 피격 시 스플래시 밤위
    [XmlElement("splash_range")]
    public float splash_range { get; set; }

    //투사체 피격 시 투사체 소멸하지 않고 남아 있는 시간
    [XmlElement("dot_life_time")]
    public float dot_life_time { get; set; }

    //투사체가 남아 있을 경우 attack_power로 공격을 하는 간격
    [XmlElement("dot_damage_cycle")]
    public float dot_damage_cycle { get; set; }

}

#endregion









/// <summary>
/// 연구데이터 - 현재유닛,지원무기의 연구데이터를 저장한다.
/// </summary>
public class ResearchData
{
    public int GroupID; //유닛,지원무기의 종류를 나타낼 그룹아이디
    public int ResearchID; //연구데이터 아이디 - upgradeCostRootData와 연동된다.
    public int Level; //레벨
    public int armory_level_limit;//아모리 제한레벨(이레벨보다 작으면 연구진행불가)
    public int resource_type;//연구비용 자원타입
    public int resource_value;//연구비용 값
    public int trainig_time;//연구시간
    public string time_type;//연구시간 타입 초분시간일

    public bool IsUnitData; //유닛데이터인가? 지원무기 데이터인가?

    public int noid;//네트워크 아이디

    public int researchState; //연구상태 , 현재는 연구중or일반 2개의 상태가 있다.
    public DateTime StateStart; //연구 시작시간.
    public DateTime StateExpire; //연구완료시간 - 서버에서 데이터를 받아서 세팅하는경우에 필요하다.
    public int Produce_Level_Limit;//생산 제한레벨 - 최초 0->1레벨로 해금되는 건물레벨이다. 유닛은 팩토리등 생산건물에 영향,지원무기는 서포트 랩 제한.

    public ResearchData NextLavelData;//이 연구데이터의 다음레벨데이터.
    public ResearchData MaxLevelData; //이 연구데이터의 최대레벨데이터.
}

/// <summary>
/// 빌딩 저장데이터
/// </summary>
public struct BaseBuildingSaveData
{
    public int groudID; //그룹아이디
    public int level;//레벨
    public int col;//col
    public int row;//row
}


/// <summary>
/// 파괴된 건물 데이터
/// </summary>
public struct DestoryBuildingData
{
    public int noid; //건물고유아이디
    public int damaged;//피해량.
}



/// <summary>
/// 유닛스폰데이터. - 배틀맵에서 유닛을 생성할때의 정보.
/// </summary>
public class UnitSpawnData
{
    public int gropupID;//그룹아이디
    public int level;//레벨
    public int count;//수량
    public List<int> noidList;//네트워크 아이디리스트
}

/// <summary>
/// 싱글스테이지에서 유닛,서포트웨폰 수량을 카운팅하기 위한 정보
/// </summary>
public class SingleStageSpawnData
{
    public EntityType type = EntityType.Unit;//엔티티타입 - 유닛인지 지원무기인지.
    public int groupID = 0;//그룹아이디
    public int level = 0;//레벨
    public int count = 0;//수량
}

/// <summary>
/// 전투시의 스폰데이터
/// </summary>
public class SpawnData
{
    public SpawnType type = SpawnType.Unit;//스폰타입 - 유닛인지 지원무기인지.
    public int groupID = 0;//그룹아이디
    public int level = 0;//레벨
    public int count = 0;//수량
    public int spawnCount = 0;//투입된 수량
    public string icon = string.Empty;//이 엔티티의 아이콘이름 
    public List<int> noidList = new List<int>();//네트워크 아이디리스트

}


/// <summary>
/// 전투에서 사용하는 유저정보 UI
/// </summary>
public struct BattleUserInfoUI
{
    public UISprite leagueIcon;//리그아이콘 - 자기가 속한 리그의 아이콘표시
    public UILabel userStateLabel;//공격자or방어자 표시라벨
    public UILabel userNameLabel;//유저이름라벨
    public UILabel unionNameLabel;//유니온이름라벨
    public UILabel ResourceTitleLabel;//얻을수있는자원,얻은자원 제목표시(언어별다르게)
    public UILabel ameLabel;
    public UILabel acidLabel;
    public UILabel aquaLabel;

}





#endregion

#region //++Define

public enum XMLDATATYPE //게임에 쓰이는 데이터를 담은 Xml파일들의 enum값.
{
    BuildingNormal = 0,
    BuildingDefence,
    BuildingMaxQuantity,
    BuildingText_kr,
    BuildingText_en,
    BuildingText_jp,
    BuildingText_zh_s,
    BuildingText_zh_t,
    ShopBuilding,
    ShopText_kr,
    ShopText_en,
    ShopText_jp,
    ShopText_zh_s,
    ShopText_zh_t,
    UnitBase,
    UnitGrowUp,
    UpgradeCost,
    UnitText_kr,
    UnitText_en,
    UnitText_jp,
    UnitText_zh_s,
    UnitText_zh_t,
    UserPreset,
    StartUserBuilding,
    Tk2dAnimationData,
    InfoButton,
    CloneButton,
    AvatarHbody,
    AvatarArm,
    AvatarLeg,
    AvatarCircuit,
    AvatarColor,
    AvatarUiGageMax,
    AvatarBulletData,
    SupportWeaponBasic,
    SupportWeaponGrow,
    UiPanelPrefab,
    Explore,
    AvatarPromotion,
    AvatarPartsText,
    SupportWeaponText,
    SpacePlatformPoint,
    StageSetting,
    StageBuilding,
    StageText,
    AmeExchange,
    AcidExchange,
    AquaExchange,
    TimeExchange,
    BuildingDefenceBullet,
    Exp,

    EXCELDATATYPE_MAX
}

//유닛에 부여하는  path tag - 부여된 tag에 따라서 지나갈수 있는 영역이 달라진다.
public enum PathTag
{
    Ground = 0,
    Air = 1,

    max
}

//AI맵에서 사용하는 tag
public enum GroundTag
{
    BasicGround = 0,
    Obstacle = 1,

    max
}



public enum DirectionType //8방향
{
    N = 0,
    NE,
    E,
    SE,
    S,
    SW,
    W,
    NW,
    End
}

public enum TileDiriection //타일방향
{
    N = 0,
    NE,
    E,
    SE,
    S,
    SW,
    W,
    NW,
    C, //센터
    End
}

/// <summary>
/// 16방향 표시 - 북쪽방향부터 시계방향으로 돌아간다. 
/// </summary>
public enum Direction16WayType
{
    N = 0,
    NNE = 1,
    NE = 2,
    NEE = 3,
    E = 4,
    SEE = 5,
    SE = 6,
    SSE = 7,
    S = 8,
    SSW = 9,
    SW = 10,
    SWW = 11,
    W = 12,
    NWW = 13,
    NW = 14,
    NNW = 15,

    End
}

public enum BuildingStructState //빌딩 건설 스테이트
{
    NONE = -1,
    CREATE,
    NORMAL,
    UPGRADE,
    END
}



//스폰타입
public enum SpawnType
{
    Building = 0,
    Unit,
    SupportWeapon,//서포트웨폰
    Avatar,//
    AvatarTarget,//아바타 타게팅
    End
}

/// <summary>
/// 빌딩그룹아이디 - 빌딩 종류 식별
/// </summary>
public enum BuildingGroupID
{
    None = -1,
    RechargingStation = 9999,
    CP = 10000,
    Factory = 10100,
    supportWeaponLab = 10200,
    Armory = 10300,
    TechLab = 10400,
    AmeCollector = 10500,
    AcidCollector = 10600,
    AquaCollector = 10700,
    AmeStorage = 10800,
    AcidStorage = 10900,
    AquaStorage = 11000,
    UNION = 11100,
    SpacePlatform = 11200,
    Explore = 11300,
    AvatarLab = 11400,
    WatchTower = 15000,
    Cannon = 15100,
    Artillery = 15200,
    Turret = 15300,
    Plasma = 15400,
    Flamethrower = 15500,
    Icbm = 15600,
    Paralyzer = 15700,
    Gianttaser = 15800,
    InfernoTower = 15900,

    Max
}

//빌딩의 그룹타입 - 일반,자원,방어
public enum BuildingGroupType
{
    none = -1,
    normal = 0,
    resource,
    defence,
    army,
    end
}


public enum BuildingTileType //빌딩 타일 1~5칸 표시.
{
    NONE = 0,
    ONE,
    TWO,
    THREE,
    FOUR,
    FIVE,
    SIX,
    SEVEN,
    EIGHT,
    NINE,
    TEN
}

/// <summary>
/// 빌딩의 특수한 상태 - 인페르노타워의 싱글-멀티타겟 전환, 지상전용 혹은 공중전용으로 스왑가능한 건물등의 상태를 알 때 쓰인다.
/// Building 클래스안에 선언되어 있다.
/// </summary>
public enum BuildingSpecialState
{
    None = -1,
    SingleTarget,
    MultiTarget,
    GroundOnly,
    AirOnly,
}


public enum UnitType //유닛 종류 - 유닛 아이디와 연동
{
    None = -1,
    Recharger = 20000,
    GoldBane = 20100,
    Valo = 20200,
    AquaHammer = 20300,
    Goblin = 20400,
    Crid = 20500,
    Balloon = 20600,
    SpaceChaser = 20700,
    MedicalBlimp = 20800,
    Minion = 20900,
    GuardsMan = 21000,
    Cyclopse = 21100,
    SpaceCarrier = 21200,
    interceptor = 21300,
    Avatar = 49999,
    end,
}

/// <summary>
/// 서포트웨폰 종류 
/// </summary>
public enum SupportWeaponType : int
{
    None = -1,
    FireSupport = 30000,

    end

}


/// <summary>
/// 팩토리 패널의 탭오브젝트들 
/// </summary>
public enum FactoryPanelID
{
    troopsinfo,
    unittraining,
    skilltraining,
    quicktraining,
    garage,
}

/// <summary>
/// 업그레이드 패널오브젝트의 탭오브젝트들
/// </summary>
public enum UpgradePanelID
{
    armory,
    techlab,
    avatarlab,

    max
}



//애니메이션 프리팹관리 enum변수
public enum Tk2dAnimationType
{
    //유닛
    recharger_Idle = 60000,
    recharger_walk,
    recharger_Attack,
    goldbane_idle,
    goldbane_walk,
    goldbane_attack,
    valo_idle,
    valo_walk,
    valo_attack,
    aquahammer_idle,
    aquahammer_walk,
    aquahammer_attack,
    goblin_idle,
    goblin_walk,
    goblin_attack,
    creed_idle,
    creed_walk,
    creed_attack,
    balloon_idle,
    balloon_walk,
    balloon_attack,
    spacechaser_idle,
    spacechaser_walk,
    spacechaser_attack,
    medical_blimp_idle,
    medical_blimp_walk,
    medical_blimp_attack,
    minion_idle,
    minion_walk,
    minion_attack,
    guardsman_idle,
    guardsman_walk,
    guardsman_attack,
    cyclops_idle,
    cyclops_walk,
    cyclops_attack,
    spacecarrier_idle,
    spacecarrier_walk,
    spacecarrier_attack,
    spacecarrier_interceptor_idle,
    spacecarrier_interceptor_walk,
    spacecarrier_interceptor_attack,

    //빌딩
    rechargingstation_idle = 60042,
    cp_main_idle,
    cp_head_idle = 60097,
    factory_idle = 60044,
    supportWeaponLab_idle,
    armory_idle,
    techlab_idle,
    unionCenter_idle,
    dock_idle,
    amecollector_main_idle,
    amecollector_operation,
    amecollector_rs,
    acidcollector_main_idle,
    acidcollector_head_idle = 60096,
    acidcollector_operation = 60054,
    acidcollector_rs = 60055,
    aquacollector_main_idle = 60056,
    aquacollector_operation = 60057,
    aquacollector_rs = 60058,
    amestorage_main_idle,
    amestorage_rs,
    acidstorage_main_idle,
    acidstorage_rs,
    aquastorage_main_idle,
    aquastorage_rs,

    //디펜스빌딩
    watchtower_mainidle,
    watchtower_headidle,
    watchtower_operation,
    cannon_mainidle,
    cannon_headidle,
    cannon_operation,
    artillery_mainidle,
    artillery_headidle,
    artillery_operation,
    turret_mainidle,
    turret_operation,
    plasmawave_mainidle,
    plasmawave_headidle,
    plasmawave_operation,
    flamethrower_headidle,
    flamethrower_operation,
    flamethrower_mainidle,
    icbm_mainidle,
    icbm_operation,
    paralyzer_mainidle,
    paralyzer_operation,
    giant_tager_maindile,
    giant_tager_headidle,
    giant_taser_operation,
    infernotower_mainidle_single,
    infernotower_mainidle_multi,
    infernotower_operation_single,
    infernotower_operation_multi,

    //특수건물
    avatarlab_main_idle,
    avatarlab_head_idle,
    bank_main_idle,
    explore_dock,
    explore_ship = 60098,

    tk2dAniMaiionMax
}


//애니메이션 종류
public enum AnimationType
{
    None = -1,
    Idle,
    Idle_bottom,
    Idle_head,
    Walk,
    Attack,
    Operation,
    Resource,

    Max
}

//유저 의 초기 데이터 정보 종류 
//기본적으로는 서버로부터 시작정보를 받아서 사용하지만 오프라인모드에서는 이정보를 직접 대입해서 사용한다.
public enum UserPresetDataType
{
    default_amethyst = 0,
    default_acid,
    default_aquajelly,
    default_topaz,
    default_league_point,
    default_user_level,
    default_rechargingstation_count,
    end
}

/// <summary>
/// 유저프리셋데이터
/// </summary>
public struct UserPresetDataStruct
{
    public int default_amethyst;
    public int default_acid;
    public int default_aquajelly;
    public int default_topaz;
    public int default_league_point;
    public int default_user_level;
    public int default_cp_level;
    public int default_rechargingstation_count;
}

/// <summary>
/// 아바타 방향 
/// </summary>
public static class AvatarArrayNum
{
    public const int dir_N = 0;
    public const int dir_NE = 1;
    public const int dir_E = 2;
    public const int dir_SE = 3;
    public const int dir_S = 4;
    public const int dir_SW = 3;
    public const int dir_W = 2;
    public const int dir_NW = 1;
}

/// <summary>
/// 아바타 애니메이션 
/// </summary>
public static class AvatarAnimation
{
    public const int Idle_Field = 0;
    public const int Walk = 1;
    public const int Attack = 2;
}


//UI버튼 - 빌딩정보버튼
public enum InfoButton_ID
{
    BdInfoButton_Info = 69001,
    BdInfoButton_Boost,
    BdInfoButton_BoostAll,
    BdInfoButton_Upgrade,
    BdInfoButton_UpgradeCancle,
    BdInfoButton_UpgradeFinishNow,
    BdInfoButton_Garage,
    BdInfoButton_UnitTraining,
    BdInfoButton_SupportWeaponProduction,
    BdInfoButton_UnitAndSupportWeaponResearch,
    BdInfoButton_TechLab,
    BdInfoButton_Exploration,
    BdInfoButton_RequestTroops,
    BdInfoButton_Union,
    BdInfoButton_Treasury,
    BdInfoButton_Collect_Ame,
    BdInfoButton_Collect_Ame_Full,
    BdInfoButton_Collect_Acid,
    BdInfoButton_Collect_Acid_Full,
    BdInfoButton_Collect_Aqua,
    BdInfoButton_Collect_Aqua_Full,
    BdInfoButton_Repair,
    BdInfoButton_AvtarLab,
    BdInfoButton_PlasmaWaveGround,
    BdInfoButton_PlasmaWaveAir,
    BdInfoButton_InfernoSingle,
    BdInfoButton_InfernoMulty,
    max
}

//클론버튼 id
public enum CloneButton_ID
{
    ShopItem = 68000,//상점 일반 아이템
    ShopPackageItem, //상점 캐쉬 아이템
    UpgradeCard,//업그레이드 카드
    UnitCardCost,//유닛 가격카드
    UnitCardTraing,//유닛 훈련카드
    UnitCardCount,//유닛 카운팅카드
    AvatarPartsColor,//아바타 파츠컬러카드
    AvatarPartsCard,//아바타 파츠 카드
    UnionMessage,//유니온 메시지 카드
    UnionMember,//유니온 멤버 카드
    UnionInfoCard,//유니온 정보 카드
    ExploreCard,//탐사 카드
    AvatarLabPartsCard,//아바타연구소 파츠카드
    SupportWeaponCostCard,//지원무기생산 가격카드
    SupportWeaponTrainCard,//지원무기생산 훈련카드
    BuildingInfo_SpacePlatform,//빌딩정보- 스페이스플랫폼의 유닛카드
    BuildingInfo_Cp,//빌딩정보 - cp의 해금 건물 카드
    BattleLogCard,//배틀로그 - 공격+방어리스트
    BattleLogUnitCard,//배틀로그안의 각 아이템에 표시될 투입유닛정보 표시를 위한 카드.
    ReplayUnitCard,//리플레이의 유닛을 표시할 카드.
    SingleStageEntityCard,//싱글스테이지의 엔티티를 표시할 카드
    SingleStageResultEntityCard,//싱글스테이지의 투입결과를 표시할 카드.
    ChatMessage,// 채팅 메시지 
    OverveiwEntityCard,//오버뷰의 엔티티카드
    ProfileAvatarPartsCard, //프로필ui 아바타파츠
    ProfileUnitWeaponCard,//프로필ui 유닛+웨폰
    ProfileBuildingCard,//프로필ui 빌딩
    BattleHistoryUnitCard,//배틀히스토리 유닛카드.(투입된 유닛+아바타+지원무기)
    End
}

/// <summary>
/// 아바타 파츠종류
/// </summary>
public enum AvatarPartsType : int
{
    none = -1,
    Circuit = 0,
    Hbody,
    Arm,
    Leg,
    Max
}

/// <summary>
/// 아바타 스킬종류
/// </summary>
public enum AvatarSkillType
{
    NONE = -1,
    ATTACK_POWER,
    MOVE_SPEED,
    DEFENCE,
    END
}


/// <summary>
/// 아바타 공격종류 : 근접,원거리
/// </summary>
public enum AvatarAttackType
{
    NONE = -1,
    MELEE,
    RANGE,

    MAX
}




//외곽선 모양
public enum OutlineType //외곽라인 타입
{
    NONE = -1,
    BUILDING,
    NW,
    NE,
    SE,
    SW
}


public enum SoundPlayType { None = -1, BGM, EFFECT, UI, VOICE, LENGTH }
public enum MusicPlayType { PLAY, PLAY_ONESHOT, STOP, FADE_IN, FADE_OUT, FADE_TO, RANDOM_BGM_FADE_TO, RANDOM_ONESHOT_TO, };
public enum SceneID
{
    NONE = -1,
    Login = 0,
    Loading,
    Base,
    BattleLoading,
    Battle,
    TestReplay, // 테스트 용 씬. 
    InGameReplay, // 인게임 전용 씬.
    SingleStage,//싱글스테이지(켐페인) 전용 씬
}

/// <summary>
/// 상태머신 트랜지션
/// </summary>
public enum Transition
{
    NullTransition = 0,
    //////////////////건물///////////////
    BaseIdleToBaseIdle, //건물의 최초 시작 트랜지션 BaseIdle
    BaseIdleToFirstSelect, //BaseIdle에서 대기하다가 인터랙션(클릭,터치)이 일어나면 FirsetSelect로 이동(FirsetSelect : 첫번째 toucEnd 혹은 mouseup에서 일어난다)
    BaseIdleToTargetFind, //베이스에 쓰이는건 아니지만 죽었다가 다시 살아난경우.
    BaseIdleToRotate, //베이스맵에서 의미 없이 회전하고 싶을때.
    FirstSelectToBaseIdle, //FirstSelect상태에서 다른 건물을 선택하거나 지형등을 클릭하여 건물에 대한 Select가 취소되는 트랜지션
    FirstSelectToMove,//FirstSelect상태에서 건물을 이동하기 위해 재선택을 하는경우의 트랜지션
    MoveToIdle,//건물을 이동시키다가 touchend,mouseup의 입력 종료가 일어날 경우의 트랜지션 - idle로 복귀한다. 


    ResourceCollectToResourceCollect,

    BuildingTargetFindToTargetFind,//빌딩의 타겟검색.
    BuildingTargetFindToRotate,//공격 직전에 회전 연출이 있는 유닛의 경우.
    BuildingTargetFindToAttack,//타겟검색에서 공격.
    BuildingTargetFindToAppear,//공격 직전에 등장 연출이 있는 유닛의 경우.
    BuildingTargetFindToIdle, //탐색하다 죽은경우.
    BuildingAppearToAttack, //자이언트 테이저 등에 쓰이는 등장 연출에서 공격으로 가는 경우.
    BuildingAppearToIdle, //자이언트 테이저 등에 쓰이는 등장 연출중에 죽은 경우.
    BuildingRotateToAttack,     //회전에서 공격.
    BuildingRotateToIdle, // 회전하다가 죽은 경우.
    BuildingAttackToTargetFind,//공격에서 타겟검색.
    BuildingAttackToIdle, // 공격하다가 죽은경우,

    /////////////////유닛////////////////
    IdleToIdle,
    IdleToSearch,
    IdleToStun,
    IdleToCargoSearch,
    IdleToCargoMove,
    IdleToRetarget,
    IdleToRotate,
    IdleToMove, //move는 강제이동.
    IdleToDie,

    CargoSearchToCargoWalk,
    CargoSearchToCargoMove,
    CargoWalkToCargoMove,

    SearchToIdle,
    SearchToWalk,
    SearchToAttack,
    SearchToStun,
    SearchToRotate,
    SearchToRetarget,
    SearchToMove, //move는 강제이동.
    SearchToDie,

    RetargetToIdle,
    RetargetToWalk,
    RetargetToSearch,
    RetargetToAttack,
    RetargetToStun,
    RetargetToMove,
    RetargetToDie,

    RotateToIdle,
    RotateToSearch,
    RotateToWalk,
    RotateToAttack,
    RotateToStun,
    RotateToRetarget,
    RotateToMove, //move는 강제이동.

    WalkToAttack,
    WalkToSearch,
    WalkToIdle,
    WalkToDeath,
    WalkToStun,
    WalkToRotate,
    WalkToRetarget,
    WalkToMove, //move는 강제이동.
    WalkToDie,

    MoveToSearch,
    MoveToAttack,
    MoveToStun,
    MoveToRetarget,
    MoveToWalk,
    MoveToDie,

    AttackToDeath,
    AttackToSearch,
    AttackToIdle,
    AttackToStun,
    AttackToRotate,
    AttackToRetarget,
    AttackToMove, //move는 강제이동.
    AttackToDie,

    StunToIdle,
    StunToSearch,
    StunToDie,

    TargetFind,
    PathFind,
    Attack,
    Die,
}

/// <summary>
/// 상태머신 아이디
/// </summary>
public enum StateID
{
    NULLSTATEID = 0,

    /////////빌딩////////////////
    BuildingBaseIdle = 1,
    BuildingBaseFirstSelect = 2,
    BuildingBaseMove = 3,
    ResourceCollect = 4,
    BuildingTargetFind = 5,
    PathFind = 6,
    BuildingAttack = 7,
    Die = 8,
    BuildingRotate = 9,
    BuildingAppear = 10,
    /////////유닛////////////////
    Idle = 11,
    Walk = 12,
    Attack = 13,
    Search = 14, //적을 검색하는 상태 - 애니메이션은 기본적으로 IDLE을 사용.
    Death = 15,
    Rotate = 16, //회전 상태 - 일단 만들어는 두는데 큰 비행선 등에 쓰일지 안쓰일지는 아몰랑.
    Appear = 17,
    Stun = 18,
    CargoWalk = 19, // 연병장까지 걸어가는 상태. 이름은 맘에 안듦.
    CargoMove = 20, // 연병장에 도착해서 도열하는 상태. 이름 역시 맘에 안듦.
    CargoSearch = 21, // 연병장 찾는 상태.
    Retarget = 22, // 아바타의 경우, 다시 타겟을 지정하거나 이동해야할 위치를 강제 지정할 수 있다.
    Move = 23, // 아바타의 경우, 강제 이동을 시켜줘야 하는 경우가 있다. 강제 이동 스테이트.
    End
}
#endregion

#region //++Tool Defines 
public enum EventStartType { INTERACT, AUTOSTART, TRIGGER_ENTER, TRIGGER_EXIT, NONE, KEY_PRESS, DROP };
public enum AIConditionNeeded { ALL, ONE };
public enum ValueCheck { EQUALS, LESS, GREATER };
public enum SimpleOperator { ADD, SUB, SET };
public enum MouseButton { Left = 0, Right, Wheel };


#endregion

/// <summary>
/// UI 패널 ID 
/// </summary>
public enum UI_Type
{
    LoadingGame = 67001,//로딩화면
    BaseMain,//베이스 메인ui
    Shop,//상점
    MessageManager,//메시지매니저
    Message,//메시지함(메일)
    BuildingInfo,//빌딩정보 + 빌딩업그레이드
    Factory,//팩토리 - 오버뷰,유닛훈련(팩토리클릭시),지원무기생산(skilllab클릭시),빠른훈련,거라지(cp클릭시)
    Upgrade,//업그레이드 - 유닛+지원무기업그레이드패널(아모리클릭시),기술연구(팩토리애드온클릭시),아바타파츠강화및승급(아바타랩클릭시)
    UnitInfoAndUpgrade,//유닛 및 지원무기의 (정보+업그레이드)
    AvatarPartsInfo,//아바타 파츠정보 + 아바타강화,승급
    GarageAvatar,//거라지 아바타 스파인
    Explore,//탐사
    popup_small,//팝업(소형) - 유저에게 물어볼것들(캐쉬구매,취소등)
    popup_mid,//팝업(중형) - 현재는 탐사 보상만 보여준다.
    Union,//유니온
    Chat, //채팅창
    EditMain,//에디트맵 메인ui
    Replay,//리플레이 ui - 테스트용
    BattleSelect,//배틀선택화면 - 싱글캠페인도 선택
    BattleMain,//전투 main
    BattleResult,//전투결과
    BackPanel,//패널,팝업오픈시에 배경에 깔아줄 검은색 반투명 패널 - 수동으로 패널뎁스를 조정해준다. 또한 화면크기만한 버튼을 장착해서 이벤트를 매번 다르게 수행한다.
    ServerWait,//서버등의 데이터를 기다릴떄 나오는 UI
    BattleLog,//배틀로그
    ReplayMain,//리플레이 메인
    ReplayResult,//리플레이 결과
    SingleStageMainUI,//켐페인 메인
    SingleStageResult,//켐페인 결과
    Setting,//설정창
    Rank,//랭크창
    Profile,//프로필
    ProfileDetail,//프로필창에서 들어가는 세부정보창.
    Max
}

//ui 버튼 종류별 모음
public enum UI_Button
{
    ShopItemNormal = 0,
    ShopItemPackage,

}

//인게임UI - 건설ok,cancle버튼,건설중이미지,프로그레스바,타임텍스트,hpbar등
public enum UI_Ingame
{
    buildingTimeText = 0,
    buildingTimeProgressbar,
    buildProgressImage2x2,
    buildProgressImage3x3,
    buildProgressImage5x5,
    buildTileSet2x2,
    buildTileSet3x3,
    buildTileSet5x5,

}


public enum GameLayerName
{
    Default = 0,
    UI = 5,
    InGameUI = 8,

}

public enum GameTagName
{
    UICamera,
    Barrel,
    Grass,
    Drag_and_Drop_Root,
    MapBounds,
    Unit,
    IngameUI_OkButton,
    IngameUI_CancleButton,
    Construct,
    Building,
    GrdiLabel,
    IngameUI_ResourceIcon,
    Bullet,
    Chicken,
    SplatformOverlay,
    MyAvatar,
    EnemyAvatar,
    SpacePlatform,
    Ally,
    Enemy,
}


//자원타입
public enum ResourceType : int
{
    Topaz = 0,
    Ame,
    Acid,
    Aqua,

    end
}



/// <summary>ㅐ
/// 이펙트리스트
/// </summary>
public enum EffectId
{
    None = -1,
    ArtilleryMissile = 0,
    CannonMissile,
    ExplosionEffect1,
    ExplosionEffect2,
    FlameEffect,
    ICBMMissile,
    ParalyzeExplosion,
    ParalyzeField,
    PlasmaWaveEffect,
    TurretMissile,

    End
}
/// <summary>
/// 이펙트 타입.
/// </summary>
public enum EffectType
{
    Normal = 0,
    Parabola,
    FlameThrower,
    Paralyzer,
    Lightning,
    Rocket,
    Laser,
    MultiLightning,
    MultiParabola,
    FireStrike, //서포트 웨폰 화력지원.
    ICBM,
    Max,
}



public enum specialUID
{
    SupportWeapon_FireStrike = 1000001,
    SupportWeapon_DynamicHeal = 1000002,

    Max
}

public enum ReplayNoticeType
{
    None = -1,
    SpawnUnit = 0,
    SpawnAvatar,
    SupportWeapon,
    AvatarSkill,
    AvatarRetargeting,

}
/// <summary>
/// 파괴 이미지 출력에 사용.
/// </summary>
public enum DestroyType
{
    None = -1,
    Building2,
    Building3,
    Building5,
    Unit,
    Avatar,
    Max
}

/// <summary>
/// 타겟 선별에 사용.
/// </summary>
public enum TargetSiteType
{
    None = -1,
    Ground,
    Air,
    Ground_Air,
}

/// <summary>
/// 유닛 이동 타입.
/// </summary>
public enum MoveType
{
    None = -1,
    Ground,
    Air,
    Ground_Air,
}


public static class INIT_TIME
{
    public static DateTime get = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
}


