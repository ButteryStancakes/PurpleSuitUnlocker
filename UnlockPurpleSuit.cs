using System.Reflection;

namespace PurpleSuitUnlocker
{
    internal class UnlockPurpleSuit
    {
        public static void SpawnPurpleSuit()
        {
            if (StartOfRound.Instance.IsServer && !StartOfRound.Instance.isChallengeFile && ES3.Load("FinishedChallenge", "LCChallengeFile", false) && Plugin.configEventRequirement.Value)
                typeof(StartOfRound).GetMethod("SpawnUnlockable", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(StartOfRound.Instance, new object[]{24});
            else if (StartOfRound.Instance.IsServer && !StartOfRound.Instance.isChallengeFile && !Plugin.configEventRequirement.Value)
                typeof(StartOfRound).GetMethod("SpawnUnlockable", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(StartOfRound.Instance, new object[] { 24 });
        }
    }
}
