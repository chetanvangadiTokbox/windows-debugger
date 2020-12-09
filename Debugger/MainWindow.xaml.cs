using System;
using System.Windows;
using OpenTok;
using System.Windows.Media.Imaging;
using System.Windows.Controls.Primitives;
using System.Windows.Shapes;
using System.Data;

namespace Debugger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string API_KEY = "100";
        private const string SESSION_ID = "2_MX4xMDB-fjE2MDUxMjQ1NzQ0NTR-STZQeEFBKzRsUjJreGdFWUJHRVVqdW9hfn4";
        private const string TOKEN = "T1==cGFydG5lcl9pZD0xMDAmc2RrX3ZlcnNpb249dGJwaHAtdjAuOTEuMjAxMS0wNy0wNSZzaWc9MmI0ZGRmNTg0YmI2NzNkZTljZDdhZjdkNmRkODI3MGQ0OTE5MTE0ZjpzZXNzaW9uX2lkPTJfTVg0eE1EQi1makUyTURVeE1qUTFOelEwTlRSLVNUWlFlRUZCS3pSc1VqSnJlR2RGV1VKSFJWVnFkVzloZm40JmNyZWF0ZV90aW1lPTE2MDUxMjQ1NzQmcm9sZT1tb2RlcmF0b3Imbm9uY2U9MTYwNTEyNDU3NC41MDkyMTQ3Mjg0NDkyOCZleHBpcmVfdGltZT0xNjA3NzE2NTc0";

        private static String environment = null;
        private static bool sessionTypeIsP2P = false;
        private static bool isConnectionEventSupressed = false;
        Session session;
        Publisher publisher;
        Stream stream;
        Subscriber subscriber;
        bool SUBSCRIBE_TO_SELF = false;
        bool deleteLater = true;

        public MainWindow()
        {
            InitializeComponent();
            create_session.Visibility = Visibility.Hidden;
            hidePublisherButtons(true);
            hideSubscriberButtons(true);
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            publisher?.Dispose();
        }

        private void Subscriber_StreamDisconnected(object sender, EventArgs e)
        {
            Console.WriteLine("Subscriber: Stream Disconnected ");
            hideSubscriberButtons(true);
            cleanUpSubscriber();
            subscriber = null;
        }

        private void Session_Connected(object sender, EventArgs e)
        {
            Console.WriteLine("Session: Session Connected ");
            connect_button.Content = "Disconnect";

            publisher = new Publisher.Builder(Context.Instance)
            {
                Renderer = publisherVideo
            }
            .Build();

            setPublisherCallbacks(publisher);
            hidePublisherButtons(false);
        }

        private void Session_StreamDropped(object sender, Session.StreamEventArgs e)
        {
            Console.WriteLine("Session: Stream Dropped ");
        }

        private void Session_StreamReceived(object sender, Session.StreamEventArgs e)
        {
            Console.WriteLine("Session: Stream Received ");
            stream = e.Stream;
            subscriber_button.Visibility = Visibility.Visible;
            if (deleteLater)
            {


            }
            else
            {
                //Console.WriteLine("in else");
                //VideoRenderer renderer = new VideoRenderer();
                //subscriberGrid.Children.Add(renderer);
                ////UpdateGridSize(subscriberGrid.Children.Count);
                //Subscriber subscriber = new Subscriber(Context.Instance, e.Stream, renderer);
                //try
                //{
                //    session.Subscribe(subscriber);
                //}
                //catch (OpenTokException ex)
                //{
                //    Console.WriteLine("OpenTokException " + ex.ToString());
                //}
            }
        }
        //private void UpdateGridSize(int numberOfSubscribers)
        //{
        //    int rows = Convert.ToInt32(Math.Round(Math.Sqrt(numberOfSubscribers)));
        //    int cols = rows == 0 ? 0 : Convert.ToInt32(Math.Ceiling(((double)numberOfSubscribers) / rows));
        //    subscriberGrid.Columns = cols;
        //    subscriberGrid.Rows = rows;
        //}
        private void Session_Error(object sender, Session.ErrorEventArgs e)
        {
            Console.WriteLine("Session: Session Error ");
        }

        private void Session_ConnectionCreated(object sender, Session.ConnectionEventArgs e)
        {
            Console.WriteLine("Session: Connection Created ");
        }

        private void Session_Disconnected(object sender, EventArgs e)
        {
            Console.WriteLine("Session: SessionDisconnected ");
            cleanUpSession();
        }

        private void Publisher_StreamCreated(object sender, Publisher.StreamEventArgs e)
        {
            updatePublisherDataTable();
            if (SUBSCRIBE_TO_SELF == true)
            {
                Console.WriteLine("Publisher Stream Created" + e.Stream.Id);
                stream = e.Stream;
                subscriber_button.Visibility = Visibility.Visible;
            }
        }

        private void Publisher_Error(object sender, Publisher.ErrorEventArgs e)
        {
            Console.WriteLine("Publisher: Publisher error");
        }

        private void Publisher_StreamDestroyed(object sender, Publisher.StreamEventArgs e)
        {
            Console.WriteLine("Publisher: Stream Destroyed");
        }

        private void Subscriber_Connected(object sender, EventArgs e)
        {
            Console.WriteLine("Subscriber: Subscriber Connected ");
        }

        private void Subscriber_StreamReconnected(object sender, EventArgs e)
        {
            Console.WriteLine("Subscriber: Stream Reconnected ");
        }


        private void Subscriber_Error(object sender, Subscriber.ErrorEventArgs e)
        {
            Console.WriteLine("Subscriber: Subscriber error" + e.ErrorDescription);
        }

        private void create_session_controller(object sender, RoutedEventArgs e)
        {
            //Rectangle rect = new Rectangle();
            //rect.Width = 500;
            //rect.Height = 500;

            //Popup mypop = new Popup();

            //mypop.Child = rect; // just to put something inside the popup for now           
            //mypop.PopupAnimation = PopupAnimation.Slide;
            //mypop.StaysOpen = false;
            //mypop.PlacementTarget = create_session; // open next to the button
            //mypop.IsOpen = true;
            //myPopup.PopupAnimation = PopupAnimation.Scroll;
            //myPopup.IsOpen = true;
            Console.WriteLine("create_session_controller");
            CreateSessionPopup createSessionPopupWindow = new CreateSessionPopup();
            System.Windows.Forms.DialogResult dialogResult = createSessionPopupWindow.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                environment = CreateSessionPopup.environmentSelected;
                sessionTypeIsP2P = CreateSessionPopup.sessionTypeIsP2P;
                isConnectionEventSupressed = CreateSessionPopup.isConnectionEventSupressed;
            }
          
            Closing += MainWindow_Closing;
            connect_button.Visibility = Visibility.Visible;
        }

        private void connectController(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Connect Controller: Connecting to Session ");
            if (connect_button.Content.Equals("Connect"))
            {
                try
                {
                    session = new Session.Builder(Context.Instance, API_KEY, SESSION_ID).Build();
                    setSessionCallbacks(session);
                }
                catch (OpenTokException exception)
                {
                    Console.WriteLine(exception.Data);
                }

                session.Connect(TOKEN);
                connect_button.Content = "Disconnect";
            }
            else
            {
                session.Disconnect();
                //cleanUpSession();
                //hidePublisherButtons(true);
            }
        }

        private void publisherController(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Publisher Controller: Publishing to session");
            if (publisher_button.Content.Equals("Publish"))
            {
                try
                {
                    PublisherSettingsPopup publishSettingsPopup = new PublisherSettingsPopup();
                    System.Windows.Forms.DialogResult dialogResultPublisherPopup
                        = publishSettingsPopup.ShowDialog();
                    if (dialogResultPublisherPopup == System.Windows.Forms.DialogResult.OK)
                    {
                        publisher.PublishAudio = PublisherSettingsPopup.isAudioEnabled;
                        publisher.PublishVideo = PublisherSettingsPopup.isVideoEnabled;
                    }
                    session.Publish(publisher);
                    publisherDataTable.Visibility = Visibility.Visible;
                }
                catch (OpenTokException exception)
                {
                    Console.WriteLine(exception.Data);
                }
                publisher_button.Content = "Unpublish";
                publisherVideo.Visibility = Visibility.Visible;
            }
            else if (publisher_button.Content.Equals("Unpublish"))
            {
                try
                {
                    session.Unpublish(publisher);
                }
                catch (OpenTokException exception)
                {
                    Console.WriteLine(exception.Data);
                }
                cleanUpPublisher();
                publisherVideo.Visibility = Visibility.Hidden;
                publisherDataTable.Visibility = Visibility.Hidden;
            }
        }

        private void publihser_audio_button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (publisher != null)
            {
                if (publisher.PublishAudio == true)
                {
                    publisher.PublishAudio = false;
                    publihser_audio_button.Source = new BitmapImage(new Uri(@"Resources/publisher_mute.png", UriKind.Relative));
                }
                else
                {
                    publisher.PublishAudio = true;
                    publihser_audio_button.Source = new BitmapImage(new Uri(@"Resources/publisher_audio.png", UriKind.Relative));
                }
                updatePublisherDataTable();
            }
        }

        private void subscriberController(object sender, RoutedEventArgs e)
        {
            if ("Subscribe".Equals(subscriber_button.Content))
            {
                Console.WriteLine("subscriber controller" + stream.Id);
                subscriber = new Subscriber.Builder(Context.Instance, stream)
                {
                    Renderer = subscriberVideo
                }
                .Build();
                setSubscriberCallbacks(subscriber);
                session.Subscribe(subscriber);
                subscriber_button.Content = "Unsubscribe";
                hideSubscriberButtons(false);
                subscriberVideo.Visibility = Visibility.Visible;
                subscriberDataTable.Visibility = Visibility.Visible;
                updateSubscriberDataTable();
            }
            else
            {
                if (subscriber != null)
                {
                    try
                    {
                        session.Unsubscribe(subscriber);
                    }
                    catch (OpenTokException exception)
                    {
                        Console.WriteLine(exception.Data);
                    }
                    cleanUpSubscriber();
                }
            }
        }

        private void subscriber_audio_button_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (subscriber != null)
            {
                if (subscriber.SubscribeToAudio == true)
                {
                    subscriber.SubscribeToAudio = false;
                    subscriber_audio_button.Source = new BitmapImage(new Uri(@"Resources/subscriber_mute.png", UriKind.Relative));
                }
                else
                {
                    subscriber.SubscribeToAudio = true;
                    subscriber_audio_button.Source = new BitmapImage(new Uri(@"Resources/subscriber_audio.png", UriKind.Relative));
                }
                updateSubscriberDataTable();
            }
        }

        private void cleanUpSession()
        {
            connect_button.Content = "Connect";
            hidePublisherButtons(true);
            hideSubscriberButtons(true);
            cleanUpPublisher();
            cleanUpSubscriber();
            publisher = null;
            subscriber = null;
        }

        private void cleanUpPublisher()
        {
             publisher_button.Content = "Publish";
             publisherDataTable.Visibility = Visibility.Hidden;
            
        }

        private void cleanUpSubscriber()
        {
            subscriber_button.Content = "Subscribe";
            subscriberVideo.Visibility = Visibility.Hidden;
            subscriberDataTable.Visibility = Visibility.Hidden;
        }

        private void hidePublisherButtons(bool value)
        {
            if (value)
            {
                publisher_button.Visibility = Visibility.Hidden;
                publihser_audio_button.Visibility = Visibility.Hidden;
                publisherVideo.Visibility = Visibility.Hidden;
                publisherDataTable.Visibility = Visibility.Hidden;
            }
            else
            {
                publisher_button.Visibility = Visibility.Visible;
                publihser_audio_button.Visibility = Visibility.Visible;
            }
        }

        private void hideSubscriberButtons(bool value)
        {
            if (value)
            {
                subscriber_button.Visibility = Visibility.Hidden;
                subscriber_audio_button.Visibility = Visibility.Hidden;
                subscriberVideo.Visibility = Visibility.Hidden;
                subscriberDataTable.Visibility = Visibility.Hidden;
            }
            else
            {
                subscriber_button.Visibility = Visibility.Visible;
                subscriber_audio_button.Visibility = Visibility.Visible;
            }
        }

        private void setSessionCallbacks(Session session)
        {
            session.Connected += Session_Connected;
            session.ConnectionCreated += Session_ConnectionCreated;
            session.Disconnected += Session_Disconnected;
            session.Error += Session_Error;
            session.StreamReceived += Session_StreamReceived;
            session.StreamDropped += Session_StreamDropped;
        }

        private void setPublisherCallbacks(Publisher publisher)
        {
            publisher.StreamCreated += Publisher_StreamCreated;
            publisher.StreamDestroyed += Publisher_StreamDestroyed;
            publisher.Error += Publisher_Error;
        }

        private void setSubscriberCallbacks(Subscriber subscriber)
        {
            subscriber.StreamDisconnected += Subscriber_StreamDisconnected;
            subscriber.StreamReconnected += Subscriber_StreamReconnected;
            subscriber.VideoDisabled += Subscriber_VideoDisabled;
            subscriber.VideoEnabled += Subscriber_VideoEnabled;
            subscriber.Connected += Subscriber_Connected;
            subscriber.Error += Subscriber_Error;
        }

        private void Subscriber_VideoEnabled(object sender, Subscriber.VideoEventArgs e)
        {
            Console.WriteLine("Subscriber Video Enabled");
        }

        private void Subscriber_VideoDisabled(object sender, Subscriber.VideoEventArgs e)
        {
            Console.WriteLine("Subscriber Video Disabled");
        }

        private void disable_publisher_video(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Console.WriteLine("publisher video mouse down");
            if (publisher != null)
            {
                if (publisher.PublishVideo == true)
                {
                    publisher.PublishVideo = false;
                }
                else
                {
                    publisher.PublishVideo = true;
                }
                updatePublisherDataTable();
            }
        }

        private void disable_subscriber_video(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Console.WriteLine("Subscriber video mouse down");
            if (subscriber != null)
            {
                if (subscriber.SubscribeToVideo == true)
                {
                    subscriber.SubscribeToVideo = false;
                }
                else
                {
                    subscriber.SubscribeToVideo = true;
                }
                updateSubscriberDataTable();
            }
        }

        private void subscriber_settings(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        class PublisherSubscriberInfo
        {
            public string Field { get; set; }
            public string Value { get; set; }
        }

        private void updatePublisherDataTable()
        {
            PublisherData.Items.Clear();
            PublisherData.Items.Add(new PublisherSubscriberInfo() { Field = "Stream ID", Value = publisher.Stream.Id });
            PublisherData.Items.Add(new PublisherSubscriberInfo() { Field = "Audio", Value = Convert.ToString(publisher.PublishAudio) });
            PublisherData.Items.Add(new PublisherSubscriberInfo() { Field = "Video", Value = Convert.ToString(publisher.PublishVideo) });
        }

        private void updateSubscriberDataTable()
        {
            SubscriberData.Items.Clear();
            SubscriberData.Items.Add(new PublisherSubscriberInfo() { Field = "Subscriber ID", Value = subscriber.Id });
            SubscriberData.Items.Add(new PublisherSubscriberInfo() { Field = "Audio", Value = Convert.ToString(subscriber.SubscribeToAudio) });
            SubscriberData.Items.Add(new PublisherSubscriberInfo() { Field = "Video", Value = Convert.ToString(subscriber.SubscribeToVideo) });
        }
    }
}
