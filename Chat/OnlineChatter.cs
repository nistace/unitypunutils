using Photon.Pun;
using Utils.Pun.Extensions;

namespace Utils.Pun.Chat {
	public class OnlineChatter : MonoBehaviourMyPun {
		public void SendMessageToChat(string message) => this.Rpc(RpcTarget.All, RpcSendMessage, message);

		[PunRPC] private void RpcSendMessage(string message) => OnlineChatEventSystem.onMessageSent.Invoke(photonView.Owner.NickName, message);
	}
}