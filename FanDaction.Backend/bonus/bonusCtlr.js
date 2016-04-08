function bonusCtlr($scope, $animate, dataservice) {
    vm = this;

    vm.bonuses = [];

    loadBonuses();

    function loadBonuses() {

    }

    function change(action, parameter, enable, condition) {
        var inputsArray = new Array();
        if(condition == 'true')
        {
            if(confirm('Are you sure you want to ' + action + ' this Bonus? '))
            {
                if(action == 'update')
                {

                }

                if(action == 'add')
                {
                    inputsArray = CollectBonusFormData('bonusAddInFormationForm');
                    for(var i=0; i < inputsArray.length; i++)
                    {
                        inputName = inputsArray[i].name;
                        inputValue = inputsArray[i].value;

                    }
                }
            }
        }
    }
}