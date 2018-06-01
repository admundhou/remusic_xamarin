using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using System.Collections.Generic;

namespace mymuiscapp
{
    [Activity(Label = "mymuiscapp", MainLauncher = true, Icon = "@mipmap/ic_launcher", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private Android.Support.V7.Widget.Toolbar ab;
        private ImageView barnet, barmusic, barfriends, search;
        private List<ImageView> tabs = new List<ImageView>();
        private DrawerLayout drawerLayout;
        private ListView mLvLeftMenu;
        private long time = 0;

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Window.SetBackgroundDrawableResource(Resource.Color.background_material_light_1);


            barnet = (ImageView)FindViewById(Resource.Id.bar_net);
            barmusic = (ImageView)FindViewById(Resource.Id.bar_music);
            barfriends = (ImageView)FindViewById(Resource.Id.bar_friends);
            search = (ImageView)FindViewById(Resource.Id.bar_search);
            barmusic = (ImageView)FindViewById(Resource.Id.bar_music);
            drawerLayout = (DrawerLayout)FindViewById(Resource.Id.fd);
            mLvLeftMenu = (ListView)FindViewById(Resource.Id.id_lv_left_menu);

            setToolBar();
            setViewPager();
            //setUpDrawer();

        }
        private void setToolBar()
        {
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            ab = toolbar;
            SupportActionBar.SetDisplayShowTitleEnabled(true);//设置不显示标题
            SupportActionBar.SetHomeButtonEnabled(true);//设置返回键可用 
            toolbar.Title = "Toolbar1";
        }

        private void setViewPager()
        {
            tabs.Add(barnet);
            tabs.Add(barmusic);
            //            CustomViewPager customViewPager = (CustomViewPager)findViewById(R.id.main_viewpager);
            //            MainFragment mainFragment = new MainFragment();
            //            final TabNetPagerFragment tabNetPagerFragment = new TabNetPagerFragment();
            //            CustomViewPagerAdapter customViewPagerAdapter = new CustomViewPagerAdapter(getSupportFragmentManager());
            //            customViewPagerAdapter.addFragment(tabNetPagerFragment);
            //            customViewPagerAdapter.addFragment(mainFragment);
            //            customViewPager.setAdapter(customViewPagerAdapter);
            //            customViewPager.setCurrentItem(1);
            //            barmusic.setSelected(true);
            //            customViewPager.addOnPageChangeListener(new ViewPager.OnPageChangeListener() {
            //            @Override
            //            public void onPageScrolled(int position, float positionOffset, int positionOffsetPixels)
            //            {

            //            }

            //            @Override
            //            public void onPageSelected(int position)
            //            {
            //                switchTabs(position);
            //            }

            //            @Override
            //            public void onPageScrollStateChanged(int state)
            //            {

            //            }
            //        });

            //        barnet.setOnClickListener(new View.OnClickListener() {
            //            @Override
            //            public void onClick(View v)
            //        {
            //            customViewPager.setCurrentItem(0);
            //        }
            //    });
            //        barmusic.setOnClickListener(new View.OnClickListener() {
            //            @Override
            //            public void onClick(View v)
            //    {
            //        customViewPager.setCurrentItem(1);
            //    }
            //});

            //        search.setOnClickListener(new View.OnClickListener() {
            //            @Override
            //            public void onClick(View v)
            //{
            //    final Intent intent = new Intent(MainActivity.this, NetSearchWordsActivity.class);
            //                intent.setFlags(Intent.FLAG_ACTIVITY_NO_ANIMATION);
            //                MainActivity.this.startActivity(intent);
            //            }
            //        });
        }
    }
}
