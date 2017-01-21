'use strict';
app
    .component('workZone',
    {
        templateUrl: 'spa/src/components/work-zone/work-zone.html',
        controller: function ($scope, DocumentsService) {
            const $ctrl = this;
            $scope.fileSelected = function(element) {
                $ctrl.file = element.files[0];
            };

            $ctrl.previewFile = () => {
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
            }
        }
    });