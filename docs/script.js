function insert(code)
{
	location = "rdr://designer/insert?" + code.id;
}
function copy(code)
{
	textRange = document.body.createTextRange();
	textRange.moveToElementText(code);
	textRange.execCommand("Copy");
	alert("実行例をクリップボードへコピーしました。");
}