$(document).ready(function () {
    $('#calendar').fullCalendar({
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        },
        defaultView: 'agendaWeek',
        editable: true,
        allDaySlot: false,
        selectable: true,
        slotMinutes: 30,
        minTime: "07:00:00",
        maxTime: "20:00:00",



        dayClick: function (date, allDay, jsEvent, view) {
            $('#eventTitle').val("");
            $('#eventDate').val($.fullCalendar.formatDate(date, 'MM/DD/YYYY'));
            $('#eventTime').val($.fullCalendar.formatDate(date, 'HH:mm'));
            ShowEventPopup(date);
        },
    });


    $('#btnPopupCancel').click(function () {
        ClearPopupFormValues();
        $('#popupEventForm').hide();
    });

    $('#btnPopupSave').click(function () {

        $('#popupEventForm').hide();

        var dataRow = {
            'ClassId': $('#Class').val(),
            'InstructorId': $('#Instructor').val(),
            'NewEventDate': $('#eventDate').val(),
            'NewEventTime': $('#eventTime').val(),
            'NewEventDuration': $('#eventDuration').val()
        }

        ClearPopupFormValues();

        $.ajax({
            type: 'POST',
            url: "/MasterSchedules/Create",
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(dataRow),
            success: function (response) {
                if (response == 'True') {
                    //$('#calendar').fullCalendar('refetchEvents');
                    alert('New event saved!');
                }
                else {
                    alert('Error, could not save event!');
                }
            }
        });
    });

    function ShowEventPopup(date) {
        ClearPopupFormValues();
        $('#popupEventForm').show();
        $('#eventTitle').focus();
    }


    function ClearPopupFormValues() {
        //$('#eventID').val("");
        //$('#eventTitle').val("");
        $('#Class').val("");
        $('#Instructor').val("");
        $('#eventDateTime').val("");
        $('#eventDuration').val("");
    }
});