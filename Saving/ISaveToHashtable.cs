using ExitGames.Client.Photon;

namespace Utils.Pun.Saving {
	public interface ISaveToHashtable {
		void Save(Hashtable data, string root);
	}
}