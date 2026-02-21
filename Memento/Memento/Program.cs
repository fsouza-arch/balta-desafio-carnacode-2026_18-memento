using Memento.Application;

var app = new ImageApplicationService();

app.Show();

app.Brightness(20);
app.Rotate(90);
app.Filter("Sepia");

app.Show();

app.Undo();
app.Show();