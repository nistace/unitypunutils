using Photon.Pun;

namespace Utils.Pun {
	public static class PunUtils {
		public static bool offlineOrNoRoom => PhotonNetwork.OfflineMode || PhotonNetwork.CurrentRoom == null;
	}
}