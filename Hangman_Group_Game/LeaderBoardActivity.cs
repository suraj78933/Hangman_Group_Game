﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Hangman_Group_Game.Bussiness;
using Hangman_Group_Game.Data;

namespace Hangman_Group_Game
{
    [Activity(Label = "Leaderboards", Theme = "@style/AppTheme")]
    public class LeaderBoardActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private ListView lstLeaderboard;
        private List<Users> myList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_leaderboard);
            Init();
        }

        private void Init()
        {
            lstLeaderboard = FindViewById<ListView>(Resource.Id.lstLeaderboard);

            myList = Database.LoadUsers();
            var dataAdapter = new LeaderboardDataAdapter(this, myList);
            lstLeaderboard.Adapter = dataAdapter;

            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_play:
                    StartActivity(typeof(MainActivity));
                    return true;
                case Resource.Id.navigation_leaderboard:
                    StartActivity(typeof(LeaderBoardActivity));
                    return true;
                case Resource.Id.navigation_profile:
                    StartActivity(typeof(UserProfileActivity));
                    return true;
            }
            return false;
        }
    }
}