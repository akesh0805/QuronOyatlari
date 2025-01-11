using System.Net.Http.Json;
using QuronOyatlari.Data;

namespace QuronOyatlari.Services;

public class SurahsService(HttpClient httpClient)
{
    public async Task<List<Surah>>? GetAllSurahs()
    {
        var allSurahs = await httpClient.GetFromJsonAsync<AllSurahs>("https://api.alquran.cloud/v1/surah");
        return allSurahs?.Data ?? [];
    }
    public async Task<SurahTranslationData>? GetSurahTranlationAsync(int surahNumber, int ayahNumber)
    {
        var response = await httpClient.GetFromJsonAsync<SurahTranslationResponse>($"https://api.alquran.cloud/v1/ayah/{surahNumber}:{ayahNumber}/uz.sodik");
        if (response != null && response.Data != null)
        {
            return new SurahTranslationData
            {
                Number = response.Data.Number,
                Text = response.Data.Text,
                Surah = response.Data.Surah
            };
        }
        return null;
    }

    public async Task<string>? GetSurahPng(int surahNumber, int ayahNumber)
    {
        var url = $"https://cdn.islamic.network/quran/images/{surahNumber}_{ayahNumber}.png";
        var response = await httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            return url;
        }
        return string.Empty;
    }

    public async Task<string>? GetSurahAudio(int surahNumber)
    {
        var url = $"https://cdn.islamic.network/quran/audio-surah/128/ar.alafasy/{surahNumber}.mp3";
        var response = await httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            return url;
        }
        return string.Empty;
    }
}