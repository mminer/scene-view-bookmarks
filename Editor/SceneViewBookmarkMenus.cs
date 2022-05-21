using UnityEditor;

namespace SceneViewBookmarks
{
    static class SceneViewBookmarkMenus
    {
        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 1 #1", false, 100)]
        static void MoveToBookmark1() => SceneViewBookmarkManager.MoveToBookmark(1);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 2 #2", false, 100)]
        static void MoveToBookmark2() => SceneViewBookmarkManager.MoveToBookmark(2);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 3 #3", false, 100)]
        static void MoveToBookmark3() => SceneViewBookmarkManager.MoveToBookmark(3);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 4 #4", false, 100)]
        static void MoveToBookmark4() => SceneViewBookmarkManager.MoveToBookmark(4);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 5 #5", false, 100)]
        static void MoveToBookmark5() => SceneViewBookmarkManager.MoveToBookmark(5);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 6 #6", false, 100)]
        static void MoveToBookmark6() => SceneViewBookmarkManager.MoveToBookmark(6);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 7 #7", false, 100)]
        static void MoveToBookmark7() => SceneViewBookmarkManager.MoveToBookmark(7);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 8 #8", false, 100)]
        static void MoveToBookmark8() => SceneViewBookmarkManager.MoveToBookmark(8);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 9 #9", false, 100)]
        static void MoveToBookmark9() => SceneViewBookmarkManager.MoveToBookmark(9);

        [MenuItem("Window/Scene View Bookmarks/Return to Previous View #0", false, 200)]
        static void ReturnToPreviousView() => SceneViewBookmarkManager.ReturnToPreviousView();

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 1 &1", false, 300)]
        static void SetBookmark1() => SceneViewBookmarkManager.SetBookmark(1);

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 2 &2", false, 300)]
        static void SetBookmark2() => SceneViewBookmarkManager.SetBookmark(2);

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 3 &3", false, 300)]
        static void SetBookmark3() => SceneViewBookmarkManager.SetBookmark(3);

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 4 &4", false, 300)]
        static void SetBookmark4() => SceneViewBookmarkManager.SetBookmark(4);

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 5 &5", false, 300)]
        static void SetBookmark5() => SceneViewBookmarkManager.SetBookmark(5);

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 6 &6", false, 300)]
        static void SetBookmark6() => SceneViewBookmarkManager.SetBookmark(6);

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 7 &7", false, 300)]
        static void SetBookmark7() => SceneViewBookmarkManager.SetBookmark(7);

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 8 &8", false, 300)]
        static void SetBookmark8() => SceneViewBookmarkManager.SetBookmark(8);

        [MenuItem("Window/Scene View Bookmarks/Set Bookmark 9 &9", false, 300)]
        static void SetBookmark9() => SceneViewBookmarkManager.SetBookmark(9);

        #region Validation

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 1 #1", true)]
        static bool ValidateMoveToBookmark1() => SceneViewBookmarkManager.HasBookmark(1);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 2 #2", true)]
        static bool ValidateMoveToBookmark2() => SceneViewBookmarkManager.HasBookmark(2);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 3 #3", true)]
        static bool ValidateMoveToBookmark3() => SceneViewBookmarkManager.HasBookmark(3);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 4 #4", true)]
        static bool ValidateMoveToBookmark4() => SceneViewBookmarkManager.HasBookmark(4);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 5 #5", true)]
        static bool ValidateMoveToBookmark5() => SceneViewBookmarkManager.HasBookmark(5);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 6 #6", true)]
        static bool ValidateMoveToBookmark6() => SceneViewBookmarkManager.HasBookmark(6);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 7 #7", true)]
        static bool ValidateMoveToBookmark7() => SceneViewBookmarkManager.HasBookmark(7);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 8 #8", true)]
        static bool ValidateMoveToBookmark8() => SceneViewBookmarkManager.HasBookmark(8);

        [MenuItem("Window/Scene View Bookmarks/Move to Bookmark 9 #9", true)]
        static bool ValidateMoveToBookmark9() => SceneViewBookmarkManager.HasBookmark(9);

        [MenuItem("Window/Scene View Bookmarks/Return to Previous View #0", true)]
        static bool ValidateReturnToPreviousView() => SceneViewBookmarkManager.hasPreviousView;

        #endregion
    }
}
