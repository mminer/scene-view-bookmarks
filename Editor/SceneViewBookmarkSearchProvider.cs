using UnityEditor;
using UnityEditor.Search;
using UnityEngine;

namespace SceneViewBookmarks
{
    /// <summary>
    /// Adds an alternative way to access bookmarks via Unity's Search window.
    /// </summary>
    static class SceneViewBookmarkSearchProvider
    {
        const string id = "scene-view-bookmarks";
        
        [SearchItemProvider]
        static SearchProvider CreateProvider()
        {
            var icon = AssetDatabase.LoadAssetAtPath<Texture2D>(SceneViewBookmarkManager.iconPath);
            
            return new SearchProvider(id, "Scene View Bookmarks")
            {
                actions =
                {
                    new SearchAction(id, "Move to Bookmark", null, null, HandleMoveToBookmark),
                },
                fetchItems = (context, items, provider) =>
                {
                    if (int.TryParse(context.searchQuery, out var slot) && SceneViewBookmarkManager.HasBookmark(slot))
                    {
                        var item = provider.CreateItem(context, slot.ToString(), slot.ToString(), $"Scene View Bookmark {slot}", icon, null);
                        items.Add(item);
                    }

                    return null;
                },
                filterId = "svb:",
                isExplicitProvider = true,
            };
        }

        static void HandleMoveToBookmark(SearchItem item)
        {
            var slot = int.Parse(item.id);
            SceneViewBookmarkManager.MoveToBookmark(slot);
        }
    }
}
