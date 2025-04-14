using System;
using System.IO;
using UnityEngine;

public static class ImageManager
{
    public static void SaveTexture(Texture2D textureToSave, ScanType scanType)
    {
        var _filePath = Path.Combine("Assets/Resources/ScannedDrawings");
        if (!Directory.Exists(_filePath))
            Directory.CreateDirectory(_filePath);
        
        var timestamp = DateTime.Now.ToString("MMdd_HHmmss");
        var textureFilePath = Path.Combine(_filePath, $"scanned_drawing_{timestamp}.png");
        var bytes = textureToSave.EncodeToPNG();
        
        File.WriteAllBytes(textureFilePath, bytes);

        var key = scanType switch
        {
            ScanType.Troll => Consts.TrollKey,
            ScanType.Butterfly => Consts.ButterflyKey,
            _ => ""
        };

        PlayerPrefsList.AppendToList(key, textureFilePath);
    }

    public static Texture2D LoadTexture(string filePath)
    {
        if (File.Exists(filePath))
        {
            var bytes = File.ReadAllBytes(filePath);
            var loadedTexture = new Texture2D(2, 2);
            
            loadedTexture.LoadImage(bytes);
            return loadedTexture;
        }

        return null;
    }
}