//textboxのfizzbuzzを実行
function StartFizzBuzzTextbox(){
	//textboxのオブジェクトを取得
	var fizz = document.getElementById("textFizz");
	var buzz = document.getElementById("textBuzz");
	var maxCount = document.getElementById("textMaxCount");
		
	//表示結果
	var resultText = "";	
	//テキスト表示用オブジェクトの取得
	var objTextArea = document.getElementById("resultTextArea");
	
	//入力チェック
	if(!ValidateParam(fizz,buzz,maxCount))
	{
		//入力値が正しくない場合、処理の中断
		return false;
	}
	
	//fizzbuzz結果作成処理
	for(var i = 1; i <= maxCount.value; i++)
	{
		//改行コード
		var br = "\r\n";
		//3の倍数かつ5の倍数の場合
		if(i % 3 == 0 && i % 5 == 0)
		{
			resultText += (fizz.value + buzz.value + br);
		}
		//3の倍数の場合
		else if(i % 3 == 0)
		{
			resultText += (fizz.value + br);
		}
		//5の倍数の場合
		else if(i % 5 == 0)
		{
			resultText += (buzz.value + br);
		}
		else
		{
			resultText += (i + br);
		}
	}
	
	//結果を表示エリアに出力
	objTextArea.value = resultText;	

	
}

//canvasにfizzbuzzの結果を表示
function StartFizzBuzzCanvas(){
	//textboxのオブジェクトを取得
	var fizz = document.getElementById("textFizz");
	var buzz = document.getElementById("textBuzz");
	var maxCount = document.getElementById("textMaxCount");
	
	//表示結果
	var resultText = new Array(maxCount);
	//テキスト表示用オブジェクトの取得
	var objTextArea = document.getElementById("resultTextArea");
	
	//入力チェック
	if(!ValidateParam(fizz,buzz,maxCount))
	{
		//入力値が正しくない場合、処理の中断
		return false;
	}
	
	//fizzbuzz結果作成処理
	for(var i = 1; i <= maxCount.value; i++)
	{
		//3の倍数かつ5の倍数の場合
		if(i % 3 == 0 && i % 5 == 0)
		{
			resultText[i] = (fizz.value + buzz.value);
		}
		//3の倍数の場合
		else if(i % 3 == 0)
		{
			resultText[i] = fizz.value;
		}
		//5の倍数の場合
		else if(i % 5 == 0)
		{
			resultText[i] = buzz.value;
		}
		else
		{
			resultText[i] = i;
		}
	}
	
	//formのオブジェクトを取得
	var formObj = document.canvasTimer;

	//結果を表示エリアに出力
	if(!canvasFlg){
		DrawResult(resultText,maxCount.value,formObj);
	}
	
}

//実行ボタンで描画を重複させないためのフラグ
var canvasFlg = false;
//canvasへ表示するためのタイマー処理
function DrawResult(resultArray,maxCount,formObj){
	if(!canvasFlg){
		canvasFlg = true;
	}
	//繰り返し回数をカウント
	formObj.count.value++; 
	
	//canvasの取得
	var canvas = document.getElementById("resultCanvas");
	var context = canvas.getContext('2d');
	//テキスト描画のスタイルを指定する
    context.fillStyle = "blue";
    context.font = "30px 'ＭＳ ゴシック'";
    context.textAlign = "center";
    context.textBaseline = "top";
	context.clearRect(0, 0, 500, 500);
	context.fillText(resultArray[formObj.count.value],150,50);
	
	if(formObj.count.value < Number(maxCount))
	{
		//setTimeout関数内でのfunctionに引数を渡したい場合、無名関数を使用する
		setTimeout(function(){DrawResult(resultArray,maxCount,formObj);},800);
	}
	else
	{
		formObj.count.value　= 0;
		canvasFlg = false;
	}
}


//入力値のチェック
function ValidateParam(fizz,buzz,maxCount){
	var alertStr = "";
	var errorFlg = false;
	//id:textFizzの入力チェック
	if(fizz.value.length > 10)
	{
		alertStr += "fizzの文字数を10桁以内にしてください。\r\n";
		fizz.value = "";
		errorFlg = true;
	}	
	//id:textBuzzの入力チェック
	if(buzz.value.length > 10)
	{
		alertStr += "buzzの文字数を10桁以内にしてください。\r\n";
		buzz.value = "";
		errorFlg = true;
	}
	//id:textMaxCountの入力チェック
	if(maxCount.value.length > 4 || maxCount.value.match(/[^0-9]+/) || maxCount.value == "")
	{
		alertStr += "試行回数の桁数を4桁以内の半角整数で入力してください。";
		maxCount.value = "";
		errorFlg = true;
	}
	else if(maxCount.value == "0")
	{
		return false;
	}
	
	//入力に不備があった場合
	if(errorFlg){
		alert(alertStr);
		return false;
	}
	
	return true;
}