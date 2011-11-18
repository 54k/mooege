﻿/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

namespace Mooege.Net.GS.Message
{
    public enum Opcodes : int
    {
        TryConsoleCommand1 = 1,
        TryConsoleCommand2 = 2,
        QuitGameMessage = 3, // len: 	12
        CreateBNetGameMessage = 4, // len: 	88
        CreateBNetGameResultMessage = 5, // len: 	40
        DWordDataMessage1 = 6, // len: 	12
        RequestJoinBNetGameMessage = 8, // len: 	56
        BNetJoinGameRequestResultMessage = 9, // len: 	72
        JoinBNetGameMessage = 10, // len: 	80
        JoinLANGameMessage = 11, // len: 	196
        VersionsMessage = 13, // len: 	48
        GenericBlobMessage1 = 14, // len: 	
        NetworkAddressMessage = 15, // len: 	16
        GameIdMessage = 17, // len: 	32
        UInt64DataMessage = 18, // len: 	16
        IntDataMessage1 = 20, // len: 	12
        EntityIdMessage = 22, // len: 	24
        CreateHeroMessage = 23, // len: 	68
        CreateHeroResultMessage = 24, // len: 	32
        SimpleMessage1 = 25, // len: 	8
        BlizzconCVarsMessage = 26, // len: 	20
        SimpleMessage2 = 27, // len: 	8
        GenericBlobMessage2 = 28, // len: 	
        GenericBlobMessage3 = 29, // len: 	
        GenericBlobMessage4 = 30, // len: 	
        GenericBlobMessage5 = 31, // len: 	
        OpenArtisanWindowMessage = 32, // len: 	12 former ANNDataMessage1
        SimpleMessage3 = 33, // len: 	8
        OpenTradeWindow = 34, // len: 	12          former ANNDataMessage2
        RequestBuyItemMessage = 35, // len: 	12, former ANNDataMessage3
        RequestSellItemMessage = 36, // len: 	12, former ANNDataMessage4
        RequestUseCauldronOfJordanMessage = 37, // len: 	12  former ANNDataMessage5
        LogoutContextMessage1 = 38, // len: 	16
        LogoutTickTimeMessage = 39, // len: 	20
        LogoutComplete = 40, // len: 	8 formor SimpleMessage4
        LogoutContextMessage2 = 41, // len: 	16
        PlayerIndexMessage1 = 42, // len: 	12
        PlayerIndexMessage2 = 43, // len: 	12
        SimpleMessage5 = 44, // len: 	8
        SimpleMessage6 = 45, // len: 	8
        GenericBlobMessage6 = 46, //len:    
        ConnectionEstablishedMessage = 47, // len: 	20
        GameSetupMessage = 48, // len: 	20
        SimpleMessage7 = 49, // len: 	8
        NewPlayerMessage = 50, // len: 	16916
        GenericBlobMessage7 = 51, // len: 	
        //HeroStateData = 50, // len: 	
        EnterWorldMessage = 52, // len: 	28
        RevealSceneMessage = 53, // len: 	1292
        DestroySceneMessage = 54, // len: 	16
        SwapSceneMessage = 55, // len: 	20
        RevealWorldMessage = 56, // len: 	16
        RevealTeamMessage = 57, // len: 	20
        PlayerActorSetInitialMessage = 58, // len: 	16
        HeroStateMessage = 59, // len: 	16652
        ACDEnterKnownMessage = 60, // len: 	132
        ACDDestroyActorMessage = 61, // len: 	12 former ANNDataMessage
        PlayerEnterKnownMessage = 62, // len: 	16
        ACDCreateActorMessage = 63, // len: 	12 former ANNDataMessage
        ACDWorldPositionMessage = 64, // len: 	48
        ACDInventoryPositionMessage = 65, // len: 	32
        ACDInventoryUpdateActorSNO = 66, // len: 	16
        TrickleMessage = 67, // len: 	116
        ANNDataMessage8 = 68, // len: 	12
        MapRevealSceneMessage = 69, // len: 	52
        SavePointInfoMessage = 70, // len: 	12
        HearthPortalInfoMessage = 71, // len: 	16
        ReturnPointInfoMessage = 72, // len: 	12
        AffixMessage = 73, // len: 	148
        RareMonsterNamesMessage = 74, // len: 	52
        RareItemNameMessage = 75, // len: 	28
        PortalSpecifierMessage = 76, // len: 	24
        AttributeSetValueMessage = 77, // len: 	28
        AttributesSetValuesMessage = 78, // len: 	256
        VisualInventoryMessage = 79, // len: 	140
        ProjectileStickMessage = 80, // len: 	28
        TargetMessage = 81, // len: 	60
        SecondaryAnimationPowerMessage = 82, // len: 	28
        LoopingAnimationPowerMessage = 83, // len:  20
        //SNODataMessage1 = 82, // len: 	12  removed 7728
        DWordDataMessage2 = 84, // len: 	12
        DWordDataMessage3 = 85, // len: 	12
        DWordDataMessage4 = 86, // len: 	12
        DWordDataMessage5 = 87, // len: 	12
        TryChatMessage = 88, // len: 	528
        ChatMessage = 89, // len: 	528
        ANNDataMessage9 = 90, // len: 	12
        InventoryRequestMoveMessage1 = 91, // len: 	28
        InventoryRequestSocketMessage = 92, // len: 	16
        InventoryRequestMoveMessage2 = 93, // len: 	28
        InventorySplitStackMessage = 94, // len: 	40
        InventoryDropStackPortionMessage = 95, //len:   24
        InventoryStackTransferMessage = 96, // len: 	24
        ANNDataMessage10 = 97, // len: 	12
        ANNDataMessage11 = 98, // len: 	12
        InventoryRequestUseMessage = 99, // len: 	36
        SocketSpellMessage = 100, // len: 	16
        HelperDetachMessage = 101, // len: 	12
        AssignSkillMessage1 = 102, // len: 	16
        AssignSkillMessage2 = 103, // len: 	16
        AssignSkillMessage3 = 104, // len: 	16
        AssignSkillMessage4 = 105, // len: 	16
        HirelingRequestLearnSkillMessage = 106, // len: 	20
        HotbarButtonData = 107, // len: 	12 former ANNDataMessage12
        PlayerChangeHotbarButtonMessage = 108, // len: 	20
        PlayAnimationMessageSpec = 109, // len: 	12 former IntDataMessage2
        PlayAnimationMessage = 110, // len: 	72
        ANNDataMessage13 = 111, // len: 	12
        NotifyActorMovementMessage = 112, // len: 	76 former ACDTranslateNormalMessage1
        ACDTranslateSnappedMessage = 113, // len: 	36
        ACDTranslateFacingMessage1 = 114, // len: 	20
        ACDTranslateFixedMessage = 115, // len: 	36
        ACDTranslateArcMessage = 116, // len: 	60
        ACDTranslateDetPathMessage = 117, // len: 	88
        ACDTranslateDetPathSinMessage = 118, // len: 	104
        ACDTranslateDetPathSpiralMessage = 119, // len: 	72
        ACDTranslateSyncMessage = 120, // len: 	32
        ACDTranslateFixedUpdateMessage = 121, // len: 	36
        PlayerMovementMessage = 122, //len:    75 former ACDTranslateNormalMessage2
        ACDTranslateFacingMessage2 = 123, // len: 	20
        PlayEffectMessage = 124, // len: 	24
        PlayHitEffectMessage = 125, // len: 	24
        PlayHitEffectOverrideMessage = 126, // len: 	20
        PlayNonPositionalSoundMessage = 127, // len: 	12
        PlayErrorSoundMessage = 128, // len: 	12
        PlayMusicMessage = 129, // len: 	12
        PlayCutsceneMessage = 130, // len: 	12
        ComplexEffectAddMessage = 131, // len: 	36
        FlippyMessage = 132, // len: 	32
        WaypointActivatedMessage = 133, // len: 	20
        OpenWaypointSelectionWindowMessage = 134, // len: 	12 former ANNDataMessage
        ANNDataMessage15 = 135, // len: 	12
        ANNDataMessage16 = 136, // len: 	12
        AimTargetMessage = 137, // len: 	36
        ACDChangeGBHandleMessage = 138, // len: 	20
        GameTickMessage = 139, // len: 	12  former DWordDataMessage
        //LearnedSkillMessage = 138, // len: 	524  removed 7728
        DataIDDataMessage1 = 140, // len: 	12
        DataIDDataMessage2 = 141, // len: 	12
        EndOfTickMessage = 142, // len: 	16
        TryWaypointMessage = 143, // len: 	16
        NPCInteractOptionsMessage = 144, // len: 	340
        ANNDataMessage17 = 145, // len: 	12
        ANNDataMessage18 = 146, // len: 	12
        SimpleMessage8 = 147, // len: 	8
        QuestUpdateMessage = 148, // len: 	28
        QuestMeterMessage = 149, // len: 	20
        QuestCounterMessage = 150, // len: 	20
        GenericBlobMessage8 = 151, // len: 	
        //PlayerInteractMessage = 151, // len: 	16 removed 7728
        PlayerIndexMessage3 = 152, // len: 	12
        PlayerLevel = 153, // len: 	16
        OpenSharedStashMessage = 154, // len: 	12, former ANNDataMessage19
        ANNDataMessage19 = 155, //len:  12 added 7728
        SimpleMessage9 = 156, // len: 8
        ACDPickupFailedMessage = 157, // len: 	16
        PetMessage = 158, // len: 	24
        ANNDataMessage20 = 159, // len: 	12
        HirelingInfoUpdateMessage = 160, // len: 	24
        UIElementMessage = 161, // len: 	16
        PlayerBusyMessage = 162, // len: 	12      //  former: BoolDataMessage
        TradeMessage1 = 163, // len: 	56
        TradeMessage2 = 164, // len: 	56
        PlayerIndexMessage4 = 165, // len: 	12
        SimpleMessage10 = 166, // len: 	8
        PlayerIndexMessage5 = 167, // len: 	12
        SetIdleAnimationMessage = 168, // len: 	16
        ACDCollFlagsMessage = 169, // len: 	16
        GoldModifiedMessage = 170, // len: 	12
        ActTransitionMessage = 171, // len: 	16
        InterstitialMessage = 172, // len: 	16
        EffectGroupACDToACDMessage = 173, // len: 	20
        RopeEffectMessageACDToACD = 174, // len: 	28
        RopeEffectMessageACDToPlace = 175, // len: 	36
        ANNDataMessage21 = 176, // len: 	12
        ANNDataMessage22 = 177, // len: 	12
        GameSyncedDataMessage = 178, // len: 	96
        ACDChangeActorMessage = 179, // len: 	16
        PlayerWarpedMessage = 180, // len: 	16
        VictimMessage = 181, // len: 	48
        KillCountMessage = 182, // len: 	24
        WorldStatusMessage = 183, // len: 	16
        WeatherOverrideMessage = 184, // len: 	16
        SimpleMessage11 = 185, // len: 	8
        ACDShearMessage = 186, // len: 	16
        ACDGroupMessage = 187, // len: 	20
        SimpleMessage12 = 188, // len: 	8
        PlayConvLineMessage = 189, // len: 	172
        StopConvLineMessage = 190, // len: 	16
        AdvanceConvMessage = 191, //len : 16
        UpdateConvAutoAdvanceMessage = 192, // len: 20
        RequestCloseConversationWindowMessage = 193, // len: 	8 former SimpleMessage13
        EndConversationMessage = 194, // len: 	20
        SNODataMessage2 = 195, // len: 	12
        FinishConversationMessage = 196, // len: 	12
        HirelingSwapMessage1 = 197, // len: 	12
        HirelingSwapMessage2 = 198, // len: 	12
        SimpleMessage14 = 199, // len: 	8
        DeathFadeTimeMessage = 200, // len: 	24
        ANNDataMessage23 = 201, // len: 	12
        ANNDataMessage24 = 202, // len: 	12
        DisplayGameTextMessage = 203, // len: 	536
        IntDataMessage4 = 204, // len: 	12
        DWordDataMessage7 = 205, // len: 	12
        GBIDDataMessage1 = 206, // len: 	12
        ANNDataMessage25 = 207, // len: 	12
        ANNDataMessage26 = 208, // len: 	12
        ACDLookAtMessage = 209, // len: 	16
        KillCounterUpdateMessage = 210, // len: 	24
        LowHealthCombatMessage = 211, // len: 	16
        SaviorMessage = 212, // len: 	16
        FloatingNumberMessage = 213, // len: 	20
        FloatingAmountMessage = 214, // len: 	40
        RemoveRagdollMessage = 215, // len: 	16
        SNONameDataMessage = 216, // len: 	16
        PlayLoreImmediately = 217, // len: 	16
        SimpleMessage15 = 220, // len: 	8
        WorldDeletedMessage = 221, // len: 	12
        SimpleMessage16 = 222, // len: 	8
        IntDataMessage5 = 223, // len: 	12
        TimedEventStartedMessage = 224, // len: 	20
        SNODataMessage4 = 225, // len: 	12
        ActTransitionStartedMessage = 226, // len: 	16
        RequestBuySharedStashSlotsMessage = 227, // len: 	8   former SimpleMessage17
        SimpleMessage17 = 228, // len: 	8 //added in 7728
        PlayerQuestMessage1 = 229, // len: 	16
        PlayerQuestMessage2 = 230, // len: 	16
        PlayerDeSyncSnapMessage = 231, // len: 	28
        RequestUseNephalemCubeMessage = 232, // len: 	12              former ANNDataMessage27
        SalvageResultsMessage = 233, // len: 	60
        SimpleMessage18 = 234, // len: 	8
        Message = 235, //len: 36
        //ChatMessage2 = 231, // len: 	528 remove 7728
        SimpleMessage19 = 236, // len: 	8
        MapMarkerInfoMessage = 237, // len: 	72
        GenericBlobMessage9 = 238, // len: 	
        GenericBlobMessage10 = 239, // len: 	
        GenericBlobMessage11 = 240, // len: 	
        GenericBlobMessage12 = 241, // len: 	
        GenericBlobMessage13 = 242, // len: 	
        GenericBlobMessage14 = 243, // len: 	
        ANNDataMessage28 = 244, // len: 	12
        DebugActorTooltipMessage = 245, // len: 	524
        BossEncounterMessage1 = 246, // len: 	16
        SimpleMessage20 = 247, // len: 	8
        SimpleMessage21 = 248, // len: 	8
        BossEncounterMessage2 = 249, // len: 	16
        SimpleMessage22 = 250, // len: 	8
        SimpleMessage23 = 251, // len: 	8
        EncounterInviteStateMessage = 252, // len: 	12
        SimpleMessage24 = 253, // len: 	8
        SimpleMessage25 = 254, // len: 	8
        PlayerIndexMessage6 = 255, // len: 	12
        SimpleMessage26 = 256, // len: 	8
        SimpleMessage27 = 257, // len: 	8
        SimpleMessage28 = 258, // len: 	8
        SimpleMessage29 = 259, // len: 	8
        CameraFocusMessage = 260, // len: 	20
        CameraZoomMessage = 261, // len: 	20
        CameraYawMessage = 262, // len: 	20
        SimpleMessage30 = 263, // len: 	8
        BoolDataMessage2 = 264, // len: 	12
        BossZoomMessage = 265, // len: 	16
        EnchantItemMessage = 266, // len: 	16
        ANNDataMessage29 = 267, // len: 	12
        SimpleMessage31 = 268, // len: 	8
        SimpleMessage32 = 269, // len: 	8
        RequestAddSocketMessage = 270, // len: 	12 former ANNDataMessage30
        SimpleMessage33 = 271, // len: 	8
        IntDataMessage6 = 272, // len: 	12
        DebugDrawPrimMessage = 273, // len: 	188
        GBIDDataMessage2 = 274, // len: 	12
        CraftingResultsMessage = 275, // len: 	20
        CrafterLevelUpMessage = 276, // len: 	20
        SimpleMessage34 = 277, // len: 	8
        ANNDataMessage31 = 278, // len: 	12
        ANNDataMessage32 = 279, // len: 	12
        IntDataMessage7 = 280, // len: 	12
        IntDataMessage8 = 281, // len: 	12
        SimpleMessage35 = 282, // len: 	8
        SimpleMessage36 = 283, // len: 	8
        GameTestingSamplingStartMessage = 284, // len: 	16
        SimpleMessage37 = 285, // len: 	8
        TutorialShownMessage = 286, // len: 	12 former SNODataMessage
        RequestBuffCancelMessage = 287, // len: 	16
        SimpleMessage38 = 288, // len: 	8
        PlayerIndexMessage7 = 289, // len: 	12
        SimpleMessage39 = 290, // len: 	8
        SimpleMessage40 = 291, // len: 	8
        DWordDataMessage8 = 292, // len: 	12
        DWordDataMessage9 = 293, // len: 	12
        DWordDataMessage10 = 294, // len: 	12
        DWordDataMessage11 = 295, // len: 	12
        BroadcastTextMessage = 296, // len: 	520
        SimpleMessage41 = 297, // len: 	8
        SimpleMessage42 = 298, // len: 	8
        NPCSelectConversationMessage = 299, // len: 	12 former SNODataMessage6
        HirelingDismissMessage = 300, // len: 	12 former ANNDataMessage33
        SimpleMessage43 = 301, // len: 	8
        HirelingHireMessage = 302, // len: 	8 former SimpleMessage44
        HirelingInventoryMessage = 303, // len: 	8 former SimpleMessage45
        SNODataMessage7 = 304, // len:  12
        SimpleMessage46 = 305, // len: 	8
        VoteKickMessage1 = 306, //len:   528
        PlayerIndexMessage8 = 307, // len: 	12
        PlayerIndexMessage9 = 308, // len: 	12
        VoteKickMessage2 = 309, //len:   528
        BoolDataMessage3 = 310, // len: 	12
        PlayerIndexMessage10 = 311, // len: 	12
        PlayerIndexMessage11 = 312, // len: 	12
    }
}
