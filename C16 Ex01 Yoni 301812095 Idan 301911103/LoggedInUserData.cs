using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public class LoggedInUserData
    {
        private static User m_LoggedInUser = null;
        private LoggedInUserData() { }
        public static User GetInstance
        {
            get
            {
                if(m_LoggedInUser == null)
                {
                    LoginResult result = FacebookService.Login("857311881068409",
                    "public_profile",
                    "user_education_history",
                    "user_birthday",
                    "user_actions.video",
                    "user_actions.news",
                    "user_actions.music",
                    "user_actions.fitness",
                    "user_actions.books",
                    "user_about_me",
                    "user_friends",
                    "publish_actions",
                    "user_events",
                    "user_games_activity",
                    "user_hometown",
                    "user_likes",
                    "user_location",
                    "user_managed_groups",
                    "user_photos",
                    "user_posts",
                    "user_relationships",
                    "user_relationship_details",
                    "user_religion_politics",
                    "user_tagged_places",
                    "user_videos",
                    "user_website",
                    "user_work_history",
                    "read_custom_friendlists",
                    "read_page_mailboxes",
                    "manage_pages",
                    "publish_pages",
                    "publish_actions",
                    "rsvp_event"
                );
                    m_LoggedInUser = result.LoggedInUser;  
                }
                    return m_LoggedInUser;
             }
        }
    }
}
