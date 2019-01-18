# XF iOS `FormattedString` with multple `Span`s Bug
Reproduction of a `FormattedString` related bug on iOS using `Xamarin.Forms` 3.4.0.1009999.

### Reproduction steps:
- Add a `Label` control with multiple `Span`s with `TapGestureRecognizer`s to the `MainPage`
```
<Label
    FontSize="Micro"
    VerticalTextAlignment="Center"
    HorizontalTextAlignment="Center">
    <Label.FormattedText>
        <FormattedString>
            <Span Text="Long text about how we respect your privacy but you should actually check " />
            <Span Text=" Twitter " TextColor="Purple">
                <Span.GestureRecognizers>
                    <TapGestureRecognizer Tapped="OpenPP" />
                </Span.GestureRecognizers>
            </Span>
            <Span Text="and" />
            <Span Text=" Google" TextColor="Purple">
                <Span.GestureRecognizers>
                    <TapGestureRecognizer Tapped="OpenToc" />
                </Span.GestureRecognizers>
            </Span>
            <Span Text="." />
        </FormattedString>
    </Label.FormattedText>
</Label>
```

### Actual result:
Both of the `Twitter` & `Google` `TapGestureRecognizer`s are not working. 


### Expected result:
Both of the `Twitter` & `Google` `TapGestureRecognizer`s should work as expected. 
