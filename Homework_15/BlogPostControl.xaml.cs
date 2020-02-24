using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework_15
{
    /// <summary>
    /// Логика взаимодействия для BlogPostControl.xaml
    /// </summary>
    public partial class BlogPostControl : UserControl
    {
        public string PostTitle
        {
            get => (string)GetValue(PostTitleProperty);
            set => SetValue(PostTitleProperty, value);
        }
        public string PostDescription
        {
            get => (string)GetValue(PostDescriptionProperty);
            set => SetValue(PostDescriptionProperty, value);
        }

        public string PostAuthor
        {
            get => (string)GetValue(PostAuthorProperty);
            set => SetValue(PostAuthorProperty, value);
        }

        public BitmapImage PostAvatar
        {
            get => (BitmapImage)GetValue(PostAvatarProperty);
            set=>SetValue(PostAvatarProperty, value);
        }

        public static readonly DependencyProperty PostTitleProperty = DependencyProperty.Register(nameof(PostTitle),
            typeof(string), typeof(BlogPostControl),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnPostTitleChanged));

        public static readonly DependencyProperty PostDescriptionProperty = DependencyProperty.Register(
            nameof(PostDescription), typeof(string), typeof(BlogPostControl),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                OnPostDescriptionChanged));

        public static readonly DependencyProperty PostAuthorProperty = DependencyProperty.Register(nameof(PostAuthor),
            typeof(string), typeof(BlogPostControl),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                OnPostAuthorChanged));

        public static readonly DependencyProperty PostAvatarProperty = DependencyProperty.Register(nameof(PostAvatar),
            typeof(BitmapImage), typeof(BlogPostControl),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnPostAvatarChanged));

        private static void OnPostAvatarChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is BlogPostControl post)
            {
                post.ImagePostAvatar.Source = (BitmapImage) e.NewValue;
            }
        }

        private static void OnPostAuthorChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is BlogPostControl post)
            {
                post.TxtbPostAuthor.Text = e.NewValue?.ToString();
            }
        }

        private static void OnPostDescriptionChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is BlogPostControl post)
            {
                post.TxtbPostDescription.Text = e.NewValue?.ToString();
            }
        }

        private static void OnPostTitleChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is BlogPostControl post)
            {
                post.TxtbPostTitle.Text = e.NewValue?.ToString();
            }
        }
        public BlogPostControl()
        {
            InitializeComponent();
        }
    }
}
