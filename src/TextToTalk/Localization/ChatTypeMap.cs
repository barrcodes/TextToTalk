using System.Collections.Generic;
using Dalamud.Game;
using Dalamud.Game.Text;
using Dalamud.Plugin.Services;
using Lumina.Excel.Sheets;
using TextToTalk.GameEnums;
using TextToTalk.Resources;

namespace TextToTalk.Localization
{
    internal static class ChatTypeMap
    {
        internal static readonly IReadOnlyDictionary<int, uint> LogFilterRowIds =
            new Dictionary<int, uint>
            {
                [(int)XivChatType.None] = 0,
                [(int)XivChatType.Say] = 1,
                [(int)XivChatType.Shout] = 2,
                [(int)XivChatType.TellOutgoing] = 3,
                [(int)XivChatType.TellIncoming] = 3,
                [(int)XivChatType.Party] = 4,
                [(int)XivChatType.StandardEmote] = 5,
                [(int)XivChatType.CustomEmote] = 6,
                [(int)XivChatType.FreeCompany] = 7,
                [(int)XivChatType.Ls1] = 8,
                [(int)XivChatType.Ls2] = 9,
                [(int)XivChatType.Ls3] = 10,
                [(int)XivChatType.Ls4] = 11,
                [(int)XivChatType.Ls5] = 12,
                [(int)XivChatType.Ls6] = 13,
                [(int)XivChatType.Ls7] = 14,
                [(int)XivChatType.Ls8] = 15,
                [(int)XivChatType.Yell] = 16,
                [(int)XivChatType.Alliance] = 17,
                [(int)XivChatType.NoviceNetwork] = 18,
                [(int)XivChatType.PvPTeam] = 19,
                [(int)XivChatType.CrossLinkShell1] = 20,
                [(int)XivChatType.SystemMessage] = 21,
                [(int)XivChatType.SystemError] = 37,
                [(int)XivChatType.GatheringSystemMessage] = 23,
                [(int)XivChatType.ErrorMessage] = 24,
                [(int)XivChatType.Echo] = 25,
                [(int)XivChatType.NPCDialogue] = 26,
                [(int)XivChatType.LootNotice] = 27,
                [(int)XivChatType.Progress] = 28,
                [(int)XivChatType.LootRoll] = 30,
                [(int)XivChatType.Crafting] = 32,
                [(int)XivChatType.Gathering] = 35,
                [(int)XivChatType.NPCDialogueAnnouncements] = 39,
                [(int)XivChatType.FreeCompanyAnnouncement] = 40,
                [(int)XivChatType.FreeCompanyLoginLogout] = 41,
                [(int)XivChatType.RetainerSale] = 43,
                [(int)XivChatType.PeriodicRecruitmentNotification] = 44,
                [(int)XivChatType.Sign] = 45,
                [(int)XivChatType.RandomNumber] = 46,
                [(int)XivChatType.NoviceNetworkSystem] = 47,
                [(int)XivChatType.PvpTeamAnnouncement] = 49,
                [(int)XivChatType.PvpTeamLoginLogout] = 50,
                [(int)XivChatType.Damage] = 51,
                [(int)XivChatType.Miss] = 52,
                [(int)XivChatType.Action] = 53,
                [(int)XivChatType.Item] = 54,
                [(int)XivChatType.Healing] = 55,
                [(int)XivChatType.GainBuff] = 56,
                [(int)XivChatType.GainDebuff] = 57,
                [(int)XivChatType.LoseBuff] = 65,
                [(int)XivChatType.LoseDebuff] = 66,
                [(int)XivChatType.Alarm] = 67,
                [(int)XivChatType.GlamourNotifications] = 68,
                [(int)XivChatType.CrossParty] = 4,
                [(int)XivChatType.CrossLinkShell2] = 300,
                [(int)XivChatType.CrossLinkShell3] = 301,
                [(int)XivChatType.CrossLinkShell4] = 302,
                [(int)XivChatType.CrossLinkShell5] = 303,
                [(int)XivChatType.CrossLinkShell6] = 304,
                [(int)XivChatType.CrossLinkShell7] = 305,
                [(int)XivChatType.CrossLinkShell8] = 306,
                [(int)AdditionalChatType.ActionUsedOnYou] = 60,
                [(int)AdditionalChatType.FailedActionUsedOnYou] = 59,
                [(int)AdditionalChatType.ActionReadiedByYou] = 53,
                [(int)AdditionalChatType.BeneficialEffectOnYou] = 63,
                [(int)AdditionalChatType.BeneficialEffectOnYouEnded] = 65,
                [(int)AdditionalChatType.DamageDealtByYou] = 51,
                [(int)AdditionalChatType.DetrimentalEffectsInflictedByYou] = 57,
                [(int)AdditionalChatType.ActionUsedByOtherPlayer] = 93,
                [(int)AdditionalChatType.BeneficialEffectOnOtherPlayer] = 103,
                [(int)AdditionalChatType.DetrimentalEffectOnOtherPlayer] = 104,
                [(int)AdditionalChatType.BeneficialEffectOnOtherPlayerEnded] = 105,
                [(int)AdditionalChatType.FreeCompanyMemberLoginNotifications] = 41,
                [(int)AdditionalChatType.ActionReadiedByEngagedEnemy] = 113,
                [(int)AdditionalChatType.DamageYouAreDealt] = 58,
                [(int)AdditionalChatType.FailedAttacksOnYou] = 59,
                [(int)AdditionalChatType.DetrimentalEffectOnEnemyEnded] = 126,
            };

