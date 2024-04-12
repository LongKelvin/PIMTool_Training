using MetroSet_UI.Controls;

namespace PIMTool.Winforms.Controls
{
    public class NavigationButtons
    {
        private readonly List<MetroSetButton> _listButtons;
        private Color _defaultColor;
        private Color _selectedColor;

        public NavigationButtons(List<MetroSetButton> buttons, Color defaultColor, Color selectedColor)
        {
            _listButtons = buttons;
            _defaultColor = defaultColor;
            _selectedColor = selectedColor;

            SetButtonColor();
        }

        private void SetButtonColor()
        {
            foreach (MetroSetButton button in _listButtons)
            {
                button.BackColor = _defaultColor;
            }
        }

        public void Highlight(MetroSetButton selectedButton)
        {
            foreach (MetroSetButton button in _listButtons)
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