using UnityEditor;
using UnityEngine;

namespace SceneViewBookmarks
{
    static class SceneViewBookmarkManager
    {
        public const string iconPath = "Packages/com.matthewminer.sceneviewbookmarks/Icons/SceneViewBookmarksIcon.png";
        public const int maxBookmarkCount = 9;

        const int previousViewSlot = 0;
        
        public static bool hasPreviousView => HasBookmark(previousViewSlot);
        
        public static bool HasBookmark(int slot)
        {
            var key = GetEditorPrefsKey(slot);
            return EditorPrefs.HasKey(key);
        }

        public static void MoveToBookmark(int slot)
        {
            // Bookmark the current scene view so that we can easily return to it later.
            if (slot != previousViewSlot)
            {
                SetBookmark(previousViewSlot);
            }

            var bookmark = ReadFromEditorPrefs(slot);
            var sceneView = SceneView.lastActiveSceneView;
            sceneView.pivot = bookmark.pivot;
            sceneView.rotation = bookmark.rotation;
            sceneView.size = bookmark.size;
        }

        public static void ReturnToPreviousView()
        {
            MoveToBookmark(previousViewSlot);
        }

        public static void SetBookmark(int slot)
        {
            var bookmark = new SceneViewBookmark(SceneView.lastActiveSceneView);
            WriteToEditorPrefs(slot, bookmark);

            if (slot != previousViewSlot)
            {
                Debug.Log("Bookmarked scene view in slot " + slot + ".");
            }
        }
        
        static string GetEditorPrefsKey(int slot)
        {
            return "sceneViewBookmark" + slot;
        }

        static SceneViewBookmark ReadFromEditorPrefs(int slot)
        {
            var key = GetEditorPrefsKey(slot);
            var json = EditorPrefs.GetString(key);
            return JsonUtility.FromJson<SceneViewBookmark>(json);
        }
        
        static void WriteToEditorPrefs(int slot, SceneViewBookmark bookmark)
        {
            var key = GetEditorPrefsKey(slot);
            var json = JsonUtility.ToJson(bookmark);
            EditorPrefs.SetString(key, json);
        }
    }
}
