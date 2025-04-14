using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPrefsList
{
    public static event Action<string, List<string>> OnListChanged;

    public static void SaveStringList(string key, IEnumerable<string> values)
    {
        List<string> list = values.ToList();
        PlayerPrefs.SetString(key, string.Join("|", list));
        PlayerPrefs.Save();
        OnListChanged?.Invoke(key, list);
    }

    public static List<string> LoadStringList(string key)
    {
        return PlayerPrefs.HasKey(key) ? PlayerPrefs.GetString(key).Split('|').ToList() : new List<string>();
    }

    public static void AppendToList(string key, string value)
    {
        List<string> list = LoadStringList(key);
        list.Add(value);
        SaveStringList(key, list);
    }

    public static void RemoveFromList(string key, string value)
    {
        List<string> list = LoadStringList(key);
        if (list.Remove(value))
            SaveStringList(key, list);
    }

    public static void ClearList(string key)
    {
        PlayerPrefs.DeleteKey(key);
        OnListChanged?.Invoke(key, new List<string>());
    }
}