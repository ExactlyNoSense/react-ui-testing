using SKBKontur.SeleniumTesting.Assertions;
using SKBKontur.SeleniumTesting.Controls;

namespace SKBKontur.SeleniumTesting
{
    public static class ControlAssertionsExtensions
    {
        public static InputAssertions ExpectTo(this Input input)
        {
            return ExpectTo(new SingleItemAssertable<Input>(input));
        }

        public static InputAssertions ExpectTo(this IAssertable<Input> input)
        {
            return new InputAssertions(input);
        }

        public static ComboBoxAssertions ExpectTo(this ComboBox input)
        {
            return ExpectTo(new SingleItemAssertable<ComboBox>(input));
        }

        public static ComboBoxAssertions ExpectTo(this IAssertable<ComboBox> input)
        {
            return new ComboBoxAssertions(input);
        }

        public static ButtonAssertions ExpectTo(this Button input)
        {
            return ExpectTo(new SingleItemAssertable<Button>(input));
        }

        public static ButtonAssertions ExpectTo(this IAssertable<Button> input)
        {
            return new ButtonAssertions(input);
        }

        public static CheckBoxAssertions ExpectTo(this CheckBox input)
        {
            return ExpectTo(new SingleItemAssertable<CheckBox>(input));
        }

        public static CheckBoxAssertions ExpectTo(this IAssertable<CheckBox> input)
        {
            return new CheckBoxAssertions(input);
        }

        public static LinkAssertions ExpectTo(this Link input)
        {
            return ExpectTo(new SingleItemAssertable<Link>(input));
        }

        public static LinkAssertions ExpectTo(this IAssertable<Link> input)
        {
            return new LinkAssertions(input);
        }

        public static GenericAssertions<Select> ExpectTo(this Select input)
        {
            return ExpectTo(new SingleItemAssertable<Select>(input));
        }

        public static GenericAssertions<Select> ExpectTo(this IAssertable<Select> input)
        {
            return new GenericAssertions<Select>(input);
        }

        public static GenericAssertions<ModalBase> ExpectTo(this ModalBase input)
        {
            return ExpectTo(new SingleItemAssertable<ModalBase>(input));
        }

        public static GenericAssertions<ModalBase> ExpectTo(this IAssertable<ModalBase> input)
        {
            return new GenericAssertions<ModalBase>(input);
        }

        public static LabelAssertions ExpectTo(this Label input)
        {
            return ExpectTo(new SingleItemAssertable<Label>(input));
        }

        public static LabelAssertions ExpectTo(this IAssertable<Label> input)
        {
            return new LabelAssertions(input);
        }

        public static ControlBaseAssertions ExpectTo(this ControlBase input)
        {
            return ExpectTo(new SingleItemAssertable<ControlBase>(input));
        }

        public static ControlBaseAssertions ExpectTo(this IAssertable<ControlBase> input)
        {
            return new ControlBaseAssertions(input);
        }

        public static ControlListAssertions<TItem> ExpectTo<TItem>(this ControlList<TItem> input) where TItem : ControlBase
        {
            return new ControlListAssertions<TItem>(new SingleItemAssertable<ControlList<TItem>>(input));
        }

        public static CompoundControlAssertions<CompoundControl> ExpectTo(this CompoundControl control)
        {
            return ExpectTo(new SingleItemAssertable<CompoundControl>(control));
        }

        public static CompoundControlAssertions<CompoundControl> ExpectTo(this IAssertable<CompoundControl> control)
        {
            return new CompoundControlAssertions<CompoundControl>(control);
        }
    }
}