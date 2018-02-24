eveApp.controller('AdminIndexController', function ($scope, $http) {

    $scope.urls = {
        getOrganizations:"",
        getRoles:"",
        getCountries:"",
        getCities:"",
        getTags:"",
        getTickets:"",
        getUsers:""
    }

    $scope.filterTimer = null;
    $scope.table = {
        filter: {},
        visibleTable: {
            organizations: false,
            roles: false,
            countries: false,
            cities: false,
            tags: false,
            tickets: false,
            users: false
        },
        items: [],
        lastUrl: "",
        cleanTableAddiction: () => {
            $scope.table.filter = {};
        }
    }

    $scope.getOrganizations = () => {
        updateItems($scope.urls.getOrganizations, $scope.table.items, $scope.table.filter);
    }
    $scope.getRoles = () => {
        updateItems($scope.urls.getUsers, $scope.table.items, $scope.table.filter);
    }
    $scope.getCountries = () => {
        updateItems($scope.urls.getCountries, $scope.table.items, $scope.table.filter);
    }
    $scope.getCities = () => {
        updateItems($scope.urls.getCities, $scope.table.items, $scope.table.filter);
    }
    $scope.getTags = () => {
        updateItems($scope.urls.getTags, $scope.table.items, $scope.table.filter);
    }
    $scope.getTickets = () => {
        updateItems($scope.urls.getTickets, $scope.table.items, $scope.table.filter);
    }
    $scope.getUsers = () => {
        updateItems($scope.urls.getUsers, $scope.table.items, $scope.table.filter);
    }

    function updateItems(url, items, filter) {
        $http.get(url, filter).then((request) => {
            if (request.success) {
                angular.copy(request.data, items);
            }
        });
    }

    $scope.filterDelayed = function () {
        if ($scope.filterTimer) {
            clearTimeout($scope.filterTimer);
            $scope.filterTimer = null;
        }
        $scope.filterTimer = setTimeout($scope.table.lastUrl, 1000);//todo i think, here need to binding to a context
    };
})