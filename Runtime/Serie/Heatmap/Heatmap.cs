
using UnityEngine;

namespace XCharts
{
    [System.Serializable]
    [SerieHandler(typeof(HeatmapHandler), true)]
    [DefaultAnimation(AnimationType.LeftToRight)]
    [SerieExtraComponent(typeof(LabelStyle), typeof(Emphasis))]
    public class Heatmap : Serie, INeedSerieContainer
    {
        public int containerIndex { get; internal set; }
        public int containterInstanceId { get; internal set; }
        public static void AddDefaultSerie(BaseChart chart, string serieName)
        {
            var serie = chart.AddSerie<Heatmap>(serieName);
            serie.itemStyle.show = true;
            serie.itemStyle.borderWidth = 1;
            serie.itemStyle.borderColor = Color.clear;

            var emphasis = serie.AddExtraComponent<Emphasis>();
            emphasis.show = true;
            emphasis.itemStyle.show = true;
            emphasis.itemStyle.borderWidth = 1;
            emphasis.itemStyle.borderColor = Color.black;
        }
    }
}