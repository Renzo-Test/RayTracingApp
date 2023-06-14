using System;

namespace Domain
{
    public class Log
    {
        private int _renderTime;
        private Client _owner;
        private string _renderDate;
        private string _timeSpan;
        private string _sceneName;
        private int _renderedElements;

        public int Id { get; set; }
        public int RenderTime
        {
            get => _renderTime;
            set => _renderTime = value;
        }
        public Client Owner
        {
            get => _owner;
            set => _owner = value;
        }
        public string RenderDate
        {
            get => _renderDate;
            set => _renderDate = value;
        }
        public string TimeSpan
        {
            get => _timeSpan;
            set => _timeSpan = value;
        }
        public string SceneName
        {
            get => _sceneName;
            set => _sceneName = value;
        }
        public int RenderedElements
        {
            get => _renderedElements;
            set => _renderedElements = value;
        }
    }
}
