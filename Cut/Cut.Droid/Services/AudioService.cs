using System;
using Xamarin.Forms;
using Cut.Droid;
using Android.Media;

[assembly: Dependency(typeof(AudioService))]

namespace Cut.Droid
{
    public class AudioService : IAudio
    {
        public AudioService() { }

        private MediaPlayer _mediaPlayer;

        public bool PlayMp3File(string uri)
        {
            _mediaPlayer = MediaPlayer.Create(global::Android.App.Application.Context, Android.Net.Uri.Parse(uri) );
            _mediaPlayer.Start();

            return true;
        }
        
    }
}