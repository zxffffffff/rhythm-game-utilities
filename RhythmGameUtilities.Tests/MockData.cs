namespace RhythmGameUtilities.Tests
{

    public static class MockData
    {

        public const string MOCK_JSON_CONTENTS =
            @"{""Name"":""Example Song"",""Artist"":""Example Artist"",""Album"":""Example Album"",""Genre"":""Example Genre"",""Year"":"", 2021"",""Charter"":""Example Charter"",""Resolution"":192,""Difficulty"":4,""Offset"":0.56,""PreviewStart"":45.28,""PreviewEnd"":75.28,""MusicStream"":""Example Song.ogg"",""Lyrics"":{},""Difficulties"":{""Expert"":[{""Position"":768,""HandPosition"":0,""Length"":0},{""Position"":864,""HandPosition"":1,""Length"":0},{""Position"":864,""HandPosition"":5,""Length"":0},{""Position"":960,""HandPosition"":2,""Length"":0},{""Position"":960,""HandPosition"":6,""Length"":0},{""Position"":1056,""HandPosition"":3,""Length"":0},{""Position"":1152,""HandPosition"":4,""Length"":0},{""Position"":1248,""HandPosition"":7,""Length"":0}]},""BPM"":{""0"":88000,""3840"":112000,""9984"":89600,""22272"":112000,""33792"":111500,""34560"":112000,""42240"":111980},""BaseBPM"":88}";

        public const string MOCK_CHART_CONTENTS = @"[Song]
{
  Name = ""Example Song""
  Artist = ""Example Artist""
  Album = ""Example Album""
  Genre = ""Example Genre""
  Year = "", 2021""
  Charter = ""Example Charter""
  Resolution = 192
  Difficulty = 4
  Offset = 0.56
  PreviewStart = 45.28
  PreviewEnd = 75.28
  MusicStream = ""Example Song.ogg""
}
[SyncTrack]
{
  0 = TS 4
  0 = B 88000
  3840 = B 112000
  9984 = TS 2 1
  9984 = B 89600
  22272 = TS 4
  22272 = B 112000
  33792 = B 111500
  34560 = B 112000
  42240 = B 111980
  69120 = TS 2 1
}
[Events]
{
  768 = E ""section Intro""
  9984 = E ""phrase_start""
  9984 = E ""section Verse 1""
  10080 = E ""lyric Stand""
  10208 = E ""lyric in""
  10344 = E ""lyric line""
  10496 = E ""lyric as""
  10608 = E ""lyric we""
  10736 = E ""lyric march""
  10896 = E ""lyric to""
  11008 = E ""lyric the""
  11112 = E ""lyric drums""
  11268 = E ""lyric of""
  11400 = E ""lyric the""
  11520 = E ""lyric east""
  11904 = E ""phrase_end""
}
[ExpertSingle]
{
  768 = N 0 0
  768 = S 64 768
  864 = N 1 0
  864 = N 5 0
  960 = N 2 0
  960 = N 6 0
  1056 = N 3 0
  1056 = E solo
  1152 = N 4 0
  1248 = N 7 0
  1248 = E soloend
}";

    }

}
