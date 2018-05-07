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
        minTime: "20:00:00"
    });
});