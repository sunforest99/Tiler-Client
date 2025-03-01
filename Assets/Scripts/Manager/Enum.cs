﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 타일 방향
 * 좌, 좌하, 우하, 좌상, 우상, 우
 */
public enum DIRECTION
{
    W = 0, SW = 1, SE = 2, NW = 3, NE = 4, E = 5
}

/*
 * 타일 종류에 대한 코드
 */
public enum TILE
{
    GRASS = 0,
    SAND,
    DIRT,
    STONE,
    CAN_MOVE,
    GRASS_START = 'A',
    SAND_START = 'B',
    DIRT_START = 'C',
    STONE_START = 'D',
    GRASS_TREE = 'E',
    GRASS_STONE = 'F',
    SAND_TREE = 'G',
    SAND_STONE = 'H',
    DIRT_TREE = 'I',
    DIRT_STONE = 'J',
    STONE_DECO1 = 'K',
    STONE_DECO2 = 'L',
    SEA_01 = 'M',
    SEA_02 = 'N',
    SEA_03 = 'O',
    MARS = -1
}

/*
 * 어떤 행동인지에 대한 코드
 */
public enum ACTIVITY
{
    NONE = 100,
    ACTING,                     // 행동중
    MOVE,                       // 이동
    BUILD_MINE,                 // 광산 짓기
    BUILD_FARM,                 // 농장 짓기
    BUILD_ATTACK_BUILDING,      // 공격 건물 짓기
    BUILD_MILLITARY_BASE,       // 유닛 생성 건물 짓기
    BUILD_SHIELD_BUILDING,      // 방어 건물 짓기
    BUILD_UPGRADE_BUILDING,     // 업그레이드 건물 짓기
    WORKER_UNIT_CREATE,         // 워커 유닛 생성
    SOLDIER_0_UNIT_CREATE,      // 군사 유닛 0 생성
    SOLDIER_1_UNIT_CREATE,      // 군사 유닛 1 생성
    SOLDIER_2_UNIT_CREATE,      // 군사 유닛 2 생성
    WITCH_0_UNIT_CREATE,        // 마녀 유닛 0 생성
    WITCH_1_UNIT_CREATE,        // 마녀 유닛 1 생성
    DESTROY_BUILT,              // 건물 파괴
    ATTACK,                     // 공격
}

public enum BUILT
{
    MINE = 200,
    FARM,
    ATTACK_BUILDING,
    MILLITARY_BASE,
    CASTLE,
    SHIELD_BUILDING,
    UPGRADE_BUILDING,
    AIRDROP
}

public enum UNIT
{
    FOREST_WORKER = 300,
    FOREST_SOLDIER_0,
    FOREST_SOLDIER_1,
    FOREST_SOLDIER_2,
    FOREST_WITCH_0,
    FOREST_WITCH_1,
    SEA_WORKER,
    SEA_SOLDIER_0,
    SEA_SOLDIER_1,
    SEA_SOLDIER_2,
    SEA_WITCH_0,
    SEA_WITCH_1,
    DESERT_WORKER,
    DESERT_SOLDIER_0,
    DESERT_SOLDIER_1,
    DESERT_SOLDIER_2,
    DESERT_WITCH_0,
    DESERT_WITCH_1,
}

/**
 * @brief 건물에 유닛 생성 범위 함수가 Static 일 경우에 사용
 */
public enum UNIQEDISTANCE
{
    DISTANCE = 1
}

public enum TRIBE
{
    FOREST = 0,
    SEA,
    DESERT
}
public enum COLOR
{
    COLOR_0 = 0,
    COLOR_1,
    COLOR_2,
    COLOR_3,
    COLOR_4,
    COLOR_5,
    COLOR_6,
    COLOR_7,
    COLOR_8
}

public class CustomColor
{
    public static string TransColor(COLOR color)
    {
        switch (color)
        {
            case COLOR.COLOR_0:
                return "#CA3E77";
            case COLOR.COLOR_1:
                return "#4474C5";
            case COLOR.COLOR_2:
                return "#44C59B";
            case COLOR.COLOR_3:
                return "#E05A5D";
            case COLOR.COLOR_4:
                return "#FBFF3B";
            case COLOR.COLOR_5:
                return "#676767";
            case COLOR.COLOR_6:
                return "#69E4E5";
            case COLOR.COLOR_7:
                return "#A969E5";
            case COLOR.COLOR_8:
                return "#FFA340";
        }
        return "#000000";
    }
}