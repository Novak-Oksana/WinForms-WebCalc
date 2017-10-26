
		var last_number = false;
		var result = 0;
		var last_operator = '+';
		
		function funct_calc(a, b, op) {
			switch(op)
			{
				case '+':
				    return parseInt(a) + parseInt(b);
				case '-':
				    return parseInt(a) - parseInt(b);
				case '*':
				    return parseInt(a) * parseInt(b);
				case '/':
				    return parseInt(a) / (b);
			}
			return "Not Supported";
		}
		function set_last_operator(op){
                last_operator = op;
            }

        function calculate(num){
				result = funct_calc(result, num, last_operator);
        }

        function get_result(){
                return result;
        }
		function fNum(button){
			if (last_number)
                txtres.value = txtres.value + button.value;
            else
                txtres.value = button.value;

            last_number = true;
        }
	    function opClick(button){
		    var res = document.getElementById("txtres").value;
            var op = button.value;
            calculate(res);
            set_last_operator(op);
            last_number = false;
        }
		function btnEqual(button){
		    var res = document.getElementById("txtres").value;
            calculate(res);
            txtres.value = get_result();
            last_number = false;
        }
		

