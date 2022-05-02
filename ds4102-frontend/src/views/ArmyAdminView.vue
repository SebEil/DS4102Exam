<template>
    <section>
        <h2 class="text-center">Army Admin Page</h2>
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

<style scoped>
    .text-center{
        margin-top: -1.9rem ;
    }
</style>

