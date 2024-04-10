namespace PIMTool.Winforms.Controls
{
    internal class NavigationButtons
    {
        private readonly List<Button> _listButtons;
        private Color _defaultColor;
        private Color _selectedColor;

        public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            _listButtons = buttons;
            _defaultColor = defaultColor;
            _selectedColor = selectedColor;

            SetButtonColor();
        }

        private void SetButtonColor()
        {
            foreach (Button button in _listButtons)
            {
                button.BackColor = _defaultColor;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach (Button button in _listButtons)
            {
                if (button == selectedButton)
                {
                    selectedButton.BackColor = _selectedColor;
                }
                else
                {
                    button.BackColor = _defaultColor;
                }
            }
        }
    }
}