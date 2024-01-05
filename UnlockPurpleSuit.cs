using System.Reflection;

namespace PurpleSuitUnlocker
{
    internal class UnlockPurpleSuit
    {
        public static void SpawnPurpleSuit()
        {
            if (StartOfRound.Instance.IsServer && !StartOfRound.Instance.isChallengeFile && ES3.Load("FinishedChallenge", "LCChallengeFile", false))
                typeof(StartOfRound).GetMethod("SpawnUnlockable", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(StartOfRound.Instance, new object[]{24});
        }
    }
}
