using System.Text.Encodings.Web;
using System.Text.Json;

namespace Skola.Models;

public class JsonStorage {
    private static JsonSerializerOptions _options = new(){
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };
    public static void WriteJson(string path, List<Course>courses) {
        // Write JSon File
        
        var json = JsonSerializer.Serialize(courses, _options);
        File.WriteAllText(path, json);

        
        
        
    }

    public static List<Course>ReadJs(string path) {
        _options = new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true,
        };
        // Read Json File
        var savedJson = File.ReadAllText(path);
        var savedCourses = JsonSerializer.Deserialize<List<Course>>(savedJson, _options);
        return savedCourses!;
    }
}