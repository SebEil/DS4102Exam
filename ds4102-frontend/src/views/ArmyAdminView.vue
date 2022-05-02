<template>
    <section>
        <edit-mission></edit-mission>
        <missions-list></missions-list>
    </section>
</template>


<script>
import EditMission from '../components/missions/EditMission.vue'
import MissionsList from '../components/missions/MissionsList.vue'



export default {
    components: { 
        MissionsList,
        EditMission 
    }
}
</script>

