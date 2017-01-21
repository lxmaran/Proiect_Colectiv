'use strict';
app
    .component('workZone',
    {
        templateUrl: 'spa/src/components/work-zone/work-zone.html',
        controller: function (DocumentsService) {
            const $ctrl = this;
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

            $ctrl.documents = [{}];
            DocumentsService.getDocuments().then(response => $ctrl.documents = response);

            $ctrl.uploadFiles = uploadFiles;

        }
    });