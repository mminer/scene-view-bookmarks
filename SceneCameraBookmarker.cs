using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

class SceneCameraBookmarker
{
    struct Bookmark
    {
        public Vector3 pivot;
        public Quaternion rotation;
    }

    static void BookmarkSceneCamera(int slot, bool writeLog = true)
    {
        var sceneView = SceneView.lastActiveSceneView;
        var bookmark = new Bookmark { pivot = sceneView.pivot, rotation = sceneView.rotation };
        WriteBookmark(bookmark, slot);

        if (writeLog)
        {
            Debug.Log("Bookmarked scene camera position in slot " + slot + ".");
        }
    }

    static string GetBookmarkKey(int slot)
    {
        return "cameraBookmark" + slot;
    }

    static bool IsMoveMenuItemValid(int slot)
    {
        var key = GetBookmarkKey(slot);
        return EditorPrefs.HasKey(key);
    }

    static void MoveSceneCameraToBookmark(int slot)
    {
        if (slot != 0)
        {
            SaveCurrentPosition();
        }

        var bookmark = ReadBookmark(slot);
        var sceneView = SceneView.lastActiveSceneView;
        sceneView.pivot = bookmark.pivot;
        sceneView.rotation = bookmark.rotation;
    }

    static Bookmark ReadBookmark(int slot)
    {
        var key = GetBookmarkKey(slot);
        var json = EditorPrefs.GetString(key);
        return JsonUtility.FromJson<Bookmark>(json);
    }

    static void SaveCurrentPosition()
    {
        BookmarkSceneCamera(0, false);
    }

    static void WriteBookmark(Bookmark bookmark, int slot)
    {
        var key = GetBookmarkKey(slot);
        var json = JsonUtility.ToJson(bookmark);
        EditorPrefs.SetString(key, json);
    }

    #region Menu Items

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &1", false, 100)]
    static void BookmarkSceneCamera1() { BookmarkSceneCamera(1); }

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &2", false, 100)]
    static void BookmarkSceneCamera2() { BookmarkSceneCamera(2); }

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &3", false, 100)]
    static void BookmarkSceneCamera3() { BookmarkSceneCamera(3); }

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &4", false, 100)]
    static void BookmarkSceneCamera4() { BookmarkSceneCamera(4); }

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &5", false, 100)]
    static void BookmarkSceneCamera5() { BookmarkSceneCamera(5); }

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &6", false, 100)]
    static void BookmarkSceneCamera6() { BookmarkSceneCamera(6); }

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &7", false, 100)]
    static void BookmarkSceneCamera7() { BookmarkSceneCamera(7); }

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &8", false, 100)]
    static void BookmarkSceneCamera8() { BookmarkSceneCamera(8); }

    [MenuItem("Window/Scene Camera Bookmarks/Bookmark Scene Camera &9", false, 100)]
    static void BookmarkSceneCamera9() { BookmarkSceneCamera(9); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #1", false, 200)]
    static void MoveSceneCameraToBookmark1() { MoveSceneCameraToBookmark(1); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #2", false, 200)]
    static void MoveSceneCameraToBookmark2() { MoveSceneCameraToBookmark(2); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #3", false, 200)]
    static void MoveSceneCameraToBookmark3() { MoveSceneCameraToBookmark(3); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #4", false, 200)]
    static void MoveSceneCameraToBookmark4() { MoveSceneCameraToBookmark(4); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #5", false, 200)]
    static void MoveSceneCameraToBookmark5() { MoveSceneCameraToBookmark(5); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #6", false, 200)]
    static void MoveSceneCameraToBookmark6() { MoveSceneCameraToBookmark(6); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #7", false, 200)]
    static void MoveSceneCameraToBookmark7() { MoveSceneCameraToBookmark(7); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #8", false, 200)]
    static void MoveSceneCameraToBookmark8() { MoveSceneCameraToBookmark(8); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #9", false, 200)]
    static void MoveSceneCameraToBookmark9() { MoveSceneCameraToBookmark(9); }

    [MenuItem("Window/Scene Camera Bookmarks/Return Scene Camera To Previous Position #0", false, 300)]
    static void ReturnSceneCameraToPreviousPosition() { MoveSceneCameraToBookmark(0); }

    #endregion

    #region Menu Item Validation

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #1", true)]
    static bool ValidateMoveSceneCameraToBookmark1() { return IsMoveMenuItemValid(1); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #2", true)]
    static bool ValidateMoveSceneCameraToBookmark2() { return IsMoveMenuItemValid(2); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #3", true)]
    static bool ValidateMoveSceneCameraToBookmark3() { return IsMoveMenuItemValid(3); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #4", true)]
    static bool ValidateMoveSceneCameraToBookmark4() { return IsMoveMenuItemValid(4); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #5", true)]
    static bool ValidateMoveSceneCameraToBookmark5() { return IsMoveMenuItemValid(5); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #6", true)]
    static bool ValidateMoveSceneCameraToBookmark6() { return IsMoveMenuItemValid(6); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #7", true)]
    static bool ValidateMoveSceneCameraToBookmark7() { return IsMoveMenuItemValid(7); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #8", true)]
    static bool ValidateMoveSceneCameraToBookmark8() { return IsMoveMenuItemValid(8); }

    [MenuItem("Window/Scene Camera Bookmarks/Move Scene Camera #9", true)]
    static bool ValidateMoveSceneCameraToBookmark9() { return IsMoveMenuItemValid(9); }

    [MenuItem("Window/Scene Camera Bookmarks/Return Scene Camera To Previous Position #0", true)]
    static bool ValidateReturnSceneCameraToPreviousPosition() { return IsMoveMenuItemValid(0); }

    #endregion
}
