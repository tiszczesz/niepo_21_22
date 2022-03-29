<?php
function GetColors(): array
{
    return [
        "biały" => "white",
        "żółty" => "yellow",
        "czerwony" => "red",
        "szary" => "grey",
        "różowy" => "pink",
        "zielony" => "green"
    ];
}
function ShowForm(string $color): string
{
    return <<< TEXT
    <div class="up">
        <form method="post">
            <label for="answer">{$color}</label>
            <input type="hidden" name="color" value='{$color}'>
            <input type="text" name="answer" id="answer">
            <input type="submit" value="Zatwierdź">
        </form>
    </div>
TEXT;
}
