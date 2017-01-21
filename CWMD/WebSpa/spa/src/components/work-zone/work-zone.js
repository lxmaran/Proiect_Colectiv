'use strict';
app
    .component('workZone',
    {
        templateUrl: 'spa/src/components/work-zone/work-zone.html',
        controller: function () {
            const $ctrl = this;
            $scope.fileSelected = function(element) {
                $ctrl.file = element.files[0];
            };

            $ctrl.previewFile = () => {
                var preview = document.querySelector('img');
                $ctrl.file = document.querySelector('input[type=file]').files[0];
                var reader = new FileReader();
                reader.addEventListener("load",
                    function() {
                        DocumentsService.uploadDocument(reader.result);
                    },
                    false);
                if ($ctrl.file) {
                    reader.readAsDataURL($ctrl.file);
                }
//                
            $ctrl.files = [];
           

            function uploadFiles(files){
                Upload.upload({
                    url: apiUrl,
                    data: { file: files }
                })
                  .then(function (response) {
                      
                  }, function (err) {
                      console.log("Error status: " + err.status);
                     
                  });

                $window.location.reload();
            }
        }
    });