        internal static readonly IReadOnlyDictionary<int, uint> AddonRowIds =
            new Dictionary<int, uint>
            {
                [(int)XivChatType.Urgent] = 2251,
                [(int)XivChatType.Notice] = 12874,
            };

        internal static readonly IReadOnlyDictionary<XivChatType, XivChatType> GmBaseChatTypes =
            new Dictionary<XivChatType, XivChatType>
            {
                [XivChatType.GmTell] = XivChatType.TellIncoming,
                [XivChatType.GmSay] = XivChatType.Say,
                [XivChatType.GmShout] = XivChatType.Shout,
                [XivChatType.GmYell] = XivChatType.Yell,
                [XivChatType.GmParty] = XivChatType.Party,
                [XivChatType.GmFreeCompany] = XivChatType.FreeCompany,
                [XivChatType.GmLinkshell1] = XivChatType.Ls1,
                [XivChatType.GmLinkshell2] = XivChatType.Ls2,
                [XivChatType.GmLinkshell3] = XivChatType.Ls3,
                [XivChatType.GmLinkshell4] = XivChatType.Ls4,
                [XivChatType.GmLinkshell5] = XivChatType.Ls5,
                [XivChatType.GmLinkshell6] = XivChatType.Ls6,
                [XivChatType.GmLinkshell7] = XivChatType.Ls7,
                [XivChatType.GmLinkshell8] = XivChatType.Ls8,
                [XivChatType.GmNoviceNetwork] = XivChatType.NoviceNetwork,
            };

        internal static bool TryGetAdditionalChannelName(int chatType, out string name)
        {
            name = chatType switch
            {
                (int)XivChatType.Debug => Strings.ChatTypeDebug,
                (int)XivChatType.CrossParty => Strings.ChatTypeCrossParty,
                (int)XivChatType.Orchestrion => Strings.ChatTypeOrchestrion,
                (int)XivChatType.TellIncoming => Strings.ChatTypeTellIncoming,
                (int)XivChatType.TellOutgoing => Strings.ChatTypeTellOutgoing,
                (int)AdditionalChatType.EnemyDefeatedByYou => Strings.ChatTypeEnemyDefeatedByYou,
                _ => string.Empty,
            };
            return name.Length > 0;
        }

        internal static bool TryGetLogFilterName(IDataManager data, ClientLanguage language, int chatType, out string name)
        {
            name = string.Empty;
            return LogFilterRowIds.TryGetValue(chatType, out var rowId)
                   && data.GetExcelSheet<LogFilter>(language)?.TryGetRow(rowId, out var row) == true
                   && !string.IsNullOrWhiteSpace(name = row.Name.ToString());
        }

        internal static bool TryGetAddonName(IDataManager data, ClientLanguage language, int chatType, out string name)
        {
            name = string.Empty;
            return AddonRowIds.TryGetValue(chatType, out var rowId)
                   && data.GetExcelSheet<Addon>(language)?.TryGetRow(rowId, out var row) == true
                   && !string.IsNullOrWhiteSpace(name = row.Text.ToString());
        }
    }
}
