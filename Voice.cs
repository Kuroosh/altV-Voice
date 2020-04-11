using AltV.Model;
using AltV.Net;
using AltV.Net.Elements.Entities;
using System;
using System.IO;
using System.Text.Json;

namespace AltV.Voice
{
    public class Main : IScript
    {
        public static string jsonString = File.ReadAllText(Alt.Server.Resource.Path + "/settings.json");
        public static VoiceModel VoiceModel = JsonSerializer.Deserialize<VoiceModel>(jsonString);
        public static bool DEBUG_MODE_ENABLED = VoiceModel.Debug;
        public static string RESOURCE_VERSION = VoiceModel.Version;

        public static IVoiceChannel channel = Alt.CreateVoiceChannel(VoiceModel.Is3DVoice, VoiceModel.Range);

        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public void PlayerConnect(IPlayer client, string reason) { try { channel.AddPlayer(client); } catch (Exception ex) { Debug.CatchExceptions("OnPlayerConnect", ex); } }

        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public void OnPlayerDisconnect(IPlayer client, string reason) { try { channel.RemovePlayer(client); } catch (Exception ex) { Debug.CatchExceptions("OnPlayerDisconnect", ex); } }
    }
}
