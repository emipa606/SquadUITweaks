using HarmonyLib;
using RimWorld;
using Verse;

namespace SquadUITweaks;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    static HarmonyPatches()
    {
        var harmony = new Harmony("drumad.rimworld.mod.squadUItweaks");

        var type = typeof(HarmonyPatches);

        harmony.Patch(
            AccessTools.Method(typeof(PawnAttackGizmoUtility),
                nameof(PawnAttackGizmoUtility.CanShowEquipmentGizmos)), null,
            new HarmonyMethod(type, nameof(CanShowEquipmentGizmos_postfix)));
        harmony.Patch(AccessTools.Method(typeof(PawnAttackGizmoUtility), "ShouldUseSquadAttackGizmo"),
            new HarmonyMethod(type, nameof(ShouldUseSquadAttackGizmo_Postfix)));
        harmony.Patch(
            AccessTools.Method(typeof(PawnAttackGizmoUtility),
                "GetSquadAttackGizmo"), null, new HarmonyMethod(type,
                nameof(GetSquadAttackGizmo_Postfix)));
    }

    public static void CanShowEquipmentGizmos_postfix(ref bool __result)
    {
        __result = true;
    }

    public static void ShouldUseSquadAttackGizmo_Postfix(ref bool __result)
    {
        if (__result)
        {
            return;
        }

        __result = (bool)Traverse.Create(typeof(PawnAttackGizmoUtility))
            .Method("AtLeastOneSelectedPlayerPawnHasRangedWeapon").GetValue();
    }


    public static void GetSquadAttackGizmo_Postfix(
        ref Gizmo __result)
    {
        if (__result is Command_Target command)
        {
            __result = new Command_Target_Extended(command);
        }
    }
}